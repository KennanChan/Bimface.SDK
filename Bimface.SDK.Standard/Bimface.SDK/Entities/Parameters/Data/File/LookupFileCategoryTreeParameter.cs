﻿#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/tree", Method =
#if NETSTANDARD
            HttpMethods.Get
#else
            HttpMethods.Post
#endif
    )]
    public class LookupFileCategoryTreeParameter : FileParameter
    {
        #region Constructors

        public LookupFileCategoryTreeParameter(long fileId) : base(fileId)
        {
        }

        #endregion

        #region Properties

        [HttpBodyComponent]
        public FileTreeRequest FileTreeRequest { get; set; }

        /// <summary>
        ///     The format of the tree, representing v in the api document
        /// </summary>
        [HttpQueryComponent(Alias = "v")]
        public string TreeFormat { get; set; }

        [HttpQueryComponent]
        public string TreeType { get; set; }

        #endregion
    }
}