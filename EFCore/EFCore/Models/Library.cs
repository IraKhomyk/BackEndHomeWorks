using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Library
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibraryId { get; set; }
        public string Address { get; set; }
        public IEnumerable<ReaderLibrary> ReaderLibraries { get; set; }

    }
}
