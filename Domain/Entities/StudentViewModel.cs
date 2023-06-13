using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public String classID { get; set; }
        public StudentViewModel()
        {

        }
        public StudentViewModel(int iD, string name, String ClassID)
        {
            ID = iD;
            Name = name;
            classID = ClassID;
        }
    }
}
