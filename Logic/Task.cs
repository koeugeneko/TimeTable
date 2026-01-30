using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.Logic
{
    internal class Task
    {
        string name { get; set; }
        string subject { get; set; }
        int prioirty { get; set; }
        DateOnly dueDate { get; set; }

        Task()
        { 
        }

    }
}
