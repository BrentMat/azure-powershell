// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>Represents the correlation filter expression.</summary>
    public partial class CorrelationFilter
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject into a new instance of <see cref="CorrelationFilter" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CorrelationFilter(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_property = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject>("properties"), out var __jsonProperties) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.CorrelationFilterProperties.FromJson(__jsonProperties) : Property;}
            {_correlationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString>("correlationId"), out var __jsonCorrelationId) ? (string)__jsonCorrelationId : (string)CorrelationId;}
            {_messageId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString>("messageId"), out var __jsonMessageId) ? (string)__jsonMessageId : (string)MessageId;}
            {_to = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString>("to"), out var __jsonTo) ? (string)__jsonTo : (string)To;}
            {_replyTo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString>("replyTo"), out var __jsonReplyTo) ? (string)__jsonReplyTo : (string)ReplyTo;}
            {_label = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString>("label"), out var __jsonLabel) ? (string)__jsonLabel : (string)Label;}
            {_sessionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString>("sessionId"), out var __jsonSessionId) ? (string)__jsonSessionId : (string)SessionId;}
            {_replyToSessionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString>("replyToSessionId"), out var __jsonReplyToSessionId) ? (string)__jsonReplyToSessionId : (string)ReplyToSessionId;}
            {_contentType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString>("contentType"), out var __jsonContentType) ? (string)__jsonContentType : (string)ContentType;}
            {_requiresPreprocessing = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonBoolean>("requiresPreprocessing"), out var __jsonRequiresPreprocessing) ? (bool?)__jsonRequiresPreprocessing : RequiresPreprocessing;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilter.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilter.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilter FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject json ? new CorrelationFilter(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CorrelationFilter" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CorrelationFilter" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._property ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode) this._property.ToJson(null,serializationMode) : null, "properties" ,container.Add );
            AddIf( null != (((object)this._correlationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString(this._correlationId.ToString()) : null, "correlationId" ,container.Add );
            AddIf( null != (((object)this._messageId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString(this._messageId.ToString()) : null, "messageId" ,container.Add );
            AddIf( null != (((object)this._to)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString(this._to.ToString()) : null, "to" ,container.Add );
            AddIf( null != (((object)this._replyTo)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString(this._replyTo.ToString()) : null, "replyTo" ,container.Add );
            AddIf( null != (((object)this._label)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString(this._label.ToString()) : null, "label" ,container.Add );
            AddIf( null != (((object)this._sessionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString(this._sessionId.ToString()) : null, "sessionId" ,container.Add );
            AddIf( null != (((object)this._replyToSessionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString(this._replyToSessionId.ToString()) : null, "replyToSessionId" ,container.Add );
            AddIf( null != (((object)this._contentType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonString(this._contentType.ToString()) : null, "contentType" ,container.Add );
            AddIf( null != this._requiresPreprocessing ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonBoolean((bool)this._requiresPreprocessing) : null, "requiresPreprocessing" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}