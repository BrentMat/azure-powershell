// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229
{
    using Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.PowerShell;

    /// <summary>Class representing an Event Grid data connection.</summary>
    [System.ComponentModel.TypeConverter(typeof(EventGridDataConnectionTypeConverter))]
    public partial class EventGridDataConnection
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.EventGridDataConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnection" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnection DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EventGridDataConnection(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.EventGridDataConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnection" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnection DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EventGridDataConnection(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.EventGridDataConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EventGridDataConnection(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridConnectionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.EventGridConnectionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind.CreateFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseRouting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).DatabaseRouting = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting?) content.GetValueForProperty("DatabaseRouting",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).DatabaseRouting, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("StorageAccountResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).StorageAccountResourceId = (string) content.GetValueForProperty("StorageAccountResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).StorageAccountResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("EventGridResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).EventGridResourceId = (string) content.GetValueForProperty("EventGridResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).EventGridResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("EventHubResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).EventHubResourceId = (string) content.GetValueForProperty("EventHubResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).EventHubResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumerGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ConsumerGroup = (string) content.GetValueForProperty("ConsumerGroup",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ConsumerGroup, global::System.Convert.ToString);
            }
            if (content.Contains("TableName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).TableName = (string) content.GetValueForProperty("TableName",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).TableName, global::System.Convert.ToString);
            }
            if (content.Contains("MappingRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).MappingRuleName = (string) content.GetValueForProperty("MappingRuleName",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).MappingRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("DataFormat"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).DataFormat = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat?) content.GetValueForProperty("DataFormat",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).DataFormat, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat.CreateFrom);
            }
            if (content.Contains("IgnoreFirstRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).IgnoreFirstRecord = (bool?) content.GetValueForProperty("IgnoreFirstRecord",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).IgnoreFirstRecord, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("BlobStorageEventType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).BlobStorageEventType = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType?) content.GetValueForProperty("BlobStorageEventType",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).BlobStorageEventType, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType.CreateFrom);
            }
            if (content.Contains("ManagedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ManagedIdentityResourceId = (string) content.GetValueForProperty("ManagedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ManagedIdentityResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedIdentityObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ManagedIdentityObjectId = (string) content.GetValueForProperty("ManagedIdentityObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ManagedIdentityObjectId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.EventGridDataConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EventGridDataConnection(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridConnectionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.EventGridConnectionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind.CreateFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IDataConnectionInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseRouting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).DatabaseRouting = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting?) content.GetValueForProperty("DatabaseRouting",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).DatabaseRouting, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("StorageAccountResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).StorageAccountResourceId = (string) content.GetValueForProperty("StorageAccountResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).StorageAccountResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("EventGridResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).EventGridResourceId = (string) content.GetValueForProperty("EventGridResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).EventGridResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("EventHubResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).EventHubResourceId = (string) content.GetValueForProperty("EventHubResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).EventHubResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ConsumerGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ConsumerGroup = (string) content.GetValueForProperty("ConsumerGroup",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ConsumerGroup, global::System.Convert.ToString);
            }
            if (content.Contains("TableName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).TableName = (string) content.GetValueForProperty("TableName",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).TableName, global::System.Convert.ToString);
            }
            if (content.Contains("MappingRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).MappingRuleName = (string) content.GetValueForProperty("MappingRuleName",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).MappingRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("DataFormat"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).DataFormat = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat?) content.GetValueForProperty("DataFormat",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).DataFormat, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat.CreateFrom);
            }
            if (content.Contains("IgnoreFirstRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).IgnoreFirstRecord = (bool?) content.GetValueForProperty("IgnoreFirstRecord",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).IgnoreFirstRecord, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("BlobStorageEventType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).BlobStorageEventType = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType?) content.GetValueForProperty("BlobStorageEventType",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).BlobStorageEventType, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType.CreateFrom);
            }
            if (content.Contains("ManagedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ManagedIdentityResourceId = (string) content.GetValueForProperty("ManagedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ManagedIdentityResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedIdentityObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ManagedIdentityObjectId = (string) content.GetValueForProperty("ManagedIdentityObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnectionInternal)this).ManagedIdentityObjectId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EventGridDataConnection" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EventGridDataConnection" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IEventGridDataConnection FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Class representing an Event Grid data connection.
    [System.ComponentModel.TypeConverter(typeof(EventGridDataConnectionTypeConverter))]
    public partial interface IEventGridDataConnection

    {

    }
}