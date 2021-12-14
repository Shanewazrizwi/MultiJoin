using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMultiJoinsProject.Models.ViewModel
{
    public class CreateState
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public int countriesId { get; set; }
    }
}
