using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Student
    {


        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }

        public override bool Equals(Object obj)
        {
            Student sp = (Student)obj;

            if ((StudentID == sp.StudentID) && (StudentName == sp.StudentName) &&((Age == sp.Age)))
                return true;

            return false;
        }
    }
}