using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseAccessLibrary
{
    public class TaskData
    {
        public int UserId { get; set; }
        public int taskId { get;}
        public string Topic { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Finished { get; set; }
    }
}
