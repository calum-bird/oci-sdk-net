﻿using OCISDK.Core.src.Core.Model.VirtualNetwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Core.Response.VirtualNetwork
{
    public class UpdateRouteTableResponse
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
        /// The response body will contain a single RouteTable resource.
        /// </summary>
        public RouteTable RouteTable { get; set; }
    }
}