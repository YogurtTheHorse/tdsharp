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
        /// Deletes messages
        /// </summary>
        public class DeleteMessages : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deleteMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifiers of the messages to be deleted
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_ids")]
            public long[] MessageIds { get; set; }

            /// <summary>
            /// Pass true to delete messages for all chat members. Always true for supergroups, channels and secret chats
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("revoke")]
            public bool Revoke { get; set; }
        }

        /// <summary>
        /// Deletes messages
        /// </summary>
        public static Task<Ok> DeleteMessagesAsync(
            this Client client, long chatId = default, long[] messageIds = default, bool revoke = default)
        {
            return client.ExecuteAsync(new DeleteMessages
            {
                ChatId = chatId, MessageIds = messageIds, Revoke = revoke
            });
        }
    }
}