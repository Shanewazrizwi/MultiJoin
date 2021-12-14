using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMultiJoinsProject.Models
{
    public class Cities
    {
        [Key]
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }

        public States states { get; set; }
    }
}
