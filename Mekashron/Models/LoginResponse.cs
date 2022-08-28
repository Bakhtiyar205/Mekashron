using Newtonsoft.Json;

namespace Mekashron.Models
{
    public class LoginResponse : BaseResponse
    {
        [JsonProperty("EntityId")]
        public long EntityId { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("Company")]
        public string Company { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("Zip")]
        public string Zip { get; set; }

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("Mobile")]
        public string Mobile { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("EmailConfirm")]
        public long EmailConfirm { get; set; }

        [JsonProperty("MobileConfirm")]
        public long MobileConfirm { get; set; }

        [JsonProperty("CountryID")]
        public long CountryId { get; set; }

        [JsonProperty("Status")]
        public long Status { get; set; }

        [JsonProperty("lid")]
        public string Lid { get; set; }

        [JsonProperty("FTPHost")]
        public string FtpHost { get; set; }
    }
}