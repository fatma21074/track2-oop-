using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tack2;

namespace track2
{
    public class Customer

    {
        public string name;
        public string address;
        public string email;
        public List<Book> Bookscheckedout = new List<Book>();

        public Customer()
        {
            Bookscheckedout = new List<Book>();
        }

        public void Checkout(Book book)
        {
            Bookscheckedout.Add(book);
            book.checkout();
        }
        public void Returnbook(Book book)
        {
            Bookscheckedout.Remove(book);
            book.returnbook();

        }
    }
}
