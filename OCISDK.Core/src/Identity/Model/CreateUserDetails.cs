﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Identity.Model
{
    /// <summary>
    /// CreateUserDetails Reference
    /// </summary>
    public class CreateUserDetails
    {
        /// <summary>
        /// The OCID of the tenancy containing the user.
        /// <para>Required: yes</para>
        /// </summary>
        public string CompartmentId { get; set; }

        /// <summary>
        /// The name you assign to the user during creation. 
        /// This is the user's login for the Console. 
        /// The name must be unique across all users in the tenancy and cannot be changed.
        /// <para>Required: yes</para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description you assign to the user. Does not have to be unique, and it's changeable.
        /// <para>Required: yes</para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The email address you assign to the user. The email address must be unique across all users in the tenancy.
        /// <para>Required: no</para>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. 
        /// For more information, see Resource Tags.
        /// <para>Required: no</para>
        /// </summary>
        public IDictionary<string, string> FreeformTags { get; set; }

        /// <summary>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. 
        /// For more information, see Resource Tags.
        /// <para>Required: no</para>
        /// </summary>
        public IDictionary<string, IDictionary<string, string>> DefinedTags { get; set; }
    }
}
