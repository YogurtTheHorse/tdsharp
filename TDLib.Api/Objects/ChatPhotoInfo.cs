using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Contains basic information about the photo of a chat
        /// </summary>
        public partial class ChatPhotoInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatPhotoInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// A small (160x160) chat photo variant in JPEG format. The file can be downloaded only before the photo is changed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("small")]
            public File Small { get; set; }

            /// <summary>
            /// A big (640x640) chat photo variant in JPEG format. The file can be downloaded only before the photo is changed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("big")]
            public File Big { get; set; }

            /// <summary>
            /// Chat photo minithumbnail; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("minithumbnail")]
            public Minithumbnail Minithumbnail { get; set; }

            /// <summary>
            /// True, if the photo has animated variant
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("has_animation")]
            public bool HasAnimation { get; set; }
        }
    }
}