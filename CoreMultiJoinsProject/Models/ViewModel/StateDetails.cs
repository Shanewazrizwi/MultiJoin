using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMultiJoinsProject.Models.ViewModel
{
    public class StateDetails
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}
