using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book= new Book("C# Programming");
            book.AddBookGrade(5.66);
            book.AddBookGrade(33.66);
            book.AddBookGrade(522.66);
             book.AddBookGrade(2.66);
            book.AddBookGrade(325.66);
            book.AddBookGrade(333.66);
            book.ShowStaticstic();
        
        }
    }
}
