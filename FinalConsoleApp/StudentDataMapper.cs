using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FinalConsoleApp
{
    public class StudentDataMapper : IDataMapper<Student>
    {
        private string path;

        public StudentDataMapper()
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "Students.txt";
        }

        private List<Student>GetStudents()
        {
            List<Student> students = new List<Student>();

            //read from Student.txt(using the System.IO)
            if(File.Exists(path))
            {
                var sr = new StreamReader(path);
                string line;
                //read each line in students.txt and populate a new student object with values from line within the file
                while(  (line = sr.ReadLine()) !=null)
                {
                    var elems = line.Split(',');//create array from CSV
                    var student = new Student
                    {
                        ID = Int16.Parse(elems[0]),
                        FirstName = elems[1],
                        LastName = elems[2],
                        Address = elems[3],
                        City = elems[4],
                        Province = elems[5],
                        PostalCode = elems[6],
                        Phone = elems[7],
                        Email = elems[8],
                        EnrollDate = DateTime.Parse(elems[9]),
                        Major = elems[10]
                    };

                    //Add each new student (one for each line in student.txt) to list
                    students.Add(student);
                }
            }
            return students;
        }



        public List<Student> Find(string LastName)
        {
            //First get all the students
            var searchStudents = GetStudents();

            //find student containing the searched lastname: using LINQ
            //LINQ - Language Integrated Query
            //Note: We will need to convert IEnumerable back to a list
            return searchStudents.Where(s => s.LastName.Contains(LastName)).ToList();
        }

        public List<Student> Select()
        {
            return GetStudents();
        }
    }
}
