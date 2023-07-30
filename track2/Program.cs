// See https://aka.ms/new-console-template for more information

using tack2;
using track2;

public class program
{
    public static void Main(string[] args)
    {
        Library l = new Library();

        Fictionbook f = new Fictionbook();
        f.author = "john doe";
        f.title = "the great fiction";
        f.ISBN = 12345;
        f.numpage = 300;
        f.genre = "adventure";

        Notfiction n = new Notfiction();
        n.author = "jane smith";
        n.title = "the  non-fictional world";
        n.ISBN = 45678;
        n.numpage = 200;
        n.subject = "history";

        l.AddBook(f);

        l.AddBook(n);

        Customer c = new Customer();
        c.name = "fatma";
        c.address = "alex";
        c.email = "fm7654@gimial.com";
        c.Checkout(f);
        c.Returnbook(f);
        Console.WriteLine("===================================");
        c.Checkout(n);
        c.Returnbook(n);
        Console.WriteLine("===================================");

        Librarian b = new Librarian();

        b.name = "tofy";
        b.address = "122 giza";
        b.email = "tofy@gimial.com";
        b.salary = 50000;
        b.AddBook(l, f);
        b.RemoveBook(l, n);
        b.ManageAccount(c);
        l.ManageCustomerAccount(c);
    }
}