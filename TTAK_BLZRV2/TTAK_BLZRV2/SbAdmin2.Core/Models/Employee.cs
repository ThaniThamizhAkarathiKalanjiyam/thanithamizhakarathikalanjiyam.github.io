using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TTAK_BLZRV2.Core.Models
{
    public class Employee : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        [Required]
        public int GenderId { get; set; }

    }
}
