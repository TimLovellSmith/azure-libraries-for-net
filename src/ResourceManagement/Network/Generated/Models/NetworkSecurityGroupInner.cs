// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// NetworkSecurityGroup resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkSecurityGroupInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkSecurityGroupInner class.
        /// </summary>
        public NetworkSecurityGroupInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkSecurityGroupInner class.
        /// </summary>
        /// <param name="securityRules">A collection of security rules of the
        /// network security group.</param>
        /// <param name="defaultSecurityRules">The default security rules of
        /// network security group.</param>
        /// <param name="networkInterfaces">A collection of references to
        /// network interfaces.</param>
        /// <param name="subnets">A collection of references to
        /// subnets.</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// network security group resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// public IP resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public NetworkSecurityGroupInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<SecurityRuleInner> securityRules = default(IList<SecurityRuleInner>), IList<SecurityRuleInner> defaultSecurityRules = default(IList<SecurityRuleInner>), IList<NetworkInterfaceInner> networkInterfaces = default(IList<NetworkInterfaceInner>), IList<SubnetInner> subnets = default(IList<SubnetInner>), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            SecurityRules = securityRules;
            DefaultSecurityRules = defaultSecurityRules;
            NetworkInterfaces = networkInterfaces;
            Subnets = subnets;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of security rules of the network security
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.securityRules")]
        public IList<SecurityRuleInner> SecurityRules { get; set; }

        /// <summary>
        /// Gets or sets the default security rules of network security group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultSecurityRules")]
        public IList<SecurityRuleInner> DefaultSecurityRules { get; set; }

        /// <summary>
        /// Gets a collection of references to network interfaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkInterfaces")]
        public IList<NetworkInterfaceInner> NetworkInterfaces { get; private set; }

        /// <summary>
        /// Gets a collection of references to subnets.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnets")]
        public IList<SubnetInner> Subnets { get; private set; }

        /// <summary>
        /// Gets or sets the resource GUID property of the network security
        /// group resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the public IP resource.
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SecurityRules != null)
            {
                foreach (var element in SecurityRules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (DefaultSecurityRules != null)
            {
                foreach (var element1 in DefaultSecurityRules)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (NetworkInterfaces != null)
            {
                foreach (var element2 in NetworkInterfaces)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
