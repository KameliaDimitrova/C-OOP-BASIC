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
                book=new Book(bookAuthor,bookTitle,bookPrice);
                goldenEditionBook = new GoldenEditionBook(bookAuthor, bookTitle, bookPrice);
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
