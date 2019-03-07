using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OldApp.Models
{
    public  class BazaDanychContext
    {
        public  List<Student> Studenci = new List<Student>
        {
            new Student
            {
                Id=1,
                Imie= "Jan",
                Nazwisko="Kowalski"
            },
            new Student
            {
                Id=2,
                Imie= "Jan",
                Nazwisko="Kowalski"
            },
            new Student
            {
                Id=3,
                Imie= "Mar",
                Nazwisko="Kowalski"
            }
        };
    }

    
}
        
        


