﻿using OCISDK.Core.src.Identity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Identity.Response
{
    public class UpdatePolicyResponse
    {
        /// <summary>
        /// For optimistic concurrency control. See if-match.
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// response header parameter opcRequestId
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// The response body will contain a single Policy resource.
        /// </summary>
        public Policy Policy { get; set; }
    }
}