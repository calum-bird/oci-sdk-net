﻿using OCISDK.Core.src.Database.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Database.Response
{
    public class ListDbSystemsResponse
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
        /// The response body will contain an array of DbSystemSummary resources.
        /// </summary>
        public List<DbSystemSummary> Items { get; set; }
    }
}
