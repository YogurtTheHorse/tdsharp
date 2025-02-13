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
        /// Changes the background selected by the user; adds background to the list of installed backgrounds
        /// </summary>
        public class SetBackground : Function<Background>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setBackground";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The input background to use; pass null to create a new filled backgrounds or to remove the current background
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("background")]
            public InputBackground Background { get; set; }

            /// <summary>
            /// Background type; pass null to use the default type of the remote background or to remove the current background
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public BackgroundType Type { get; set; }

            /// <summary>
            /// True, if the background is chosen for dark theme
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("for_dark_theme")]
            public bool ForDarkTheme { get; set; }
        }

        /// <summary>
        /// Changes the background selected by the user; adds background to the list of installed backgrounds
        /// </summary>
        public static Task<Background> SetBackgroundAsync(
            this Client client, InputBackground background = default, BackgroundType type = default, bool forDarkTheme = default)
        {
            return client.ExecuteAsync(new SetBackground
            {
                Background = background, Type = type, ForDarkTheme = forDarkTheme
            });
        }
    }
}