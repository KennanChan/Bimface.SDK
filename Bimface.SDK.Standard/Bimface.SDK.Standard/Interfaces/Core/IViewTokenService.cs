#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Parameters.View;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IViewTokenService
    {
        #region Others

        /// <summary>
        ///     Fetch a view token for a compare model
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>The view token</returns>
        Task<string> FetchViewToken(FetchCompareViewTokenParameter parameter);

        /// <summary>
        ///     Fetch a view token for a file model
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>The view token</returns>
        Task<string> FetchViewToken(FetchFileViewTokenParameter parameter);

        /// <summary>
        ///     Fetch a view token for a sub file of an integrate model
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>The view token</returns>
        Task<string> FetchViewToken(FetchIntegrateFileViewTokenParameter parameter);

        /// <summary>
        ///     Fetch a view token for an integrate model
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>The view token</returns>
        Task<string> FetchViewToken(FetchIntegrateViewTokenParameter parameter);

        #endregion
    }
}