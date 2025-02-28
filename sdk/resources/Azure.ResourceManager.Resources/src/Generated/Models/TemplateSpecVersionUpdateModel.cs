// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Template Spec Version properties to be updated (only tags are currently supported). </summary>
    public partial class TemplateSpecVersionUpdateModel : AzureResourceBaseAutoGenerated
    {
        /// <summary> Initializes a new instance of TemplateSpecVersionUpdateModel. </summary>
        public TemplateSpecVersionUpdateModel()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of TemplateSpecVersionUpdateModel. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="tags"> Resource tags. </param>
        internal TemplateSpecVersionUpdateModel(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags) : base(id, name, type, systemData)
        {
            Tags = tags;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
