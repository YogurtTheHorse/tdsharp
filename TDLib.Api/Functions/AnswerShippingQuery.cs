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
        /// Sets the result of a shipping query; for bots only
        /// </summary>
        public class AnswerShippingQuery : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "answerShippingQuery";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the shipping query
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("shipping_query_id")]
            public long ShippingQueryId { get; set; }

            /// <summary>
            /// Available shipping options
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("shipping_options")]
            public ShippingOption[] ShippingOptions { get; set; }

            /// <summary>
            /// An error message, empty on success
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("error_message")]
            public string ErrorMessage { get; set; }
        }

        /// <summary>
        /// Sets the result of a shipping query; for bots only
        /// </summary>
        public static Task<Ok> AnswerShippingQueryAsync(
            this Client client, long shippingQueryId = default, ShippingOption[] shippingOptions = default, string errorMessage = default)
        {
            return client.ExecuteAsync(new AnswerShippingQuery
            {
                ShippingQueryId = shippingQueryId, ShippingOptions = shippingOptions, ErrorMessage = errorMessage
            });
        }
    }
}