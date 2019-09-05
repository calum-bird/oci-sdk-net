﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Core.Request.Compute
{
    public class GetConsoleHistoryRequest
    {
        /// <summary>
        /// The OCID of the console history.
        /// <para>Required: yes</para>
        /// </summary>
        public string InstanceConsoleHistoryId { get; set; }
    }
}
