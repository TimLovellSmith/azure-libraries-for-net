// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request parameters for updating an existing application.
    /// </summary>
    public partial class ApplicationUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationUpdateParameters
        /// class.
        /// </summary>
        public ApplicationUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationUpdateParameters
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="availableToOtherTenants">Whether the application is
        /// available to other tenants</param>
        /// <param name="displayName">The display name of the
        /// application.</param>
        /// <param name="homepage">The home page of the application.</param>
        /// <param name="identifierUris">A collection of URIs for the
        /// application.</param>
        /// <param name="replyUrls">A collection of reply URLs for the
        /// application.</param>
        /// <param name="keyCredentials">The list of KeyCredential
        /// objects.</param>
        /// <param name="passwordCredentials">The list of PasswordCredential
        /// objects.</param>
        /// <param name="oauth2AllowImplicitFlow">Whether to allow implicit
        /// grant flow for OAuth2</param>
        /// <param name="requiredResourceAccess">Specifies resources that this
        /// application requires access to and the set of OAuth permission
        /// scopes and application roles that it needs under each of those
        /// resources. This pre-configuration of required resource access
        /// drives the consent experience.</param>
        public ApplicationUpdateParameters(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), bool? availableToOtherTenants = default(bool?), string displayName = default(string), string homepage = default(string), IList<string> identifierUris = default(IList<string>), IList<string> replyUrls = default(IList<string>), IList<KeyCredential> keyCredentials = default(IList<KeyCredential>), IList<PasswordCredential> passwordCredentials = default(IList<PasswordCredential>), bool? oauth2AllowImplicitFlow = default(bool?), IList<RequiredResourceAccess> requiredResourceAccess = default(IList<RequiredResourceAccess>))
        {
            AdditionalProperties = additionalProperties;
            AvailableToOtherTenants = availableToOtherTenants;
            DisplayName = displayName;
            Homepage = homepage;
            IdentifierUris = identifierUris;
            ReplyUrls = replyUrls;
            KeyCredentials = keyCredentials;
            PasswordCredentials = passwordCredentials;
            Oauth2AllowImplicitFlow = oauth2AllowImplicitFlow;
            RequiredResourceAccess = requiredResourceAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets whether the application is available to other tenants
        /// </summary>
        [JsonProperty(PropertyName = "availableToOtherTenants")]
        public bool? AvailableToOtherTenants { get; set; }

        /// <summary>
        /// Gets or sets the display name of the application.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the home page of the application.
        /// </summary>
        [JsonProperty(PropertyName = "homepage")]
        public string Homepage { get; set; }

        /// <summary>
        /// Gets or sets a collection of URIs for the application.
        /// </summary>
        [JsonProperty(PropertyName = "identifierUris")]
        public IList<string> IdentifierUris { get; set; }

        /// <summary>
        /// Gets or sets a collection of reply URLs for the application.
        /// </summary>
        [JsonProperty(PropertyName = "replyUrls")]
        public IList<string> ReplyUrls { get; set; }

        /// <summary>
        /// Gets or sets the list of KeyCredential objects.
        /// </summary>
        [JsonProperty(PropertyName = "keyCredentials")]
        public IList<KeyCredential> KeyCredentials { get; set; }

        /// <summary>
        /// Gets or sets the list of PasswordCredential objects.
        /// </summary>
        [JsonProperty(PropertyName = "passwordCredentials")]
        public IList<PasswordCredential> PasswordCredentials { get; set; }

        /// <summary>
        /// Gets or sets whether to allow implicit grant flow for OAuth2
        /// </summary>
        [JsonProperty(PropertyName = "oauth2AllowImplicitFlow")]
        public bool? Oauth2AllowImplicitFlow { get; set; }

        /// <summary>
        /// Gets or sets specifies resources that this application requires
        /// access to and the set of OAuth permission scopes and application
        /// roles that it needs under each of those resources. This
        /// pre-configuration of required resource access drives the consent
        /// experience.
        /// </summary>
        [JsonProperty(PropertyName = "requiredResourceAccess")]
        public IList<RequiredResourceAccess> RequiredResourceAccess { get; set; }

    }
}
