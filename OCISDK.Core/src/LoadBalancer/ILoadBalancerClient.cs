﻿using OCISDK.Core.src.LoadBalancer.Request;
using OCISDK.Core.src.LoadBalancer.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.src.LoadBalancer
{
    /// <summary>
    /// LoadBalancer Client interface
    /// </summary>
    public interface ILoadBalancerClient
    {
        /// <summary>
        /// Lists all load balancers in the specified compartment.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ListLoadBalancersResponse ListLoadBalancers(ListLoadBalancersRequest request);

        /// <summary>
        /// Lists the summary health statuses for all load balancers in the specified compartment.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ListLoadBalancerHealthsResponse ListLoadBalancerHealths(ListLoadBalancerHealthsRequest request);

        /// <summary>
        /// Lists the available load balancer policies.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ListPoliciesResponse ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Lists all supported traffic protocols.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ListProtocolsResponse ListProtocols(ListProtocolsRequest request);

        /// <summary>
        /// Gets the health status for the specified load balancer.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ListShapesResponse ListShapes(ListShapesRequest request);

        /// <summary>
        /// Gets the specified load balancer's configuration information.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetLoadBalancerResponse GetLoadBalancer(GetLoadBalancerRequest request);

        /// <summary>
        /// Gets the health status for the specified load balancer.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetLoadBalancerHealthResponse GetLoadBalancerHealth(GetLoadBalancerHealthRequest request);

        /// <summary>
        /// Creates a new load balancer in the specified compartment. 
        /// For general information about load balancers, see Overview of the Load Balancing Service.
        /// 
        /// For the purposes of access control, you must provide the OCID of the compartment where you want 
        /// the load balancer to reside. Notice that the load balancer doesn't have to be in the same compartment 
        /// as the VCN or backend set. If you're not sure which compartment to use, put the load balancer in 
        /// the same compartment as the VCN. 
        /// For information about access control and compartments, see Overview of the IAM Service.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request);

        /// <summary>
        /// Updates a load balancer's configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateLoadBalancerResponse UpdateLoadBalancer(UpdateLoadBalancerRequest request);

        /// <summary>
        /// Moves a load balancer into a different compartment within the same tenancy.
        /// For information about moving resources between compartments, see Moving Resources to a Different Compartment.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ChangeLoadBalancerCompartmentResponse ChangeLoadBalancerCompartment(ChangeLoadBalancerCompartmentRequest request);

        /// <summary>
        /// Stops a load balancer and removes it from service.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request);
    }
}
