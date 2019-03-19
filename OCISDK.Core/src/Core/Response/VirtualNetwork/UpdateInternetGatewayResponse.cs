﻿/// <summary>
/// UpdateInternetGatewayResponse class
/// 
/// author: koutaro furusawa
/// </summary>

using OCISDK.Core.src.Core.Model.VirtualNetwork;

namespace OCISDK.Core.src.Core.Response.VirtualNetwork
{
    public class UpdateInternetGatewayResponse
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
        /// The response body will contain a single Error resource.
        /// </summary>
        public InternetGateway InternetGateway { get; set; }
    }
}
