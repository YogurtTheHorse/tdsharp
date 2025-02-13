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
        /// Returns an invoice payment form. This method must be called when the user presses inlineKeyboardButtonBuy
        /// </summary>
        public class GetPaymentForm : Function<PaymentForm>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getPaymentForm";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier of the Invoice message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Message identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// Preferred payment form theme; pass null to use the default theme
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("theme")]
            public PaymentFormTheme Theme { get; set; }
        }

        /// <summary>
        /// Returns an invoice payment form. This method must be called when the user presses inlineKeyboardButtonBuy
        /// </summary>
        public static Task<PaymentForm> GetPaymentFormAsync(
            this Client client, long chatId = default, long messageId = default, PaymentFormTheme theme = default)
        {
            return client.ExecuteAsync(new GetPaymentForm
            {
                ChatId = chatId, MessageId = messageId, Theme = theme
            });
        }
    }
}