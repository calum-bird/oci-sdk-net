﻿using OCISDK.Core.src.Identity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Identity.Request
{
    public class UpdatePolicyRequest
    {
        /// <summary>
        /// The OCID of the policy.
        /// <para>Required: yes</para>
        /// </summary>
        public string PolicyId { get; set; }

        /// <summary>
        /// For optimistic concurrency control.
        /// In the PUT or DELETE call for a resource, set the if-match parameter to the 
        /// value of the etag from a previous GET or POST response for that resource. 
        /// The resource will be updated or deleted only if the etag you provide matches 
        /// the resource's current etag value.
        /// <para>Required: no</para>
        /// <para>if-match header parameter</para>
        /// </summary>
        public string IfMatch { get; set; }

        public UpdatePolicyDetails UpdatePolicyDetails { get; set; }
    }
}