using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tack2;

namespace track2
{
    public class Librarian
    {
        public string name;
        public string address;
        public string email;
        public decimal salary;

        public void AddBook(Library library, Book book)
        {
            library.AddBook(book);
            Console.WriteLine("Book '" + book.title + "' added to the library.");
        }
        public void RemoveBook(Library library, Book book)
        {
            library.RemoveBook(book);
            Console.WriteLine("Book '" + book.title + "'removed to the library.");
        }
        public void ManageAccount(Customer customer)
        {
            Console.WriteLine("Account for customer '" + customer.email + "' managed.");
            Console.WriteLine("name of customer'" + customer.name + "'.");
        }

    }

}
