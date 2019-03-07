using OldApp.Models.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OldApp.Models.Adapter
{
    public class StudentRepo : IStudentRepo
    {
        BazaDanychContext context;
        public StudentRepo(BazaDanychContext context)
        {
            this.context = context;
        }
        public void Add(StudentDTO student)
        {
            Student oldItem = new Student
            {
                Id = student.Id,
                Nazwisko = student.LastName,
                Imie = student.Name
            };
            context.Studenci.Add(oldItem);
        }
           
        public void Delete(int id)
        {
            var oldStudent = context.Studenci.FirstOrDefault(a => a.Id == id);
            context.Studenci.Remove(oldStudent);
        }
    }
}
