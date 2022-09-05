using System;
using System.Collections;
using System.Text;
namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
        public void Almacenar(Almacenamiento Book)
        {
            this.book=Book;
        }
        public Almacenamiento book { get; set;}
/*
Esta clase no cumple con el principio SRP.
Ya que esta clase no tiene una responsabilidad única.
Esta clase además de crear el libro también guarda donde se almacena. 
Y si la universidad decide de cambiar la forma en la que se almacenan los libros, esta clase debe ser modificada


*/

    }
}
