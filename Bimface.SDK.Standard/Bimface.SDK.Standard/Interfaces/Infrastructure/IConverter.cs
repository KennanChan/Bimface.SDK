namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface IConverter<TSource, TTarget>
    {
        TTarget Convert(TSource source);
        TSource ConvertBack(TTarget target);
    }
}