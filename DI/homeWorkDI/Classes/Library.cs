using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeWorkDI
{
    public class Library : ILibrary
    {
        public string IsBookAvailable()
        {
                return "This book is in our library";
        }
    }
}
