using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        
    }
}
