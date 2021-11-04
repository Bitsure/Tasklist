using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class TaskModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "Sorry, your topic is too long.")]
        public string Topic { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Today;

        public bool Finished { get; set; }
    }
}
