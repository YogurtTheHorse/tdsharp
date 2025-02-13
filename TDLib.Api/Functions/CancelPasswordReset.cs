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
        /// Cancels reset of 2-step verification password. The method can be called if passwordState.pending_reset_date > 0
        /// </summary>
        public class CancelPasswordReset : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "cancelPasswordReset";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Cancels reset of 2-step verification password. The method can be called if passwordState.pending_reset_date > 0
        /// </summary>
        public static Task<Ok> CancelPasswordResetAsync(
            this Client client)
        {
            return client.ExecuteAsync(new CancelPasswordReset
            {
                
            });
        }
    }
}