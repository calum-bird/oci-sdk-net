﻿using OCISDK.Core.src.LoadBalancer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.LoadBalancer.Response
{
    /// <summary>
    /// ListHostnames Response
    /// </summary>
    public class ListHostnamesResponse
    {
        /// <summary>
        /// Unique Oracle-assigned identifier for the request. 
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// The response body will contain an array of BackendSet resources.
        /// </summary>
        public List<HostnameDetails> Items { get; set; }
    }
}