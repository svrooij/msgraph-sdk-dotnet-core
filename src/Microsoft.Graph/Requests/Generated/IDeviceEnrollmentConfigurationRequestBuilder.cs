// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDeviceEnrollmentConfigurationRequestBuilder.
    /// </summary>
    public partial interface IDeviceEnrollmentConfigurationRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceEnrollmentConfigurationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceEnrollmentConfigurationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        IDeviceEnrollmentConfigurationAssignmentsCollectionRequestBuilder Assignments { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceEnrollmentConfigurationSetPriority.
        /// </summary>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationSetPriorityRequestBuilder"/>.</returns>
        IDeviceEnrollmentConfigurationSetPriorityRequestBuilder SetPriority(
            Int32 priority);

        /// <summary>
        /// Gets the request builder for DeviceEnrollmentConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationAssignRequestBuilder"/>.</returns>
        IDeviceEnrollmentConfigurationAssignRequestBuilder Assign(
            IEnumerable<EnrollmentConfigurationAssignment> enrollmentConfigurationAssignments = null);
    
    }
}
