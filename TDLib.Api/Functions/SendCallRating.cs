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
        /// Sends a call rating
        /// </summary>
        public class SendCallRating : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendCallRating";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Call identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("call_id")]
            public int CallId { get; set; }

            /// <summary>
            /// Call rating; 1-5
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("rating")]
            public int Rating { get; set; }

            /// <summary>
            /// An optional user comment if the rating is less than 5
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("comment")]
            public string Comment { get; set; }

            /// <summary>
            /// List of the exact types of problems with the call, specified by the user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("problems")]
            public CallProblem[] Problems { get; set; }
        }

        /// <summary>
        /// Sends a call rating
        /// </summary>
        public static Task<Ok> SendCallRatingAsync(
            this Client client, int callId = default, int rating = default, string comment = default, CallProblem[] problems = default)
        {
            return client.ExecuteAsync(new SendCallRating
            {
                CallId = callId, Rating = rating, Comment = comment, Problems = problems
            });
        }
    }
}