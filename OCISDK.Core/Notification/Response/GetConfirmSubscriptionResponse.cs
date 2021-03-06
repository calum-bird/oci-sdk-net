﻿using OCISDK.Core.Notification.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.Notification.Response
{
    /// <summary>
    /// GetConfirmSubscription response
    /// </summary>
    public class GetConfirmSubscriptionResponse
    {
        /// <summary>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// For optimistic concurrency control. See if-match.
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// The response body will contain a single ConfirmationResult resource.
        /// </summary>
        public ConfirmationResult ConfirmationResult { get; set; }
    }
}
