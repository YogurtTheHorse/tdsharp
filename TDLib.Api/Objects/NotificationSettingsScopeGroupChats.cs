using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class NotificationSettingsScope : Object
        {
            /// <summary>
            /// Notification settings applied to all basic groups and supergroups when the corresponding chat setting has a default value
            /// </summary>
            public class NotificationSettingsScopeGroupChats : NotificationSettingsScope
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "notificationSettingsScopeGroupChats";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}