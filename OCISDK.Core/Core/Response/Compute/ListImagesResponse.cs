﻿using OCISDK.Core.Core.Model.Compute;
using System.Collections.Generic;

namespace OCISDK.Core.Core.Response.Compute
{
    /// <summary>
    /// ListImages Response
    /// </summary>
    public class ListImagesResponse
    {
        /// <summary>
        /// Unique Oracle-assigned identifier for the request.
        /// If you need to contact Oracle about a particular request,
        /// please provide the request ID.
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// For list pagination.
        /// When this header appears in the response, additional pages of results remain.
        /// For important details about how pagination works
        /// </summary>
        public string OpcNextPage { get; set; }

        /// <summary>
        /// The response body will contain an array of Image resources.
        /// </summary>
        public List<Image> Items { get; set; }
    }
}
