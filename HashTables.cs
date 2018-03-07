using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class HashTables
    {
        static void Main(String[] args)
        {
            `//Hash Tables are same as arraylist like Key and Value paired .
            //But in HashTables the keys are user defined.
            Hashtable hb = new Hashtable();
            //HashTable has an method called add but it takes two parameters i.e key and value
            hb.add("EmpID", 100);
            hb.add("EmpName", "Khadar");
            hb.add("EmpSalary", 30000M);
            //All the values in a values  will be stored in hash table baed on Hashing Algorithum by converting all the values into hash codes.
            //Every value contains "Key, value, and a hashcode", here hash code will be stored in the form of an intiger .
            // And Hash table Perofrmance is Much Efficent when compare with Array and ArrayList.

            foreach(object ob in hb.keys)

            {
                Console.WriteLine(Key);//prints the keys of hash table..
                Console.WriteLine(hb[key]);//Will Print the values of hash Table.
            }


        }
    }
}
