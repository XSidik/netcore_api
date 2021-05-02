using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Models
{
    public partial class Employee
    {
        [Key]
        public int Idx { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
