using System;
using Xunit;
using  GradeBook;
namespace GradeBook.Test
{
    public class GradeBookTest
    {
        [Fact]
        public void Test()
        {
                int expected=5;
                int actual=3+2;
                Assert.Equal(expected,actual);

        }

        [Fact]
        public void TestGradeBook(){
            //arrange
           var book = new GradeBook.Book("C++");
            book.AddBookGrade(1.33);
            book.AddBookGrade(5.33);
            book.AddBookGrade(3.33);
            
            //act
            var result=book.ShowStaticstic();

            //assert
            Assert.Equal(5.333,result,2);


        }
    }
}
