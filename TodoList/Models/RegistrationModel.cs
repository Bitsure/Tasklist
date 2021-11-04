using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class RegistrationModel
    {
        [Required]
        [StringLength(50, ErrorMessage ="Username is too long.")]
        [MinLength(3, ErrorMessage ="Username is too short.")]
        public string Username { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Password is too long.")]
        [MinLength(6, ErrorMessage = "Password is too short.")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
