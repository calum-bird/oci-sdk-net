﻿using OCISDK.Core.Core.Model.Compute;

namespace OCISDK.Core.Core.Response.Compute
{
    /// <summary>
    /// AttachBootVolume Response
    /// </summary>
    public class AttachBootVolumeResponse
    {
        /// <summary>
        /// response header parameter ETag
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Unique Oracle-assigned identifier for the request. 
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// The response body will contain a single BootVolumeAttachment resource.
        /// </summary>
        public BootVolumeAttachment BootVolumeAttachment { get; set; }
    }
}
