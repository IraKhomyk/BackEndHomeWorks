using EFCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReaderController : ControllerBase
    {
        private  MyContext mycontext;
        private readonly ILogger<ReaderController> _logger;
        public ReaderController(ILogger<ReaderController> logger, MyContext context)
        {
            _logger = logger;
            mycontext = context;
        }


        [HttpGet]
        public IEnumerable<Reader> Get()
        {
            using (mycontext)
            {
                return mycontext.Readers.ToList();
            }
        }
        [HttpPost]
        public IEnumerable<Reader> Post()
        {
           using (mycontext)
            {
                Reader reader = new Reader();
                reader.ReaderName = "Ira";
                reader.Email = "ira@gmail.com";

                mycontext.Readers.Add(reader);

                mycontext.SaveChanges();

                return mycontext.Readers.ToList();
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            using (mycontext)
            {
                var reader = mycontext.Readers.Find(id);
                mycontext.Readers.Attach(reader);
                mycontext.Readers.Remove(reader);

                mycontext.SaveChanges();
                return NoContent();
            }
        }
    }
}
