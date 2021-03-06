// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> SKU of a public IP prefix. </summary>
    public partial class PublicIPPrefixSku
    {
        /// <summary> Initializes a new instance of PublicIPPrefixSku. </summary>
        public PublicIPPrefixSku()
        {
        }

        /// <summary> Initializes a new instance of PublicIPPrefixSku. </summary>
        /// <param name="name"> Name of a public IP prefix SKU. </param>
        internal PublicIPPrefixSku(PublicIPPrefixSkuName? name)
        {
            Name = name;
        }

        /// <summary> Name of a public IP prefix SKU. </summary>
        public PublicIPPrefixSkuName? Name { get; set; }
    }
}
