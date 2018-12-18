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
    /// The type AppCatalogsTeamsAppsCollectionRequestBuilder.
    /// </summary>
    public partial class AppCatalogsTeamsAppsCollectionRequestBuilder : BaseRequestBuilder, IAppCatalogsTeamsAppsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AppCatalogsTeamsAppsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AppCatalogsTeamsAppsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAppCatalogsTeamsAppsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAppCatalogsTeamsAppsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AppCatalogsTeamsAppsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITeamsAppRequestBuilder"/> for the specified AppCatalogsTeamsApp.
        /// </summary>
        /// <param name="id">The ID for the AppCatalogsTeamsApp.</param>
        /// <returns>The <see cref="ITeamsAppRequestBuilder"/>.</returns>
        public ITeamsAppRequestBuilder this[string id]
        {
            get
            {
                return new TeamsAppRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
