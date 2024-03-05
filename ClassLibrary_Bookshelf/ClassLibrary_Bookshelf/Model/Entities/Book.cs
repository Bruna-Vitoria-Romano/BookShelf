using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Bookshelf.Model.Entities
{
    public class Book
    {
        public Book(int id, string tittle, string literaryGenre, Author idAuthor, int ageRating, string description)
        {
            Id = id;
            Tittle = tittle;
            LiteraryGenre = literaryGenre;
            IdAuthor = idAuthor;
            AgeRating = ageRating;
            Description = description;
        }

        public int Id { get; set; }
        public string Tittle { get; set; }
        public string LiteraryGenre { get; set; }
        public Author IdAuthor { get; set; }
        public int AgeRating { get; set; }
        public string Description { get; set; }
    }
}
