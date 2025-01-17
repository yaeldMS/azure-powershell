// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for NatGatewaysOperations
    /// </summary>
    public static partial class NatGatewaysOperationsExtensions
    {
        /// <summary>
        /// Deletes the specified nat gateway.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        public static void Delete(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName)
        {
                ((INatGatewaysOperations)operations).DeleteAsync(resourceGroupName, natGatewayName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the specified nat gateway.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, natGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Gets the specified nat gateway in a specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        /// <param name='expand'>
        /// Expands referenced resources.
        /// </param>
        public static NatGateway Get(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName, string expand = default(string))
        {
                return ((INatGatewaysOperations)operations).GetAsync(resourceGroupName, natGatewayName, expand).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the specified nat gateway in a specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        /// <param name='expand'>
        /// Expands referenced resources.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<NatGateway> GetAsync(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, natGatewayName, expand, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates or updates a nat gateway.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        public static NatGateway CreateOrUpdate(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName, NatGateway parameters)
        {
                return ((INatGatewaysOperations)operations).CreateOrUpdateAsync(resourceGroupName, natGatewayName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates a nat gateway.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<NatGateway> CreateOrUpdateAsync(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName, NatGateway parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, natGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Updates nat gateway tags.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        public static NatGateway UpdateTags(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName, TagsObject parameters)
        {
                return ((INatGatewaysOperations)operations).UpdateTagsAsync(resourceGroupName, natGatewayName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates nat gateway tags.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<NatGateway> UpdateTagsAsync(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName, TagsObject parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, natGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all the Nat Gateways in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<NatGateway> ListAll(this INatGatewaysOperations operations)
        {
                return ((INatGatewaysOperations)operations).ListAllAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all the Nat Gateways in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NatGateway>> ListAllAsync(this INatGatewaysOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all nat gateways in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<NatGateway> List(this INatGatewaysOperations operations, string resourceGroupName)
        {
                return ((INatGatewaysOperations)operations).ListAsync(resourceGroupName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all nat gateways in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NatGateway>> ListAsync(this INatGatewaysOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes the specified nat gateway.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        public static void BeginDelete(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName)
        {
                ((INatGatewaysOperations)operations).BeginDeleteAsync(resourceGroupName, natGatewayName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the specified nat gateway.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginDeleteAsync(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, natGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Creates or updates a nat gateway.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        public static NatGateway BeginCreateOrUpdate(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName, NatGateway parameters)
        {
                return ((INatGatewaysOperations)operations).BeginCreateOrUpdateAsync(resourceGroupName, natGatewayName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates a nat gateway.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='natGatewayName'>
        /// The name of the nat gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<NatGateway> BeginCreateOrUpdateAsync(this INatGatewaysOperations operations, string resourceGroupName, string natGatewayName, NatGateway parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, natGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all the Nat Gateways in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<NatGateway> ListAllNext(this INatGatewaysOperations operations, string nextPageLink)
        {
                return ((INatGatewaysOperations)operations).ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all the Nat Gateways in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NatGateway>> ListAllNextAsync(this INatGatewaysOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all nat gateways in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<NatGateway> ListNext(this INatGatewaysOperations operations, string nextPageLink)
        {
                return ((INatGatewaysOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all nat gateways in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NatGateway>> ListNextAsync(this INatGatewaysOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
