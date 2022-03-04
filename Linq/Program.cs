// Notes
// Language Integrated Query - ability to query objects
// - objects in memory (Linq to Objects)
// - databases (LINQ to Entities)
// XML
// - ADO.NET Data Sets (LINQ to Data Sets

namespace LinqExploration
{
    public class Program
    {
        static void Main(string[] args)
        {
            var repository = new BookRepository();
            var books = repository.GetBooks();

            // Get books cheaper than 10
            // Without LINQ:
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            // With Linq Extension Methods
            var cheapBooks = books.Where(b => b.Price < 10);
            var cheapBooksSorted = books.Where(b => b.Price < 10).OrderBy(b => b.Title);
            var cheapBookTitles = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);

            foreach (var book in cheapBooksSorted)
                Console.WriteLine($"{book.Title}: {book.Price}");

            // With Linq Query Operators
            var cheapBooks2 = from b in books
                              where b.Price < 10
                              orderby b.Title
                              //select b OR
                              select b.Title;


            // Other Methods:
            Console.WriteLine(books.Single(b => b.Title == "ASP.NET MVC")); 
            Console.WriteLine(books.SingleOrDefault(b => b.Title == "ASP.NET ABC"));
            Console.WriteLine(books.First()); // Last
            Console.WriteLine(books.First(b => b.Title == "C# Advanced Topics")); // Last
            Console.WriteLine(books.FirstOrDefault(b => b.Title == "ASP.NET ABC")); // LastOrDefault
            var firstTwoBooks = books.Take(2);
            var lastTwoBooks = books.Skip(3);
            Console.WriteLine(books.Count());
            Console.WriteLine(books.Max(b => b.Price)); // Min
            Console.WriteLine(books.Sum(b => b.Price));
            Console.WriteLine(books.Average(b => b.Price));
        }
    }
}