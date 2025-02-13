using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Pins a message in a chat; requires can_pin_messages rights or can_edit_messages rights in the channel
        /// </summary>
        public class PinChatMessage : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "pinChatMessage";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the new pinned message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// True, if there must be no notification about the pinned message. Notifications are always disabled in channels and private chats
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("disable_notification")]
            public bool DisableNotification { get; set; }

            /// <summary>
            /// True, if the message needs to be pinned for one side only; private chats only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("only_for_self")]
            public bool OnlyForSelf { get; set; }
        }

        /// <summary>
        /// Pins a message in a chat; requires can_pin_messages rights or can_edit_messages rights in the channel
        /// </summary>
        public static Task<Ok> PinChatMessageAsync(
            this Client client, long chatId = default, long messageId = default, bool disableNotification = default, bool onlyForSelf = default)
        {
            return client.ExecuteAsync(new PinChatMessage
            {
                ChatId = chatId, MessageId = messageId, DisableNotification = disableNotification, OnlyForSelf = onlyForSelf
            });
        }
    }
}