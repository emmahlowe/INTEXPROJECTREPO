using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEXPROJECT.Models
{
    public class Credentials
    {
        [Key]
        public int? Credential_ID { get; set; }

        [Required(ErrorMessage = "Please enter your username")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Username must be between 5-25 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [StringLength(35, MinimumLength = 12, ErrorMessage = "Password must be between 12-35 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

