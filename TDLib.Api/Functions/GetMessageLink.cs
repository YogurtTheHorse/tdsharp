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
        /// Returns an HTTPS link to a message in a chat. Available only for already sent messages in supergroups and channels, or if message.can_get_media_timestamp_links and a media timestamp link is generated. This is an offline request
        /// </summary>
        public class GetMessageLink : Function<MessageLink>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getMessageLink";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to which the message belongs
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// If not 0, timestamp from which the video/audio/video note/voice note playing must start, in seconds. The media can be in the message content or in its web page preview
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("media_timestamp")]
            public int MediaTimestamp { get; set; }

            /// <summary>
            /// Pass true to create a link for the whole media album
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("for_album")]
            public bool ForAlbum { get; set; }

            /// <summary>
            /// Pass true to create a link to the message as a channel post comment, or from a message thread
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("for_comment")]
            public bool ForComment { get; set; }
        }

        /// <summary>
        /// Returns an HTTPS link to a message in a chat. Available only for already sent messages in supergroups and channels, or if message.can_get_media_timestamp_links and a media timestamp link is generated. This is an offline request
        /// </summary>
        public static Task<MessageLink> GetMessageLinkAsync(
            this Client client, long chatId = default, long messageId = default, int mediaTimestamp = default, bool forAlbum = default, bool forComment = default)
        {
            return client.ExecuteAsync(new GetMessageLink
            {
                ChatId = chatId, MessageId = messageId, MediaTimestamp = mediaTimestamp, ForAlbum = forAlbum, ForComment = forComment
            });
        }
    }
}