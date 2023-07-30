using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tack2
{
    public abstract class Book
    {
        public string author;
        public string title;
        public int ISBN;
        public int numpage;
        public abstract void checkout();

        public abstract void returnbook();

    }
    public class Fictionbook : Book
    {
        public String genre;
        public override void checkout()
        {
            Console.WriteLine("Fiction book '" + title + "' checked out");

        }
        public override void returnbook()
        {
            Console.WriteLine("Fiction book '" + title + "' returned.");

        }


    }
    public class Notfiction : Book
    {
        public string subject;
        public override void checkout()
        {
            Console.WriteLine("Not_Fiction book '" + title + "' checked out ");


        }
        public override void returnbook()
        {
            Console.WriteLine("Not Fiction book '" + title + "' returned.");

        }



    }
}
