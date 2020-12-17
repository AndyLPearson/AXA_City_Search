using System;
using System.Collections.Generic;
using System.Text;

namespace AXA_Code_Test.Repository
{
    public class CityRepository : ICityRepository
    {
        public ICollection<string> GetCities()
        {
            ICollection<string> countries = new List<string>
            { 
                "BANDUNG", 
                "BANGUI", 
                "BANGKOK", 
                "BANGALORE",
                "LA PAZ", 
                "LA PLATA", 
                "LAGOS", 
                "LEEDS",
                "ZARIA", 
                "ZHUGHAI", 
                "ZIBO" 
            };
            return countries;
        }
    }
}
