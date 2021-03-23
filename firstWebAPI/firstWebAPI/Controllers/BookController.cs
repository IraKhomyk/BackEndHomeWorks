using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Text.Json;
using System.Net.Http;
using System.Net;

namespace firstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        string path = @"C:/Users/flagman/Ira/firstWebAPI/firstWebAPI/data.txt";

        private readonly ILogger<BookController> _logger;

        List<Book> CreatedList;
        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;

            string readText = System.IO.File.ReadAllText(path);
            CreatedList = JsonSerializer.Deserialize<List<Book>>(readText);
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return CreatedList;
        }

        [HttpPost]
        public Book Post(Book book)
        {
            CreatedList.Add(book);

            string writeText = JsonSerializer.Serialize(CreatedList);
            System.IO.File.WriteAllText(path, writeText);

            return book;
        }

        [HttpPut]
        public Book Edit(Book book)
        {
            CreatedList[CreatedList.FindIndex(elem => elem.Id == book.Id)] = book;

            string writeText = JsonSerializer.Serialize(CreatedList);
            System.IO.File.WriteAllText(path, writeText);

            return book;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            CreatedList.RemoveAt(id - 1);

            string writeText = JsonSerializer.Serialize(CreatedList);
            System.IO.File.WriteAllText(path, writeText);

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
