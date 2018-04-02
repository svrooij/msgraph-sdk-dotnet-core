// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagedAndroidStoreAppRequest.
    /// </summary>
    public partial interface IManagedAndroidStoreAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedAndroidStoreApp using PUT.
        /// </summary>
        /// <param name="managedAndroidStoreAppToCreate">The ManagedAndroidStoreApp to create.</param>
        /// <returns>The created ManagedAndroidStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedAndroidStoreApp> CreateAsync(ManagedAndroidStoreApp managedAndroidStoreAppToCreate);        /// <summary>
        /// Creates the specified ManagedAndroidStoreApp using PUT.
        /// </summary>
        /// <param name="managedAndroidStoreAppToCreate">The ManagedAndroidStoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAndroidStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedAndroidStoreApp> CreateAsync(ManagedAndroidStoreApp managedAndroidStoreAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedAndroidStoreApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedAndroidStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedAndroidStoreApp.
        /// </summary>
        /// <returns>The ManagedAndroidStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedAndroidStoreApp> GetAsync();

        /// <summary>
        /// Gets the specified ManagedAndroidStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAndroidStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedAndroidStoreApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedAndroidStoreApp using PATCH.
        /// </summary>
        /// <param name="managedAndroidStoreAppToUpdate">The ManagedAndroidStoreApp to update.</param>
        /// <returns>The updated ManagedAndroidStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedAndroidStoreApp> UpdateAsync(ManagedAndroidStoreApp managedAndroidStoreAppToUpdate);

        /// <summary>
        /// Updates the specified ManagedAndroidStoreApp using PATCH.
        /// </summary>
        /// <param name="managedAndroidStoreAppToUpdate">The ManagedAndroidStoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ManagedAndroidStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedAndroidStoreApp> UpdateAsync(ManagedAndroidStoreApp managedAndroidStoreAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAndroidStoreAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAndroidStoreAppRequest Expand(Expression<Func<ManagedAndroidStoreApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAndroidStoreAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAndroidStoreAppRequest Select(Expression<Func<ManagedAndroidStoreApp, object>> selectExpression);

    }
}
