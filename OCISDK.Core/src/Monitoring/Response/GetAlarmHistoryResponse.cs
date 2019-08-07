﻿using OCISDK.Core.src.Monitoring.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Monitoring.Response
{
    public class GetAlarmHistoryResponse
    {
        /// <summary>
        /// response header parameter opcRequestId
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// For pagination of a list of items. When paging through a list, 
        /// if this header appears in the response, 
        /// then a partial list might have been returned. 
        /// Include this value as the page parameter for the subsequent GET request to get the next batch of items.
        /// </summary>
        public string OpcNextPage { get; set; }

        /// <summary>
        /// The response body will contain a single AlarmHistoryCollection resource.
        /// </summary>
        public AlarmHistoryCollection AlarmHistoryCollection { get; set; }
    }
}
