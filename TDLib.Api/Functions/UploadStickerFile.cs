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
        /// Uploads a file with a sticker; returns the uploaded file
        /// </summary>
        public class UploadStickerFile : Function<File>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "uploadStickerFile";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Sticker file owner; ignored for regular users
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public long UserId { get; set; }

            /// <summary>
            /// Sticker file to upload
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public InputSticker Sticker { get; set; }
        }

        /// <summary>
        /// Uploads a file with a sticker; returns the uploaded file
        /// </summary>
        public static Task<File> UploadStickerFileAsync(
            this Client client, long userId = default, InputSticker sticker = default)
        {
            return client.ExecuteAsync(new UploadStickerFile
            {
                UserId = userId, Sticker = sticker
            });
        }
    }
}