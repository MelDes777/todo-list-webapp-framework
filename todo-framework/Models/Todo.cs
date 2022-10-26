using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todo_framework.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public ApplicationUser User { get; set; }
    }
}