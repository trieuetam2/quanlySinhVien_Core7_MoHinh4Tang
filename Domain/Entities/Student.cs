using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Foreign key for classId
        public int ClassId { get; set; }
        public Class Class { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, int classId)
        {
            Id = id;   
            Name = name;
            ClassId = classId;
        }
    }
}
