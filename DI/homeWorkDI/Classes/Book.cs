using System;

namespace homeWorkDI
{
    public class Book : IBook
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Book (string name, string author)
        {
            Name = name;
            Author = author;
        }

    }
}
