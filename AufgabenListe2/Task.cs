using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenListe2
    // oh look a useless comment!
{
    public class Task
    {
        public string Designation { get; set; }
        public DateTime DueDate { get; set; }
        public string Assignee { get; set; }
        public int DegreesDone { get; set; }

        public Task(string designation, DateTime duedate, string assignee, int degreesdone)
        {
            Designation = designation;
            DueDate = duedate;
            Assignee = assignee;
            DegreesDone = degreesdone;
        }

        public override string ToString()
        {
            return $"{Designation} - {DueDate:dd/MM/yyyy} - {Assignee} - {DegreesDone} %";
        }
    }
}
