﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.LoadBalancer.Request
{
    /// <summary>
    /// GetRuleSet Request
    /// </summary>
    public class GetRuleSetRequest
    {
        /// <summary>
        /// The unique Oracle-assigned identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// <para>Required: no</para>
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// The OCID of the load balancer associated with the backend server health status to be retrieved.
        /// <para>Required: yes</para>
        /// </summary>
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The name of the rule set to retrieve.
        /// <para>Required: yes</para>
        /// </summary>
        public string RuleSetName { get; set; }
    }
}
