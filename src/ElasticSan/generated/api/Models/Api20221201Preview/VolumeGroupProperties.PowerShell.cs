// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.PowerShell;

    /// <summary>VolumeGroup response properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(VolumeGroupPropertiesTypeConverter))]
    public partial class VolumeGroupProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.VolumeGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VolumeGroupProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.VolumeGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VolumeGroupProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VolumeGroupProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VolumeGroupProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.VolumeGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VolumeGroupProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NetworkAcls"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).NetworkAcls = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.INetworkRuleSet) content.GetValueForProperty("NetworkAcls",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).NetworkAcls, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.NetworkRuleSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.ProvisioningStates?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.ProvisioningStates.CreateFrom);
            }
            if (content.Contains("ProtocolType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).ProtocolType = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.StorageTargetType?) content.GetValueForProperty("ProtocolType",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).ProtocolType, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.StorageTargetType.CreateFrom);
            }
            if (content.Contains("Encryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).Encryption = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.EncryptionType?) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).Encryption, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.EncryptionType.CreateFrom);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IPrivateEndpointConnection[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkAclsVirtualNetworkRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).NetworkAclsVirtualNetworkRule = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVirtualNetworkRule[]) content.GetValueForProperty("NetworkAclsVirtualNetworkRule",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).NetworkAclsVirtualNetworkRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVirtualNetworkRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.VirtualNetworkRuleTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.VolumeGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VolumeGroupProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NetworkAcls"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).NetworkAcls = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.INetworkRuleSet) content.GetValueForProperty("NetworkAcls",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).NetworkAcls, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.NetworkRuleSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.ProvisioningStates?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.ProvisioningStates.CreateFrom);
            }
            if (content.Contains("ProtocolType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).ProtocolType = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.StorageTargetType?) content.GetValueForProperty("ProtocolType",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).ProtocolType, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.StorageTargetType.CreateFrom);
            }
            if (content.Contains("Encryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).Encryption = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.EncryptionType?) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).Encryption, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.EncryptionType.CreateFrom);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IPrivateEndpointConnection[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkAclsVirtualNetworkRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).NetworkAclsVirtualNetworkRule = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVirtualNetworkRule[]) content.GetValueForProperty("NetworkAclsVirtualNetworkRule",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVolumeGroupPropertiesInternal)this).NetworkAclsVirtualNetworkRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.IVirtualNetworkRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20221201Preview.VirtualNetworkRuleTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// VolumeGroup response properties.
    [System.ComponentModel.TypeConverter(typeof(VolumeGroupPropertiesTypeConverter))]
    public partial interface IVolumeGroupProperties

    {

    }
}