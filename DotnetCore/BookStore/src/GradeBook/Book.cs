using System.Collections.Generic;
using System;
namespace GradeBook
{
    public class Book
    {
        private string name;
        private List<double> grades;

        public Book(string name){
            this.name=name;
            grades=new List<double>();
        }

        public void AddBookGrade(double grade){
            grades.Add(grade);
        }

        public double ShowStaticstic(){

         
            double maxValue=double.MinValue;
            double minValue=double.MaxValue;
            foreach(double grade in grades){
           
             if(grade>maxValue){
                 maxValue=grade;
             }
             if(grade<minValue){
                 minValue=grade;
             }

            }
            Console.WriteLine($"Max value:{maxValue}");
            Console.WriteLine($"Min value:{minValue}");
            return maxValue;
        }
    }
}