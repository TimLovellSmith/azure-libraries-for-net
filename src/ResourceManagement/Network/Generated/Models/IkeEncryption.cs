// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for IkeEncryption.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<IkeEncryption>))]
    public class IkeEncryption : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<IkeEncryption>
    {
        public static readonly IkeEncryption DES = Parse("DES");
        public static readonly IkeEncryption DES3 = Parse("DES3");
        public static readonly IkeEncryption AES128 = Parse("AES128");
        public static readonly IkeEncryption AES192 = Parse("AES192");
        public static readonly IkeEncryption AES256 = Parse("AES256");
        public static readonly IkeEncryption GCMAES256 = Parse("GCMAES256");
        public static readonly IkeEncryption GCMAES128 = Parse("GCMAES128");
    }
}
