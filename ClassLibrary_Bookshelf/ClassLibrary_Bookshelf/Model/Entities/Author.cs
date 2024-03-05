using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Bookshelf.Model.Entities
{
    public class Author
    {
        public Author(int id, string name, int age, Book publishedBooks)
        {
            Id = id;
            Name = name;
            Age = age;
            PublishedBooks = publishedBooks;
        }

        private int Id { get; set; }
        private string Name { get; set; }
        private int Age { get; set; }
        private Book PublishedBooks { get; set; }

        // Link study https://github.com/marciocrodrigues/Teste-Empresa-.net-core/blob/master/TesteBitzen/TesteBitzen.DOMAIN/Entities/Usuario.cs
    }
}
