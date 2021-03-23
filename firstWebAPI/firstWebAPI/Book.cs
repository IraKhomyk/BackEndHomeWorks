using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstWebAPI
{
    public class Book
    {
            public int Id { get; set; }
            public string Name { get; set; }

            public string Author { get; set; }

            public int AmountOfPages { get; set; }

            public string Publishing { get; set; }

            public string Genre { get; set; }
    }
}
