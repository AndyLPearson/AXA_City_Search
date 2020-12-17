using System;
using System.Collections.Generic;
using System.Text;

namespace AXA_Code_Test.Interfaces
{
    public interface ICityFinder
    {
        ICityResult Search(string searchString);
    }
}
