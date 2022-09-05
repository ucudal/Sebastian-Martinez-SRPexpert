using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Almacenamiento Alm1 = new Almacenamiento("A","7");
            Almacenamiento Alm2 = new Almacenamiento("B","3");
            book1.Almacenar(Alm1);
            Console.WriteLine(book1.book.LibrarySector);
            book2.Almacenar(Alm2);

        }
    }
}