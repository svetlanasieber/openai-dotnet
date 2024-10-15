// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeRequestResponseCreateCommandResponse : IJsonModel<InternalRealtimeRequestResponseCreateCommandResponse>
    {
        void IJsonModel<InternalRealtimeRequestResponseCreateCommandResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestResponseCreateCommandResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeRequestResponseCreateCommandResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("commit") != true)
            {
                writer.WritePropertyName("commit"u8);
                writer.WriteBooleanValue(Commit);
            }
            if (SerializedAdditionalRawData?.ContainsKey("cancel_previous") != true)
            {
                writer.WritePropertyName("cancel_previous"u8);
                writer.WriteBooleanValue(CancelPrevious);
            }
            if (SerializedAdditionalRawData?.ContainsKey("append_input_items") != true && Optional.IsCollectionDefined(AppendInputItems))
            {
                writer.WritePropertyName("append_input_items"u8);
                writer.WriteStartArray();
                foreach (var item in AppendInputItems)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("input_items") != true && Optional.IsCollectionDefined(InputItems))
            {
                writer.WritePropertyName("input_items"u8);
                writer.WriteStartArray();
                foreach (var item in InputItems)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("instructions") != true && Optional.IsDefined(Instructions))
            {
                writer.WritePropertyName("instructions"u8);
                writer.WriteStringValue(Instructions);
            }
            if (SerializedAdditionalRawData?.ContainsKey("modalities") != true && Optional.IsCollectionDefined(Modalities))
            {
                writer.WritePropertyName("modalities"u8);
                writer.WriteStartArray();
                foreach (var item in Modalities)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("voice") != true && Optional.IsDefined(Voice))
            {
                writer.WritePropertyName("voice"u8);
                writer.WriteStringValue(Voice.Value.ToString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("temperature") != true && Optional.IsDefined(Temperature))
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature.Value);
            }
            if (SerializedAdditionalRawData?.ContainsKey("max_output_tokens") != true && Optional.IsDefined(MaxOutputTokens))
            {
                if (MaxOutputTokens != null)
                {
                    writer.WritePropertyName("max_output_tokens"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MaxOutputTokens);
#else
                    using (JsonDocument document = JsonDocument.Parse(MaxOutputTokens))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                else
                {
                    writer.WriteNull("max_output_tokens");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("tools") != true && Optional.IsCollectionDefined(Tools))
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (var item in Tools)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("tool_choice") != true && Optional.IsDefined(ToolChoice))
            {
                writer.WritePropertyName("tool_choice"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ToolChoice);
#else
                using (JsonDocument document = JsonDocument.Parse(ToolChoice))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (SerializedAdditionalRawData?.ContainsKey("output_audio_format") != true && Optional.IsDefined(OutputAudioFormat))
            {
                writer.WritePropertyName("output_audio_format"u8);
                writer.WriteStringValue(OutputAudioFormat.Value.ToString());
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InternalRealtimeRequestResponseCreateCommandResponse IJsonModel<InternalRealtimeRequestResponseCreateCommandResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestResponseCreateCommandResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeRequestResponseCreateCommandResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeRequestResponseCreateCommandResponse(document.RootElement, options);
        }

        internal static InternalRealtimeRequestResponseCreateCommandResponse DeserializeInternalRealtimeRequestResponseCreateCommandResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool commit = default;
            bool cancelPrevious = default;
            IList<ConversationItem> appendInputItems = default;
            IList<ConversationItem> inputItems = default;
            string instructions = default;
            IList<InternalRealtimeRequestSessionUpdateCommandSessionModality> modalities = default;
            ConversationVoice? voice = default;
            float? temperature = default;
            BinaryData maxOutputTokens = default;
            IList<ConversationTool> tools = default;
            BinaryData toolChoice = default;
            ConversationAudioFormat? outputAudioFormat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commit"u8))
                {
                    commit = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cancel_previous"u8))
                {
                    cancelPrevious = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("append_input_items"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConversationItem> array = new List<ConversationItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConversationItem.DeserializeConversationItem(item, options));
                    }
                    appendInputItems = array;
                    continue;
                }
                if (property.NameEquals("input_items"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConversationItem> array = new List<ConversationItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConversationItem.DeserializeConversationItem(item, options));
                    }
                    inputItems = array;
                    continue;
                }
                if (property.NameEquals("instructions"u8))
                {
                    instructions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modalities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InternalRealtimeRequestSessionUpdateCommandSessionModality> array = new List<InternalRealtimeRequestSessionUpdateCommandSessionModality>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new InternalRealtimeRequestSessionUpdateCommandSessionModality(item.GetString()));
                    }
                    modalities = array;
                    continue;
                }
                if (property.NameEquals("voice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    voice = new ConversationVoice(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    temperature = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("max_output_tokens"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxOutputTokens = null;
                        continue;
                    }
                    maxOutputTokens = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConversationTool> array = new List<ConversationTool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConversationTool.DeserializeConversationTool(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (property.NameEquals("tool_choice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    toolChoice = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("output_audio_format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputAudioFormat = new ConversationAudioFormat(property.Value.GetString());
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalRealtimeRequestResponseCreateCommandResponse(
                commit,
                cancelPrevious,
                appendInputItems ?? new ChangeTrackingList<ConversationItem>(),
                inputItems ?? new ChangeTrackingList<ConversationItem>(),
                instructions,
                modalities ?? new ChangeTrackingList<InternalRealtimeRequestSessionUpdateCommandSessionModality>(),
                voice,
                temperature,
                maxOutputTokens,
                tools ?? new ChangeTrackingList<ConversationTool>(),
                toolChoice,
                outputAudioFormat,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalRealtimeRequestResponseCreateCommandResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestResponseCreateCommandResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeRequestResponseCreateCommandResponse)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeRequestResponseCreateCommandResponse IPersistableModel<InternalRealtimeRequestResponseCreateCommandResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestResponseCreateCommandResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalRealtimeRequestResponseCreateCommandResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeRequestResponseCreateCommandResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeRequestResponseCreateCommandResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalRealtimeRequestResponseCreateCommandResponse FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRealtimeRequestResponseCreateCommandResponse(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}