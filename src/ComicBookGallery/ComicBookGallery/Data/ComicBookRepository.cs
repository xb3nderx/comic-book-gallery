using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue.... if spiderman survives <strong>Will Peter parker survive???</strong></p>",
                Artists = new Artist[]
                {
                    new Artist(){Name = "Dant Slott", Role = "Script"},
                    new Artist(){Name = "Humberto Ramos", Role = "Pencil"},
                    new Artist(){Name = "Victor Olazaba", Role = "Inks"},
                    new Artist(){Name = "Edgar Delgado", Role = "Colors"},
                    new Artist(){Name = "Chris Eliopoulos", Role = "Letters"}
                },
                Favorite = false
            },

             new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE IN .</strong>Siper-Man unveils his secrete to aunt Mary</p>",
                Artists = new Artist[]
                {
                    new Artist(){Name = "Dant Slott", Role = "Script"},
                    new Artist(){Name = "Marcos Martin", Role = "Pencil"},
                    new Artist(){Name = "Marcos Martin", Role = "Inks"},
                    new Artist(){Name = "Muntsa Vicente", Role = "Colors"},
                    new Artist(){Name = "Joe Caramagna", Role = "Letters"}
                },
                Favorite = false
            },

            new ComicBook()
            {   
                Id=3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1</strong>Thorn is discovered by Lord Tars</p>",
                Artists = new Artist[]
                {
                    new Artist(){Name = "Jeff Smith", Role = "Script"},
                    new Artist(){Name = "Jeff Smith", Role = "Pencil"},
                    new Artist(){Name = "Jeff Smith", Role = "Inks"},
                    new Artist(){Name = "Jeff Smith", Role = "Letters"}
                },
                Favorite = false
            }

    };
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach ( var comicBook in _comicBooks)
            {
                if(comicBook.Id == id)
                {
                    comicBookToReturn = comicBook; 
                    break;
                }
                
            }

            return comicBookToReturn;
        }

        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }
    }
}