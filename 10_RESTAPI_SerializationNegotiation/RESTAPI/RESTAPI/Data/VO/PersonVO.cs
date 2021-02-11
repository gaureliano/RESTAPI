using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RESTAPI.Data.VO
{

    public class PersonVO 
    {
        [JsonPropertyName("code")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string FirstName { get; set;  }

        [JsonPropertyName("sobrenome")]
        public string LastName { get; set; }

        [JsonPropertyName("local")]
        public string Address { get; set; }

        [JsonPropertyName("gen")]
        public string Gender { get; set; }

    }
}
