using Newtonsoft.Json;
using System.Collections.Generic;

namespace PremierUIAutomation
{

    public interface IPremier<T>
    {
        [JsonProperty("Positive tests1")]
        List<T> PositiveTests { get; set; }
        [JsonProperty("Negative tests1")]
        List<T> NegativeTests { get; set; }
    }

    public partial class LoginTestCollection : IPremier<LoginTestData>
    {
        [JsonProperty("Positive tests")]
        public List<LoginTestData> PositiveTests { get; set; }
        [JsonProperty("Negative tests")]
        public List<LoginTestData> NegativeTests { get; set; }
    }

    public partial class LoginTestData
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}
