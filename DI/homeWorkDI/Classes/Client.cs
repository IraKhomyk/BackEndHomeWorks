using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeWorkDI
{
    public class Client
    {
        public string OrderBook(ILibrary library)
        {
            return library.IsBookAvailable();
        }

        public string TicketNumber { get; set; }
    }
}
