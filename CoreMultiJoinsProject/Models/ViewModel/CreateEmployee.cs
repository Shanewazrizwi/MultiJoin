using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMultiJoinsProject.Models.ViewModel
{
    public class CreateEmployee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public int departmentsId { get; set; }
    }
}
