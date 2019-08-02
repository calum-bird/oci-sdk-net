﻿using OCISDK.Core.src.Monitoring.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Monitoring.Request
{
    public class ListMetricsRequest
    {
        /// <summary>
        /// Customer part of the request identifier token. 
        /// If you need to contact Oracle about a particular request, please provide the complete request ID.
        /// <para>Required: no</para>
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// The OCID of the compartment containing the resources monitored by the metric that you are searching for. 
        /// Use tenancyId to search in the root compartment.
        /// <para>Required: yes</para>
        /// <para>Minimum: 1, Maximum: 255</para>
        /// </summary>
        public string CompartmentId { get; set; }

        /// <summary>
        /// For list pagination. The maximum number of results per page, or items to return in a paginated "List" call. 
        /// For important details about how pagination works, see List Pagination.
        /// <para>Required: no</para>
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// For list pagination. The value of the opc-next-page response header from the previous "List" call. 
        /// For important details about how pagination works, see List Pagination.
        /// <para>Required: no</para>
        /// <para>Minimum: 1, Maximum: 512</para>
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// When true, returns resources from all compartments and subcompartments. 
        /// The parameter can only be set to true when compartmentId is the tenancy OCID (the tenancy is the root compartment). 
        /// A true value requires the user to have tenancy-level permissions. 
        /// If this requirement is not met, then the call is rejected. 
        /// When false, returns resources from only the compartment specified in compartmentId. Default is false.
        /// <para>Required: no</para>
        /// </summary>
        public bool? CompartmentIdInSubtree { get; set; }

        /// <summary>
        /// The request body must contain a single ListMetricsDetails resource.
        /// </summary>
        public ListMetricsDetails Body { get; set; }

        public string GetOptionQuery()
        {
            var options = $"compartmentId={this.CompartmentId}";

            if (!string.IsNullOrEmpty(this.Page))
            {
                options += $"&page={this.Page}";
            }
            if (this.Limit.HasValue)
            {
                options += $"&limit={this.Limit.Value}";
            }
            if (CompartmentIdInSubtree.HasValue)
            {
                options += $"&compartmentIdInSubtree={this.CompartmentIdInSubtree.Value}";
            }

            return options;
        }
    }
}
