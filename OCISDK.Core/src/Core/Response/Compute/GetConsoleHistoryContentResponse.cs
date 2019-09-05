﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Core.Response.Compute
{
    public class GetConsoleHistoryContentResponse
    {
        /// <summary>
        /// The number of bytes remaining in the snapshot.
        /// </summary>
        public string OpcBytesRemaining { get; set; }

        /// <summary>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.
        /// </summary>
        public string OpcRequestId { get; set; }

        public string Contents { get; set; }
    }
}
