using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Student
{
    public interface IStudentRepository
    {
        //public Domain.Entities.Student getID(int id);

        List<Domain.Entities.StudentViewModel> ListStudent();

        public Domain.Entities.Student create(Domain.Entities.Student student);

        public Domain.Entities.Student showedit(int id);

        public Domain.Entities.Student edit(Domain.Entities.Student student);

        public Domain.Entities.Student delete(int id);
    }
}
