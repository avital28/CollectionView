using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToObject.Models
{
    public class Student
    {
        public string Name { get; set; }    
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }
        public double Age { get => (DateTime.Now - BirthDate).TotalDays / 365; }


    }
}
