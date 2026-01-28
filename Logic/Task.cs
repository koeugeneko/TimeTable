using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.Logic
{
    internal class Task
    {
        public string taskName { get; set; }
        public string taskSubject { get; set; }
        public Task(string taskName, string taskSubject)
        {
            this.taskName = taskName;
            this.taskSubject = taskSubject;
        }
    }
}
