using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMultiJoinsProject.Models.ViewModel
{
    public class CreateCities
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public int statesId { get; set; }
    }
}
