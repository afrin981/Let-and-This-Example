using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetAndThisExample
{
    class Program
    {
        public string Name;

        static void Main(string[] args)
        {
            Program objProgram = new Program();
            objProgram.LetExample();
            objProgram.SetName("Afrin");
            Console.WriteLine(objProgram.GetName());
            Console.ReadKey();
        }

        public void LetExample()
        {
            //The 'let' keyword is used in query syntax. It projects a new range variable, allows re-use of the expression and makes the query more readable.
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            var lowercaseStudentNames = from s in studentList
                                        let lowercaseStudentName = s.StudentName.ToLower()
                                        where lowercaseStudentName.StartsWith("r")
                                        select lowercaseStudentName;

            foreach (var name in lowercaseStudentNames)
                Console.WriteLine(name);
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Name)
        {
            //“this” keyword is used to refer to the current instance of the class. It is also used to differentiate between the method parameters and class fields if they both have the same name.            
            this.Name = Name;
        }
    }
}
