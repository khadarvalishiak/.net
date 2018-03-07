using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class GenericCollections
    {
        //Array :- arrays are type safe like if we want to store the same type of data, we can use and it is the best feature for Type Safe 
        //But there is no Resizeing at run time

        //Collection :- Collections are best in Resizing but it is not Type Safe , because collections will store any kind of data at runtime,
        //Like wise if we are passing string, boolena, double, float, int..etc it will accept if we used collections for accepting only spesific intigrt type of data storage 
        //Collections are not recomendeed to use.

        //To over come the type safe and Auto Resize "GENERIC-CoLLECTIONS" Came into the Picture.
        //Generic Collections :- List
        static void main(String[] args)
        {

        
        List<int> li = new List<int>();
        //To stor the values into the list directly we ca use add method
        li.Add(10); li.Add(20); li.Add(30); li.Add(10);
             
            for(int i=0; i<=li.Count;i++)
            {
                Console.WriteLine(li[i]);
                Console.WriteLine();

            }
            Console.ReadLine();
            // If we want to Add an item in the middle
            li.Insert(4, 40);
            //If we want to remove the value 
            li.RemoveAt(4);

            List<string> ls = new List<string>();
        List<float> lf = new List<float>();
       //Like wise we can dtor all kind of datat types not only that we can store Complex type like class.

        public class Employee
        {
            public string name { get; set; }
            public int id { get; set; }
        }
        //Now , if we want to use this Employee calss , yes we can use through list

        List<Employee> le = new List<Employee>();



    }

}
}
