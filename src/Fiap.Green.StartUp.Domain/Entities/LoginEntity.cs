using Newtonsoft.Json;

namespace Fiap.Green.StartUp.Domain.Entities
{
    [JsonObject("login")]
    public class LoginEntity
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        
        [JsonProperty("ativo")]
        public string Ativo { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}