﻿/// <summary>
/// ListBootVolumeAttachmentsRequest class
/// 
/// author: koutaro furusawa
/// </summary>

using System;
using System.Text;

namespace OCISDK.Core.src.Core.Request.Compute
{
    public class ListBootVolumeAttachmentsRequest
    {
        /// <summary>
        /// The name of the availability domain.
        /// Example: Uocm:PHX-AD-1
        /// <para>Required: no</para>
        /// </summary>
        public string AvailabilityDomain { get; set; }

        /// <summary>
        /// <para>Required: yes</para>
        /// <para>Minimum: 1, Maximum: 255</para>
        /// </summary>
        public string CompartmentId { get; set; }

        /// <summary>
        /// The OCID of the instance.
        /// <para>Required: no</para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// The OCID of the boot volume.
        /// <para>Required: no</para>
        /// </summary>
        public string BootVolumeId { get; set; }

        /// <summary>
        /// <para>Required: no</para>
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// <para>Required: no</para>
        /// <para>Minimum: 1, Maximum: 512</para>
        /// </summary>
        public string Page { get; set; }

        public string GetOptionQuery()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"compartmentId={this.CompartmentId}");
            
            sb.Append($"&availabilityDomain={this.AvailabilityDomain}");
            
            if (!String.IsNullOrEmpty(this.InstanceId))
            {
                sb.Append($"&instanceId={this.InstanceId}");
            }
            if (!String.IsNullOrEmpty(this.BootVolumeId))
            {
                sb.Append($"&bootVolumeId={this.BootVolumeId}");
            }
            if (this.Limit.HasValue)
            {
                sb.Append($"&limit={this.Limit.Value}");
            }
            if (!String.IsNullOrEmpty(this.Page))
            {
                sb.Append($"&page={this.Page}");
            }

            return sb.ToString();
        }
    }
}
