﻿/// <summary>
/// AttachBootVolumeDetails Reference
/// 
/// author: koutaro furusawa
/// </summary>
using Newtonsoft.Json;

namespace OCISDK.Core.src.Core.Model.Compute
{
    public class AttachBootVolumeDetails
    {
        /// <summary>
        /// <para>Required: yes</para>
        /// <para>Minimum: 1, Maximum: 255</para>
        /// </summary>
        [JsonProperty("bootVolumeId")]
        public string BootVolumeId { get; set; }

        /// <summary>
        /// <para>Required: yes</para>
        /// <para>Minimum: 1, Maximum: 255</para>
        /// </summary>
        [JsonProperty("instanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// A user-friendly name. Does not have to be unique, and it cannot be changed. 
        /// Avoid entering confidential information.
        /// <para>Required: no</para>
        /// <para>Minimum: 1, Maximum: 255</para>
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}
