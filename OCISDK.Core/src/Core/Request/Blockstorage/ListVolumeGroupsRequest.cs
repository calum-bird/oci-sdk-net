﻿using OCISDK.Core.src.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OCISDK.Core.src.Core.Request.Blockstorage
{
    public class ListVolumeGroupsRequest
    {
        /// <summary>
        /// The name of the availability domain.
        /// <para>Required: yes</para>
        /// </summary>
        public string AvailabilityDomain { get; set; }

        /// <summary>
        /// The OCID of the compartment.
        /// <para>Required: yes</para>
        /// <para>Minimum: 1, Maximum: 255</para>
        /// </summary>
        public string CompartmentId { get; set; }

        /// <summary>
        /// <para>Required: no</para>
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// <para>Required: no</para>
        /// <para>Minimum: 1, Maximum: 512</para>
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// A filter to return only resources that match the given display name exactly.
        /// <para>Required: no</para>
        /// <para>Min Length: 1, Max Length: 255</para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The field to sort by. You can provide one sort order (sortOrder). 
        /// Default order for TIMECREATED is descending. Default order for DISPLAYNAME is ascending. 
        /// The DISPLAYNAME sort order is case sensitive.
        /// <para>Required: no</para>
        /// </summary>
        public SortByParam? SortBy { get; set; }

        public enum SortByParam
        {
            [DisplayName("TIMECREATED")]
            TIMECREATED,
            [DisplayName("DISPLAYNAME")]
            DISPLAYNAME
        }

        /// <summary>
        /// The sort order to use, either ascending (ASC) or descending (DESC). 
        /// The DISPLAYNAME sort order is case sensitive.
        /// <para>Required: no</para>
        /// </summary>
        public SortOrder? SortOrder { get; set; }

        /// <summary>
        /// A filter to only return resources that match the given lifecycle state. 
        /// The state value is case-insensitive.
        /// </summary>
        public string LifecycleState { get; set; }

        public string GetOptionQuery()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"availabilityDomain={this.AvailabilityDomain}");

            sb.Append($"&compartmentId={this.CompartmentId}");
            
            if (!String.IsNullOrEmpty(this.DisplayName))
            {
                sb.Append($"&displayName={this.DisplayName}");
            }
            if (this.SortBy.HasValue)
            {
                sb.Append($"&sortBy={EnumAttribute.GetDisplayName(this.SortBy.Value)}");
            }

            if (this.SortOrder.HasValue)
            {
                sb.Append($"&sortOrder={EnumAttribute.GetDisplayName(this.SortOrder.Value)}");
            }

            if (this.Limit.HasValue)
            {
                sb.Append($"&limit={this.Limit.Value}");
            }
            if (!String.IsNullOrEmpty(this.Page))
            {
                sb.Append($"&page={this.Page}");
            }
            if (!String.IsNullOrEmpty(this.LifecycleState))
            {
                sb.Append($"&lifecycleState={this.LifecycleState}");
            }

            return sb.ToString();
        }
    }
}
