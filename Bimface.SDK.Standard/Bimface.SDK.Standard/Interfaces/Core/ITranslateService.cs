#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Translate;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface ITranslateService
    {
        #region Others

        /// <summary>
        ///     Create a translation for the given file
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>The <see cref="FileTranslateEntity"/> instance</returns>
        Task<FileTranslateEntity> CreateTranslate(CreateTranslateParameter parameter);

        /// <summary>
        ///     Lookup the status of a translation for the given file
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>The <see cref="FileTranslateEntity"/> instance</returns>
        Task<FileTranslateEntity> LookupTranslate(LookupTranslateParameter parameter);

        #endregion
    }
}