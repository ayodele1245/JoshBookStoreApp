using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="Chemistry", Author="Nitish", Description="This is chemistry book", Category="Pure Science", Language="English", TotalPages=1829},
                 new BookModel(){Id=2, Title="Physics", Author="Josh", Description="This is Physics book", Category="Pure Science", Language="English", TotalPages=1346},
                  new BookModel(){Id=3, Title="Biology", Author="Josh", Description="This is Biology book", Category="Pure Science", Language="English", TotalPages=1829},
                   new BookModel(){Id=4, Title="Agric", Author="Nitish", Description="This is Agric book", Category="Pure Science", Language="French", TotalPages=135},
                    new BookModel(){Id=5, Title="Chemistry", Author="Nitish", Description="This is chemistry book", Category="Pure Science", Language="English", TotalPages=654},
                    new BookModel(){Id=5, Title="Mathematics", Author="Toyin", Description="This is Mathematics book", Category="Calculations", Language="English", TotalPages=6529}
            };
        }
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }
    }
}
