﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OCISDK.Core.src.Common
{
    public interface IRestClientAsync
    {
        Task<WebResponse> Get(HttpWebRequest request);
        Task<WebResponse> Get(Uri targetUri, string opcRequestId = "");
        Task<WebResponse> GetIfMatch(Uri targetUri, string opcClientRequestId = "");
        Task<WebResponse> GetIfMatch(Uri targetUri, string ifMatch = "", string ifNoneMatch = "", string opcClientRequestId = "", List<string> fields = null, string range = "");
        Task<WebResponse> Post(Uri targetUri, Object requestBody = null, string opcRetryToken = "");
        Task<WebResponse> Put(Uri targetUri, Object requestBody = null, string ifMatch = "", string opcRetryToken = "");
        Task<WebResponse> Delete(Uri targetUri, string ifMatch = "", Object requestBody = null);
    }
}
