using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OldApp.Models.Target
{
    public interface IStudentRepo
    {
        void Add(StudentDTO student);
        void Delete(int id);
    }
           
}
