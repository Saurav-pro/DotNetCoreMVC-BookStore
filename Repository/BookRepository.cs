using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.BookStore.Models;

namespace WebApp.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorname)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authorname).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id= 1, Title = "mistakes", Author ="Saurav Tiwari" },
                new BookModel(){Id= 2, Title = "3 Mistes of Bhopal", Author ="Rahul Shukla" },
                new BookModel(){Id= 3, Title = "3 mistakes of Hydrabad", Author ="Sharukh khan" },
                new BookModel(){Id= 4, Title = "3 Mistes of jabalpur", Author ="Salman" },
                new BookModel(){Id= 5, Title = "3 Mistes of Ludhiyana", Author ="Simran" },
                new BookModel(){Id= 6, Title = "3 Mistes of Pune", Author ="Yogesh" },
                new BookModel(){Id= 7, Title = "3 Mistes of Raipur", Author ="Dhruv" },
                new BookModel(){Id= 8, Title = "3 Mistes of Kota", Author ="Seema mishra" }
            };
        }
    }
}
