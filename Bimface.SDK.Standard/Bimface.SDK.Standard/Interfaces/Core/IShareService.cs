#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Share;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IShareService
    {
        #region Others

        /// <summary>
        ///     Create a share link for the given file
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>The <see cref="ShareLinkEntity"/> instance</returns>
        Task<ShareLinkEntity> CreateShare(CreateFileShareParameter parameter);

        /// <summary>
        ///     Create a share link for the given integration
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>The <see cref="ShareLinkEntity"/> instance</returns>
        Task<ShareLinkEntity> CreateShare(CreateIntegrateShareParameter parameter);

        /// <summary>
        ///     Delete a share link of the given file
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns></returns>
        Task<string> DeleteShare(DeleteFileShareParameter parameter);

        /// <summary>
        ///     Delete a share link of the given integration
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns></returns>
        Task<string> DeleteShare(DeleteIntegrateShareParameter parameter);

        /// <summary>
        ///     Get the <see cref="ShareLinkEntity"/> for the given file
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>The <see cref="ShareLinkEntity"/> instance</returns>
        Task<ShareLinkEntity> GetShare(LookupFileShareParameter parameter);

        /// <summary>
        ///     Get the <see cref="ShareLinkEntity"/> for the given integration
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>The <see cref="ShareLinkEntity"/> instance</returns>
        Task<ShareLinkEntity> GetShare(LookupIntegrateShareParameter parameter);

        /// <summary>
        ///     List all the <see cref="ShareLinkEntity"/> that have been created
        /// </summary>
        /// <param name="parameter">The parameter required for the request</param>
        /// <returns>All the instances of <see cref="ShareLinkEntity"/></returns>
        Task<ShareLinkEntity[]> ListShares(ListSharesParameter parameter);

        #endregion
    }
}