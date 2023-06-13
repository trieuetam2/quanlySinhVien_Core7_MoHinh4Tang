using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string NameClass { get; set; }

        public ICollection<Student> Students { get; set; }

        public Class(int id, string nameClass) {
            Id = id;
            NameClass = nameClass;
        }
    }
}
