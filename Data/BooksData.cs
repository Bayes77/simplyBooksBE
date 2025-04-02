using simplyBooksBE.Models;

namespace simplyBooksBE.Data
{
    public class BooksData
    {
        public static List<Books> Book = new()
        {
            new() { Id = 201, Author_Id = 101, Uid = "B1", Title = "The Secret", Price = 10, Sale = true, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg", Description = "The Secret is a best-selling 2006 self-help book by Rhonda Byrne, based on the earlier film of the same name. It is based on the belief of the law of attraction, which claims that thoughts can change a person's life directly."
            },
            new() { Id = 202, Author_Id = 102, Uid = "B2", Title = "The Alchemist", Price = 15, Sale = false, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg", Description = "The Alchemist is a novel by Brazilian author Paulo Coelho that was first published in 1988. Originally written in Portuguese, it became a widely translated international bestseller."
            },
            new() { Id = 203, Author_Id = 103, Uid = "B3", Title = "The Power of Now", Price = 12, Sale = true, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg", Description = "The Power of Now: A Guide to Spiritual Enlightenment is a book by Eckhart Tolle. The book is intended to be a guide for day-to-day living and stresses the importance of living in the present moment and transcending thoughts of the past or future."
            },
            new() { Id = 204, Author_Id = 104, Uid = "B4", Title = "The 7 Habits of Highly Effective People", Price = 20, Sale = false, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg", Description = "The 7 Habits of Highly Effective People, first published in 1989, is a business and self help book"
            },
            new() { Id = 205, Author_Id = 105, Uid = "B5", Title = "The Four Agreements", Price = 18, Sale = true, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg", Description = "The Four Agreements: A Practical Guide to Personal Freedom is a self-help book by bestselling author Don Miguel Ruiz with Janet Mills. The book offers a code of personal conduct based on ancient Toltec wisdom that advocates freedom from self-limiting beliefs that may cause suffering and limitation in a person's life."
            },
        };
    }
}
