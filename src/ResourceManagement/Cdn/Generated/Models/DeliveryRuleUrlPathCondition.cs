// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the URL path condition for the delivery rule.
    /// </summary>
    [Newtonsoft.Json.JsonObject("UrlPath")]
    public partial class DeliveryRuleUrlPathCondition : DeliveryRuleCondition
    {
        /// <summary>
        /// Initializes a new instance of the DeliveryRuleUrlPathCondition
        /// class.
        /// </summary>
        public DeliveryRuleUrlPathCondition()
        {
            Parameters = new UrlPathConditionParameters();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeliveryRuleUrlPathCondition
        /// class.
        /// </summary>
        /// <param name="parameters">Defines the parameters for the
        /// condition.</param>
        public DeliveryRuleUrlPathCondition(UrlPathConditionParameters parameters)
        {
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets defines the parameters for the condition.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public UrlPathConditionParameters Parameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Parameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Parameters");
            }
            if (Parameters != null)
            {
                Parameters.Validate();
            }
        }
    }
}