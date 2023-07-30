using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tack2;

namespace track2
{
    public class Library
    {
        public List<Book> Books = new List<Book>();
        public List<Customer> Customers = new List<Customer>();
        public List<Librarian> Librarians = new List<Librarian>();

        public void AddBook(Book book)
        {
            Books.Add(book);

        }
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
        public List<Book> SearchBooks(string keyword)
        {
            List<Book> searchResults = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.title.ToLower().Contains(keyword.ToLower()))
                {
                    searchResults.Add(book);
                }
            }
            return searchResults;
        }
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);

        }
        public void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }

        public void ManageCustomerAccount(Customer customer)
        {
            Console.WriteLine("Managing account for customer " + customer.name + ".");


        }
    }
}
