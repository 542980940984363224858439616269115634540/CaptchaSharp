using Newtonsoft.Json;

namespace CaptchaSharp.Services.BestCaptchaSolver.Responses;

internal class BcsTaskCreatedResponse : BcsResponse
{
    [JsonProperty("id")]
    public long Id { get; set; }
}
