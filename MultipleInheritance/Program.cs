using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    /* Multiple inheritance: It is a process of getting properties/data from more than one base class to single derived class.
    Syntax:- 
            Class c1  (Base/Parent Class)
            { 
            } 
            Class c2  (Base/Parent Class)
            {
            }
            Class C:C1,C2   (derived/child Class)
            {
            }  */

    internal class Program /*Program :A,B if we want to implement multiple inheritance we get compile time ambiguity error.
                                      beacuse compiler get's confuesed that which constructer i need to call.
                                      & if two method names are same in base class compiler get's confuesed that which method i need to call.
                                      In c#.net multiple inheritance is not possible by using classes which is possible with the help of interface. */
    {                             
        static void Main(string[] args)
        {
        }
    }
}
