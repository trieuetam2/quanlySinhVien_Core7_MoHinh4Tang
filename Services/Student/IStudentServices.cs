using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Student
{
   public interface IStudentServices
    {
        //public Domain.Entities.Student getStudents(int id);
        public List<Domain.Entities.StudentViewModel> getList();
        public Domain.Entities.Student createList(Domain.Entities.Student student);
        public Domain.Entities.Student showEdit(int id);
        public Domain.Entities.Student editList(Domain.Entities.Student student);
        public Domain.Entities.Student deleteList(int id);
    }
}
