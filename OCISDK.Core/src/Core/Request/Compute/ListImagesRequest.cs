﻿/// <summary>
/// ListImagesRequest class
/// 
/// author: koutaro furusawa
/// </summary>

using OCISDK.Core.src.Common;
using System;
using System.ComponentModel;
using System.Text;

namespace OCISDK.Core.src.Core.Request.Compute
{
    public class ListImagesRequest
    {
        /// <summary>
        /// <para>Required: yes</para>
        /// <para>Minimum: 1, Maximum: 255</para>
        /// </summary>
        public string CompartmentId { get; set; }

        /// <summary>
        /// <para>Required: no</para>
        /// <para>Minimum: 1, Maximum: 255</para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The image's operating system. 
        /// Example: Oracle Linux
        /// <para>Required: no</para>
        /// </summary>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// The image's operating system version.
        /// Example: 7.2
        /// <para>Required: no</para>
        /// </summary>
        public string OperatingSystemVersion { get; set; }

        /// <summary>
        /// Shape name.
        /// <para>Required: no</para>
        /// </summary>
        public string Shape { get; set; }

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
        /// <para>Required: no</para>
        /// <para>Allowed values are:
        /// TIMECREATED
        /// , DISPLAYNAME</para>
        /// </summary>
        public SortByParam SortBy { get; set; }

        /// <summary>
        /// SortBy ExpandableEnum
        /// </summary>
        public class SortByParam : ExpandableEnum<SortByParam>
        {
            public SortByParam(string value) : base(value) { }

            public static implicit operator SortByParam(string value)
            {
                return Parse(value);
            }
            
            public static readonly SortByParam TIMECREATED = new SortByParam("TIMECREATED");

            public static readonly SortByParam DISPLAYNAME = new SortByParam("DISPLAYNAME");
        }

        /// <summary>
        /// <para>Required: no</para>
        /// <para>Allowed values are:
        /// ASC
        /// , DESC</para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// <para>Required: no</para>
        /// </summary>
        public LifecycleStates LifecycleState { get; set; }

        /// <summary>
        /// LifecycleState ExpandableEnum
        /// </summary>
        public class LifecycleStates : ExpandableEnum<LifecycleStates>
        {
            public LifecycleStates(string value) : base(value) { }

            public static implicit operator LifecycleStates(string value)
            {
                return Parse(value);
            }

            public static readonly LifecycleStates PROVISIONING = new LifecycleStates("PROVISIONING");

            public static readonly LifecycleStates IMPORTING = new LifecycleStates("IMPORTING");

            public static readonly LifecycleStates AVAILABLE = new LifecycleStates("AVAILABLE");

            public static readonly LifecycleStates EXPORTING = new LifecycleStates("EXPORTING");

            public static readonly LifecycleStates DISABLED = new LifecycleStates("DISABLED");

            public static readonly LifecycleStates DELETED = new LifecycleStates("DELETED");
        }

        public string GetOptionQuery()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"compartmentId={this.CompartmentId}");

            if (!String.IsNullOrEmpty(this.OperatingSystem))
            {
                sb.Append($"&operatingSystem={this.OperatingSystem}");
            }
            if (!String.IsNullOrEmpty(this.OperatingSystemVersion))
            {
                sb.Append($"&operatingSystemVersion={this.OperatingSystemVersion}");
            }
            if (!String.IsNullOrEmpty(this.Shape))
            {
                sb.Append($"&shape={this.Shape}");
            }
            if (!String.IsNullOrEmpty(this.DisplayName))
            {
                sb.Append($"&displayName={this.DisplayName}");
            }
            if (!(LifecycleState is null))
            {
                sb.Append($"&lifecycleState={LifecycleState.Value}");
            }
            if (this.Limit.HasValue)
            {
                sb.Append($"&limit={this.Limit.Value}");
            }
            if (!String.IsNullOrEmpty(this.Page))
            {
                sb.Append($"&page={this.Page}");
            }
            if (!(SortBy is null))
            {
                sb.Append($"&sortBy={SortBy.Value}");
            }
            if (!(SortOrder is null))
            {
                sb.Append($"&sortOrder={SortOrder.Value}");
            }

            return sb.ToString();
        }
    }
}
