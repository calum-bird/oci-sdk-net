﻿/// <summary>
/// UpdateDhcpDetails Reference
/// 
/// author: koutaro furusawa
/// </summary>

using Newtonsoft.Json;
using System.Collections.Generic;

namespace OCISDK.Core.src.Core.Model.VirtualNetwork
{
    public class UpdateDhcpDetails
    {
        /// <summary>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <para>Required: no</para>
        /// <para>Minimum: 1, Maximum: 255</para>
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Required: no</para>
        /// </summary>
        [JsonProperty("options")]
        public List<DhcpOption> Options { get; set; }

        /// <summary>
        /// Free-form tags for this resource.
        /// Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see Resource Tags.
        /// <para>Required: no</para>
        /// </summary>
        [JsonProperty("freeformTags")]
        public IDictionary<string, string> FreeformTags { get; set; }

        /// <summary>
        /// Defined tags for this resource.
        /// Each key is predefined and scoped to a namespace.
        /// For more information, see Resource Tags.
        /// <para>Required: no</para>
        /// </summary>
        [JsonProperty("definedTags")]
        public IDictionary<string, IDictionary<string, string>> DefinedTags { get; set; }
    }
}
