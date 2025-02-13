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
        /// Recovers the 2-step verification password using a recovery code sent to an email address that was previously set up
        /// </summary>
        public class RecoverPassword : Function<PasswordState>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "recoverPassword";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Recovery code to check
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("recovery_code")]
            public string RecoveryCode { get; set; }

            /// <summary>
            /// New password of the user; may be empty to remove the password
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("new_password")]
            public string NewPassword { get; set; }

            /// <summary>
            /// New password hint; may be empty
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("new_hint")]
            public string NewHint { get; set; }
        }

        /// <summary>
        /// Recovers the 2-step verification password using a recovery code sent to an email address that was previously set up
        /// </summary>
        public static Task<PasswordState> RecoverPasswordAsync(
            this Client client, string recoveryCode = default, string newPassword = default, string newHint = default)
        {
            return client.ExecuteAsync(new RecoverPassword
            {
                RecoveryCode = recoveryCode, NewPassword = newPassword, NewHint = newHint
            });
        }
    }
}