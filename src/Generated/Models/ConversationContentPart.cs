// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public abstract partial class ConversationContentPart
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        protected ConversationContentPart()
        {
        }

        internal ConversationContentPart(ConversationContentPartKind type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
