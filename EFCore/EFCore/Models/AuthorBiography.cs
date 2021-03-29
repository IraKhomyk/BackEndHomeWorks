using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class AuthorBiography
    {
        public int Id { get; set; }
        public string Biography { get; set; }
        public Author Author{get;set;}
        public int AuthorId { get; set; }
    }
}
