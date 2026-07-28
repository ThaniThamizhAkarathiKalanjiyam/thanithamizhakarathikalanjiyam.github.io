using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace TTAK_BLZRV2.Core.Models
{
    public class AppUser : BaseModel
    {
        [Required]
        [JsonProperty("UserName")]
        public string UserName { get; set; }
        [Required]
        [JsonProperty("PassWord")]
        public string PassWord { get; set; }
        
    }


}
