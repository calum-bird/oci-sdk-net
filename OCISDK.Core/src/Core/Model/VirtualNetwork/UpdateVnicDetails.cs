﻿/// <summary>
/// UpdateVnicDetails Reference
/// 
/// author: koutaro furusawa
/// </summary>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace OCISDK.Core.src.Core.Model.VirtualNetwork
{
    public class UpdateVnicDetails
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
        /// The hostname for the VNIC's primary private IP. 
        /// Used for DNS. The value is the hostname portion of the primary private IP's 
        /// fully qualified domain name (FQDN) 
        /// (for example, bminstance-1 in FQDN bminstance-1.subnet123.vcn1.oraclevcn.com). 
        /// Must be unique across all VNICs in the subnet and comply with RFC 952 and RFC 1123. 
        /// The value appears in the Vnic object and also the PrivateIp object returned by ListPrivateIps 
        /// and GetPrivateIp.
        /// <para>Min Length: 1</para>
        /// <para>Max Length: 63</para>
        /// </summary>
        [JsonProperty("hostnameLabel")]
        public string HostnameLabel { get; set; }

        /// <summary>
        /// Whether the source/destination check is disabled on the VNIC. 
        /// Defaults to false, which means the check is performed. For information about why you 
        /// would skip the source/destination check, see Using a Private IP as a Route Target.
        /// </summary>
        [JsonProperty("skipSourceDestCheck")]
        public bool SkipSourceDestCheck { get; set; }

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
