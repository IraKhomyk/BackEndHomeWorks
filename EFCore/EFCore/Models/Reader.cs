using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Reader
    {
        [Key,  DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReaderId { get; set; }
        public string ReaderName { get; set; }
        public string Email { get; set; }
        public IEnumerable<ReaderLibrary> ReaderLibraries {get;set;}
    }
}
