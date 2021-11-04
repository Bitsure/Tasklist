using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Please enter valid username.")]
        [MinLength(3, ErrorMessage = "Please enter valid username.")]
        public string Username { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please enter valid password.")]
        [MinLength(3, ErrorMessage = "Please enter valid password.")]
        public string Password { get; set; }
    }
}
