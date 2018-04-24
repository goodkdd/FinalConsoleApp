using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    internal interface IDataMapper<T> 
    {
        /*
         * T in <T>
         * A generic type parameter allows you to specify an abitrary type "T" tp a method a compile-time, without specifying a concrete type in the method
         * or class declaration
         * <T> can be any type of object
        */
    

    List<T> Select();
    List<T> Find(string LastName);

    }
}
