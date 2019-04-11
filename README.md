# Bimface.SDK
A unofficial .NET SDK for BIMFACE

## Service list

### Infrastructure  service list

| Service Interface | Description                                                  |
| ----------------- | ------------------------------------------------------------ |
| ILogService       | Service to provide logger for bimface sdk to output infos and errors. |
| IJsonSerializer   | Service to provide convert between json strings and structured objects. Json.NET is used by default. |
| IRestClient       | Service to send HTTP requests. HttpWebRequest is used by default. |
| IHttpRequest      | Interface representing an HTTP request. Users can get necessary information from this interface. |
| IHttpResponse     | Interface representing an HTTP response. Users can get necessary information from this interface. |
| IResponseHandler  | Service to handle an HTTP response. By default the sdk converts the response to GeneralResponse<T> |

### Business service list

| Service Interface      | Description                                            |
| ---------------------- | ------------------------------------------------------ |
| ICompareDataService    | Service handling the business about compare model data |
| ICompareService        | Service handling the business about compare model      |
| IDatabagService        | Service handling the business about databag            |
| IDSLDataService        | Service handling the business using DSL query          |
| IFileDataService       | Service handling the business about file data          |
| IFileService           | Service handling the business about file               |
| IIntegrateDataService  | Service handling the business about integration data   |
| IIntegrateService      | Service handling the business about integration        |
| IOfflineDatabagService | Service handling the business about offline databag    |
| IRfaService            | Service handling the business about rfa                |
| IShareService          | Service handling the business about share link         |
| ITranslateService      | Service handling the business about file translation   |
| IViewTokenService      | Service handling the business about view token         |

## Usage

All business service interface methods are asynchronized method using TAP.

### Straight way:
```csharp
public void Foo()
{
    //create a credential with the app key and secret from bimface
    var credential = new AppCredential("your app key","your app secret");
    //create the client
    var client = BimfaceClient.GetOrCreate(credential);
    //get the service you want
    var shareService = client.GetService<IShareService>();
    //create a service parameter for later invoke
    var parameter = new ListSharesParameter();
    //invoke the service method to get the result and hanle the result when responded
    shareService.ListShares(parameter).ContinueWith(task=>{
        var result = task.Result;
        //get a json serializer from the client
        var jsonSerializer = client.GetService<IJsonSerializer>();
        
        Console.WriteLine(jsonSerializer.Serialize(result));
    });
}
```

### Using async / await

```csharp
public async Task Bar()
{
    //create a credential with the app key and secret from bimface
    var credential = new AppCredential("your app key","your app secret");
    //create the client
    var client = BimfaceClient.GetOrCreate(credential);
    //get the service you want
    var shareService = client.GetService<IShareService>();
    //create a service parameter for later invoke
    var parameter = new ListSharesParameter();
    //invoke the service method to get the result and hanle the result when responded
    var result = await shareService.ListShares(parameter);
    //get a json serializer from the client
    var jsonSerializer = client.GetService<IJsonSerializer>();
    
    Console.WriteLine(jsonSerializer.Serialize(result));
}
```

### Service replacement

BimfaceClient is supported by IServiceContainer. 

It is possible for the user to replace the services in that container

#### Example

Bimface SDK outputs all the logs to the Console by [default](https://github.com/KennanChan/Bimface.SDK/blob/master/Bimface.SDK.Standard/Bimface.SDK.Standard/Services/DefaultLogger.cs).

User can replace this log service with log4net

```csharp
//User implementation of ILogService using log4net
public class MyLogger : ILogService
{
    public void Debug(Type logType, object log)
    {
    	GetLoggerProvidedByLog4Net(logType).Debug(log);
    }
    
    public void Error(Type logType, object log)
    {
    	GetLoggerProvidedByLog4Net(logType).Error(log);
    }
    
    public void Info(Type logType, object log)
    {
    	GetLoggerProvidedByLog4Net(logType).Info(log);
    }
    
    private ILog GetLoggerProvidedByLog4Net(Type type)
    {
    	return LogManager.GetLogger(type);
    }
}

public void ServiceReplace()
{
    //create a credential with the app key and secret from bimface
    var credential = new AppCredential("your app key","your app secret");
    //create the client
    var client = BimfaceClient.GetOrCreate(credential);
    //the default ILogService will be replace by MyLogger
    client.Singleton<ILogService, MyLogger>();
    //get the log service
    var logService = client.GetService<ILogService>();
    logService.Info(typeof(SomeType), "Hello Bimface!");
}
```

### Service Container

Bimface sdk can also be used as a service container to serve other business.

```csharp
public interface IBusiness
{
    void Foo();
}

public class Business : IBusiness
{
	public void Foo()
    {
    	Console.Log("Hello, Bimface!");
    }
}

public void ServiceRegister()
{
    //create a credential with the app key and secret from bimface
    var credential = new AppCredential("your app key","your app secret");
    //create the client
    var client = BimfaceClient.GetOrCreate(credential);
    //register the IBusiness service as a singleton using Business as implementation
    client.Singleton<IBusiness, Business>();
    //get the IBusiness service instance
    var business = client.GetService<IBusiness>();
    business.Foo();
}
```

### Use external container

It is likely that container is used by many business system. Bimface sdk can make use of the existing Container. The only requirement is an adapter of the container

```csharp
public class Container
{
    //implementation of the already existing container
}

public class ContainerAdapter : IServiceContainer
{
	private Container Container { get; }
	public ContainerAdapter(Container container)
    {
    	Container = container;
    }
    
	//implementation of the IServiceContainer using the Container
}

public void UseExistingContainer()
{
    //create a credential with the app key and secret from bimface
    var credential = new AppCredential("your app key","your app secret");
    //create the client
    var client = BimfaceClient.GetOrCreate(credential, new ContainerAdapter());
    //register the IBusiness service as a singleton using Business as implementation
    client.Singleton<IBusiness, Business>();
    //get the IBusiness service instance
    var business = client.GetService<IBusiness>();
    business.Foo();
}
```

### Request Plugin

Request plugins runs before any API request is about to sent out. User can define their own plugin to do extra business.

It is useful when there is a change in the bimface server side API but the sdk doesn't update in time.

The only thing is to define the plugin and make sure the assembly is referenced by the AppDomain. Bimface sdk will find it when initializing. Plugins in an assembly that is loaded at runtime (after bimface client has initialized) can also be resolved.

```csharp
//in MyLibrary.dll
public class MyPlugin : IRequestPlugin
{
	//should be invoked
	public Task HandleRequest(HttpParameter parameter, HttpRequest request)
    {
    	if(parameter is LookupFileShareParameter)
    	{
    		request.AddQuery("query name","query value");
    	}
    	return Task.CompletedTask;
    }
}
```

