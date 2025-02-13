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
        /// Adds a new sticker to a set; for bots only. Returns the sticker set
        /// </summary>
        public class AddStickerToSet : Function<StickerSet>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addStickerToSet";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Sticker set owner
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public long UserId { get; set; }

            /// <summary>
            /// Sticker set name
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Sticker to add to the set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public InputSticker Sticker { get; set; }
        }

        /// <summary>
        /// Adds a new sticker to a set; for bots only. Returns the sticker set
        /// </summary>
        public static Task<StickerSet> AddStickerToSetAsync(
            this Client client, long userId = default, string name = default, InputSticker sticker = default)
        {
            return client.ExecuteAsync(new AddStickerToSet
            {
                UserId = userId, Name = name, Sticker = sticker
            });
        }
    }
}