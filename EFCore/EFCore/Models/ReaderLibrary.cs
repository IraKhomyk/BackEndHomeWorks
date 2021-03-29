using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class ReaderLibrary
    {
        public int ReaderId { get; set; }
        public Reader Reader { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; }

    }
}
