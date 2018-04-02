// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserInstallStateSummaryDeviceStatesCollectionRequestBuilder.
    /// </summary>
    public partial class UserInstallStateSummaryDeviceStatesCollectionRequestBuilder : BaseRequestBuilder, IUserInstallStateSummaryDeviceStatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserInstallStateSummaryDeviceStatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserInstallStateSummaryDeviceStatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserInstallStateSummaryDeviceStatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserInstallStateSummaryDeviceStatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserInstallStateSummaryDeviceStatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceInstallStateRequestBuilder"/> for the specified UserInstallStateSummaryDeviceInstallState.
        /// </summary>
        /// <param name="id">The ID for the UserInstallStateSummaryDeviceInstallState.</param>
        /// <returns>The <see cref="IDeviceInstallStateRequestBuilder"/>.</returns>
        public IDeviceInstallStateRequestBuilder this[string id]
        {
            get
            {
                return new DeviceInstallStateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
