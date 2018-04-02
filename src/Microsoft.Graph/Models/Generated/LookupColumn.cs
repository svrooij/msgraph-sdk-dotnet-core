// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type LookupColumn.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class LookupColumn
    {
    
        /// <summary>
        /// Gets or sets allowMultipleValues.
        /// Indicates whether multiple values can be selected from the source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowMultipleValues", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowMultipleValues { get; set; }
    
        /// <summary>
        /// Gets or sets allowUnlimitedLength.
        /// Indicates whether values in the column should be able to exceed the standard limit of 255 characters.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowUnlimitedLength", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowUnlimitedLength { get; set; }
    
        /// <summary>
        /// Gets or sets columnName.
        /// The name of the lookup source column.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "columnName", Required = Newtonsoft.Json.Required.Default)]
        public string ColumnName { get; set; }
    
        /// <summary>
        /// Gets or sets listId.
        /// The unique identifier of the lookup source list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "listId", Required = Newtonsoft.Json.Required.Default)]
        public string ListId { get; set; }
    
        /// <summary>
        /// Gets or sets primaryLookupColumnId.
        /// If specified, this column is a secondary lookup, pulling an additional field from the list item looked up by the primary lookup. Use the list item looked up by the primary as the source for the column named here.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "primaryLookupColumnId", Required = Newtonsoft.Json.Required.Default)]
        public string PrimaryLookupColumnId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
