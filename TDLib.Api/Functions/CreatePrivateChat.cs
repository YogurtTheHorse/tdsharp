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
        /// Returns an existing chat corresponding to a given user
        /// </summary>
        public class CreatePrivateChat : Function<Chat>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "createPrivateChat";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// User identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public long UserId { get; set; }

            /// <summary>
            /// If true, the chat will be created without network request. In this case all information about the chat except its type, title and photo can be incorrect
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("force")]
            public bool Force { get; set; }
        }

        /// <summary>
        /// Returns an existing chat corresponding to a given user
        /// </summary>
        public static Task<Chat> CreatePrivateChatAsync(
            this Client client, long userId = default, bool force = default)
        {
            return client.ExecuteAsync(new CreatePrivateChat
            {
                UserId = userId, Force = force
            });
        }
    }
}