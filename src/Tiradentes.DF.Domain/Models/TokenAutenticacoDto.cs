using System.Collections.Generic;

namespace VipSgs.Domain.Models
{
    public class TokenAutenticacoDto
    {
        public TokenAutenticacoDto()
        {
        }
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string refresh_token { get; set; }
        public string username { get; set; }
        public string created_on { get; set; }
        public string expires_on { get; set; }
    }
}
