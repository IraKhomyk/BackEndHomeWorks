using EFCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private MyContext mycontext;

        public LibraryController( MyContext context)
        {
            mycontext = context;
        }


        [HttpGet]
        public IEnumerable<Library> Get()
        {
            using (mycontext)
            {
                return mycontext.Libraries.ToList();
            }
        }
        [HttpPost]
        public IEnumerable<Library> Post()
        {
            using (mycontext)
            {
                Library library1 = new Library();
                library1.Address = "Lviv";

                mycontext.Libraries.Add(library1);
                mycontext.SaveChanges();

                return mycontext.Libraries.ToList();
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            using (mycontext)
            {
                var library = mycontext.Libraries.Find(id);
                mycontext.Libraries.Attach(library);
                mycontext.Libraries.Remove(library);

                mycontext.SaveChanges();
                return NoContent();
            }
        }
    }
}
