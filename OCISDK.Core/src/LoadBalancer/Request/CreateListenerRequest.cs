﻿using OCISDK.Core.src.LoadBalancer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.LoadBalancer.Request
{
    /// <summary>
    /// CreateListener Request
    /// </summary>
    public class CreateListenerRequest
    {
        /// <summary>
        /// The unique Oracle-assigned identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// <para>Required: no</para>
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or server error 
        /// without risk of executing that same action again. 
        /// Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations 
        /// (e.g., if a resource has been deleted and purged from the system, then a retry of the original creation 
        /// request may be rejected).
        /// <para>Required: no</para>
        /// <para>Min Length: 1, Max Length: 64</para>
        /// </summary>
        public string OpcRetryToken { get; set; }

        /// <summary>
        /// The OCID of the load balancer associated with the backend set and servers.
        /// <para>Required: yes</para>
        /// </summary>
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The request body must contain a single CreateListenerDetails resource.
        /// </summary>
        public CreateListenerDetails CreateListenerDetails { get; set; }
    }
}
