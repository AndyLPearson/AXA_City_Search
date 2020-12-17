using System;
using System.Collections.Generic;
using System.Text;

namespace AXA_Code_Test.Repository
{
    public interface ICityRepository
    {
        ICollection<string> GetCities();
    }
}
