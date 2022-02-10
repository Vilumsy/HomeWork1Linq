using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
          new Student() { StudentID = 1, StudentName = "John", Age = 13, } ,
          new Student() { StudentID = 2, StudentName = "Moin", Age = 21, } ,
          new Student() { StudentID = 3, StudentName = "Bill", Age = 18, } ,
          new Student() { StudentID = 4, StudentName = "Ram" , Age = 19, } ,
          new Student() { StudentID = 5, StudentName = "Ron" , Age = 18, } };



            Student student = new Student() { StudentID = 1, StudentName = "John", Age = 13 };
            var test = studentList.Contains(student);
            Console.WriteLine(test);
        
        }

    }


}