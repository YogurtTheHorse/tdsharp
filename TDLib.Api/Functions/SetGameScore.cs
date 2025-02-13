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
        /// Updates the game score of the specified user in the game; for bots only
        /// </summary>
        public class SetGameScore : Function<Message>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setGameScore";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The chat to which the message with the game belongs
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
            /// True, if the message needs to be edited
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("edit_message")]
            public bool EditMessage { get; set; }

            /// <summary>
            /// User identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public long UserId { get; set; }

            /// <summary>
            /// The new score
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("score")]
            public int Score { get; set; }

            /// <summary>
            /// Pass true to update the score even if it decreases. If the score is 0, the user will be deleted from the high score table
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("force")]
            public bool Force { get; set; }
        }

        /// <summary>
        /// Updates the game score of the specified user in the game; for bots only
        /// </summary>
        public static Task<Message> SetGameScoreAsync(
            this Client client, long chatId = default, long messageId = default, bool editMessage = default, long userId = default, int score = default, bool force = default)
        {
            return client.ExecuteAsync(new SetGameScore
            {
                ChatId = chatId, MessageId = messageId, EditMessage = editMessage, UserId = userId, Score = score, Force = force
            });
        }
    }
}