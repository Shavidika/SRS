using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace POS.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string RegNom { get; set; }

        public string Email { get; set; }

        public double Gpa { get; set; }

        
    }
}
