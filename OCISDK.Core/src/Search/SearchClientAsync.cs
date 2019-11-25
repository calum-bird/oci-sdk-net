﻿using OCISDK.Core.src.Common;
using OCISDK.Core.src.Search.Model;
using OCISDK.Core.src.Search.Request;
using OCISDK.Core.src.Search.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OCISDK.Core.src.Search
{
    /// <summary>
    /// SearchClientAsync
    /// </summary>
    public class SearchClientAsync : ServiceClient, ISearchClientAsync
    {
        private readonly string SearchServiceName = "search";

        /// <summary>
        /// Constructer
        /// </summary>
        public SearchClientAsync(ClientConfig config) : base(config)
        {
            ServiceName = SearchServiceName;
        }

        /// <summary>
        /// Constructer
        /// </summary>
        public SearchClientAsync(ClientConfig config, OciSigner ociSigner) : base(config, ociSigner)
        {
            ServiceName = SearchServiceName;
        }

        /// <summary>
        /// Constructer
        /// </summary>
        public SearchClientAsync(ClientConfigStream config) : base(config)
        {
            ServiceName = SearchServiceName;
        }

        /// <summary>
        /// Constructer
        /// </summary>
        public SearchClientAsync(ClientConfigStream config, OciSigner ociSigner) : base(config, ociSigner)
        {
            ServiceName = SearchServiceName;
        }

        /// <summary>
        /// Queries any and all compartments in the tenancy to find resources that match the specified criteria.
        /// Results include resources that you have permission to view and can span different resource types.
        /// You can also sort results based on a specified resource attribute.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SearchResourcesResponse> SearchResources(SearchResourcesRequest request)
        {
            var uri = new Uri(GetEndPoint(SearchServices.RESOURCES, this.Region));

            var webResponse = await this.RestClientAsync.Post(uri, request.SearchDetails, new HttpRequestHeaderParam() { OpcRequestId = request.OpcRequestId });

            using (var stream = webResponse.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                var response = reader.ReadToEnd();

                return new SearchResourcesResponse()
                {
                    ResourceSummaryCollection = JsonSerializer.Deserialize<ResourceSummaryCollection>(response),
                    OpcNextPage = webResponse.Headers.Get("opc-next-page"),
                    OpcRequestId = webResponse.Headers.Get("opc-request-id")
                };
            }
        }
    }
}
