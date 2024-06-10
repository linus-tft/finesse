using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finesse.Common.Models
{
    public class TaskDetails
    {
        public int TaskId { get; set; }
        public string TaskDescription { get; set; } = string.Empty;
        public string TaskName { get; set; } = string.Empty;
        public string TaskStatus { get; set; }= string.Empty;
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set;}
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }

    }
}
