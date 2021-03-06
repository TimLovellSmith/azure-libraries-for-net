// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Enabled configuration.
    /// </summary>
    public partial class EnabledConfig
    {
        /// <summary>
        /// Initializes a new instance of the EnabledConfig class.
        /// </summary>
        public EnabledConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnabledConfig class.
        /// </summary>
        /// <param name="enabled">True if configuration is enabled, false if it
        /// is disabled and null if configuration is not set.</param>
        public EnabledConfig(bool? enabled = default(bool?))
        {
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets true if configuration is enabled, false if it is
        /// disabled and null if configuration is not set.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

    }
}
