using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Student
{

    public class StudentRepository : IStudentRepository
    {
        private readonly AppDBContext _dbContext;
        public StudentRepository(AppDBContext dbContext) { 
            this._dbContext = dbContext;
        }

        public List<Domain.Entities.StudentViewModel> ListStudent()
        {
            try
            {
                var list = (from student in _dbContext.Students 
                            join clasTalbe in _dbContext.Classs
                            on student.ClassId equals clasTalbe.Id
                            select new StudentViewModel()
                            {
                                ID = student.Id,
                                Name = student.Name,
                                classID = clasTalbe.NameClass
                            }).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi khi lay danh sach Student" + ex);
            }
        }


        public Domain.Entities.Student create(Domain.Entities.Student student)
        {
            var list = new Domain.Entities.Student
            {
                Id = student.Id,
                Name = student.Name,
                ClassId = student.ClassId
            };

            _dbContext.Students.Add(list);
            _dbContext.SaveChanges();
            return list;
        }

        public Domain.Entities.Student delete(int id)
        {
            var item = _dbContext.Students.Find(id);
            _dbContext.Students.Remove(item);
            _dbContext.SaveChanges();
            return item;
        }

        public Domain.Entities.Student showedit(int id)
        {
            return _dbContext.Students.Where(x => x.Id == id).FirstOrDefault();
        }


        public Domain.Entities.Student edit(Domain.Entities.Student student)
        {
            var list = new Domain.Entities.Student
            {
                Id = student.Id,
                Name = student.Name,
                ClassId = student.ClassId
            };

            _dbContext.Students.Update(list);
            _dbContext.SaveChanges();
            return list;
        }

        //public Domain.Entities.Student getID(int id)
        //{
        //    try
        //    {
        //        return _dbContext.Students.Where(x => x.Id == id).FirstOrDefault();
        //    }
        //    catch(Exception ex){
        //        throw new Exception("Loi khi lay id" + ex);
        //    }
        //}




    }
}
