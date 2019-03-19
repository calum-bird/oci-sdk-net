﻿/// <summary>
/// GetTagNamespace Request
/// 
/// author: koutaro furusawa
/// </summary>

namespace OCISDK.Core.src.Identity.Request
{
    public class GetTagNamespaceRequest
    {
        /// <summary>
        /// The OCID of the tag namespace.
        /// <para>Required: yes</para>
        /// <para>Minimum: 1, Maximum: 100</para>
        /// </summary>
        public string TagNamespaceId { get; set; }
    }
}
