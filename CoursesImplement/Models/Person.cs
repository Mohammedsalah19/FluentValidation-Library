using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesImplement.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public ChildPerson child1 { get; set; }
    }


    public class ChildPerson
    {
         public string job { get; set; }
   
    }



}
