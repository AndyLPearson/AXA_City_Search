using System;
using System.Collections.Generic;
using System.Text;

namespace AXA_Code_Test.Interfaces
{
    public interface ICityResult
    {
        /* 
             Not sure if I'm allowed to change this, but for NextLetters,
             would it benefit being an ICollection<char> rather than string
             due to it only dealing with singular characters?
         */
        ICollection<string> NextLetters { get; set; } 

        ICollection<string> NextCities { get; set; }
    }
}
