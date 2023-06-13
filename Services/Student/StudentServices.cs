using Repository.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Student
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository studentRepository;

        public StudentServices(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        //public Domain.Entities.Student getStudents(int id)
        //{
        //    return studentRepository.getID(id);
        //}

        public List<Domain.Entities.StudentViewModel> getList()
        {
            return studentRepository.ListStudent();
        }

        public Domain.Entities.Student createList(Domain.Entities.Student student)
        {
            return studentRepository.create(student);
        }

        public Domain.Entities.Student editList(Domain.Entities.Student student)
        {
            return studentRepository.edit(student);
        }

        public Domain.Entities.Student showEdit(int id)
        {
            return studentRepository.showedit(id);
        }

        public Domain.Entities.Student deleteList(int id)
        {
            return studentRepository.delete(id);
        }
    }
}
