﻿using OCISDK.Core.src.Core.Model.Blockstorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.Core.Response.Blockstorage
{
    public class UpdateVolumeGroupBackupResponse
    {
        /// <summary>
        /// For optimistic concurrency control. See if-match.
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// The response body will contain a single VolumeGroupBackup resource.
        /// </summary>
        public VolumeGroupBackup VolumeGroupBackup { get; set; }
    }
}