// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Resources.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Export Template specific properties of the Stack.
    /// </summary>
    public partial class DeploymentStackTemplateDefinition
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentStackTemplateDefinition
        /// class.
        /// </summary>
        public DeploymentStackTemplateDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentStackTemplateDefinition
        /// class.
        /// </summary>
        /// <param name="template">The template content. Use this element to
        /// pass the template syntax directly in the request rather than link
        /// to an existing template. It can be a JObject or well-formed JSON
        /// string. Use either the templateLink property or the template
        /// property, but not both.</param>
        /// <param name="templateLink">The URI of the template. Use either the
        /// templateLink property or the template property, but not
        /// both.</param>
        public DeploymentStackTemplateDefinition(object template = default(object), DeploymentStacksTemplateLink templateLink = default(DeploymentStacksTemplateLink))
        {
            Template = template;
            TemplateLink = templateLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the template content. Use this element to pass the
        /// template syntax directly in the request rather than link to an
        /// existing template. It can be a JObject or well-formed JSON string.
        /// Use either the templateLink property or the template property, but
        /// not both.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public object Template { get; set; }

        /// <summary>
        /// Gets or sets the URI of the template. Use either the templateLink
        /// property or the template property, but not both.
        /// </summary>
        [JsonProperty(PropertyName = "templateLink")]
        public DeploymentStacksTemplateLink TemplateLink { get; set; }

    }
}
