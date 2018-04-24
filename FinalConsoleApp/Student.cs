using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
   public class Student:Person
    {
        //the : is the inheritance symbol
        //Student id inheriting all the properties from Person

        //Student sepcific properties
        public DateTime EnrollDate { get; set; }
        public string Major { get; set; }

        //Read only property
        //test
        public string StudentName
        {
            get
            {
                //return FirstName + " " + LastName;
                return LastName + " , " + FirstName;
            }
        }

    }
}
