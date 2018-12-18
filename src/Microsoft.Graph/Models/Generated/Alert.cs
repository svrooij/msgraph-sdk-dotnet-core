// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Alert.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Alert : Entity
    {
    
        /// <summary>
        /// Gets or sets activity group name.
        /// Name or alias of the activity group (attacker) this alert is attributed to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityGroupName", Required = Newtonsoft.Json.Required.Default)]
        public string ActivityGroupName { get; set; }
    
        /// <summary>
        /// Gets or sets assigned to.
        /// Name of the analyst the alert is assigned to for triage, investigation, or remediation (supports update).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedTo", Required = Newtonsoft.Json.Required.Default)]
        public string AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets azure subscription id.
        /// Azure subscription ID, present if this alert is related to an Azure resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureSubscriptionId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureSubscriptionId { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// Azure Active Directory tenant ID. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureTenantId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// Category of the alert (for example, credentialTheft, ransomware, etc.).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category", Required = Newtonsoft.Json.Required.Default)]
        public string Category { get; set; }
    
        /// <summary>
        /// Gets or sets closed date time.
        /// Time at which the alert was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z' (supports update).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "closedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ClosedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets cloud app states.
        /// Security-related stateful information generated by the provider about the cloud application/s related to this alert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cloudAppStates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<CloudAppSecurityState> CloudAppStates { get; set; }
    
        /// <summary>
        /// Gets or sets comments.
        /// Customer-provided comments on alert (for customer alert management) (supports update).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "comments", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Comments { get; set; }
    
        /// <summary>
        /// Gets or sets confidence.
        /// Confidence of the detection logic (percentage between 1-100).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "confidence", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Confidence { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Time at which the alert was created by the alert provider. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Alert description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets detection ids.
        /// Set of alerts related to this alert entity (each alert is pushed to the SIEM as a separate record).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> DetectionIds { get; set; }
    
        /// <summary>
        /// Gets or sets event date time.
        /// Time at which the event(s) that served as the trigger(s) to generate the alert occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eventDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EventDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets feedback.
        /// Analyst feedback on the alert. Possible values are: unknown, truePositive, falsePositive, benignPositive. (supports update)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "feedback", Required = Newtonsoft.Json.Required.Default)]
        public AlertFeedback? Feedback { get; set; }
    
        /// <summary>
        /// Gets or sets file states.
        /// Security-related stateful information generated by the provider about the file(s) related to this alert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileStates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<FileSecurityState> FileStates { get; set; }
    
        /// <summary>
        /// Gets or sets host states.
        /// Security-related stateful information generated by the provider about the host(s) related to this alert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hostStates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<HostSecurityState> HostStates { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Time at which the alert entity was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets malware states.
        /// Threat Intelligence pertaining to malware related to this alert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "malwareStates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MalwareState> MalwareStates { get; set; }
    
        /// <summary>
        /// Gets or sets network connections.
        /// Security-related stateful information generated by the provider about the network connection(s) related to this alert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkConnections", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<NetworkConnection> NetworkConnections { get; set; }
    
        /// <summary>
        /// Gets or sets processes.
        /// Security-related stateful information generated by the provider about the process or processes related to this alert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Process> Processes { get; set; }
    
        /// <summary>
        /// Gets or sets recommended actions.
        /// Vendor/provider recommended action(s) to take as a result of the alert (for example, isolate machine, enforce2FA, reimage host).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recommendedActions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RecommendedActions { get; set; }
    
        /// <summary>
        /// Gets or sets registry key states.
        /// Security-related stateful information generated by the provider about the registry keys related to this alert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registryKeyStates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<RegistryKeyState> RegistryKeyStates { get; set; }
    
        /// <summary>
        /// Gets or sets severity.
        /// Alert severity - set by vendor/provider. Possible values are: unknown, informational, low, medium, high. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "severity", Required = Newtonsoft.Json.Required.Default)]
        public AlertSeverity? Severity { get; set; }
    
        /// <summary>
        /// Gets or sets source materials.
        /// Hyperlinks (URIs) to the source material related to the alert, for example, provider's user interface for alerts or log search, etc.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceMaterials", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SourceMaterials { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Alert lifecycle status (stage). Possible values are: unknown, newAlert, inProgress, resolved. (supports update). Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public AlertStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// User-definable labels that can be applied to an alert and can serve as filter conditions (for example 'HVA', 'SAW', etc.) (supports update).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tags", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Alert title. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets triggers.
        /// Security-related information about the specific properties that triggered the alert (properties appearing in the alert). Alerts might contain information about multiple users, hosts, files, ip addresses. This field indicates which properties triggered the alert generation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "triggers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AlertTrigger> Triggers { get; set; }
    
        /// <summary>
        /// Gets or sets user states.
        /// Security-related stateful information generated by the provider about the user accounts related to this alert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userStates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<UserSecurityState> UserStates { get; set; }
    
        /// <summary>
        /// Gets or sets vendor information.
        /// Complex type containing details about the security product/service vendor, provider, and subprovider (for example, vendor=Microsoft; provider=Windows Defender ATP; subProvider=AppLocker). Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorInformation", Required = Newtonsoft.Json.Required.Default)]
        public SecurityVendorInformation VendorInformation { get; set; }
    
        /// <summary>
        /// Gets or sets vulnerability states.
        /// Threat intelligence pertaining to one or more vulnerabilities related to this alert.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vulnerabilityStates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<VulnerabilityState> VulnerabilityStates { get; set; }
    
    }
}

