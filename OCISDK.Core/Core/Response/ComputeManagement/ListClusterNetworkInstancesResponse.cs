﻿using System;
using System.Collections.Generic;
using System.Text;
using OCISDK.Core.Core.Model.ComputeManagement;

namespace OCISDK.Core.Core.Response.ComputeManagement
{
    /// <summary>
    /// ListClusterNetworkInstances response
    /// </summary>
    public class ListClusterNetworkInstancesResponse
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
        /// The response body will contain an array of InstanceSummary resources.
        /// </summary>
        public List<InstanceSummary> Items { get; set; }
    }
}