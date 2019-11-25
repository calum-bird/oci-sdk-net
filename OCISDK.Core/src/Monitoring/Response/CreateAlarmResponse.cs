﻿using OCISDK.Core.src.Monitoring.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Monitoring.Response
{
    /// <summary>
    /// CreateAlarm Response
    /// </summary>
    public class CreateAlarmResponse
    {
        /// <summary>
        /// For optimistic concurrency control. See if-match.
        /// </summary>
        public string Etag { get; set; }

        /// <summary>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// The response body will contain a single Alarm resource.
        /// </summary>
        public AlarmModel AlarmModel { get; set; }
    }
}
