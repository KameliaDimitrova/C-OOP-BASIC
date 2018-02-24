using System;

namespace Problem_2._Book_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            GoldenEditionBook goldenEditionBook=new GoldenEditionBook();
            var bookAuthor = Console.ReadLine();
            var bookTitle = Console.ReadLine();
            decimal bookPrice = decimal.Parse(Console.ReadLine());
            try
            {
                goldenEditionBook = new GoldenEditionBook(bookAuthor, bookTitle, bookPrice);
                book = goldenEditionBook;
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
                return;
            }
            Console.WriteLine(book+Environment.NewLine);
            Console.WriteLine(goldenEditionBook);

        }
    }
}
