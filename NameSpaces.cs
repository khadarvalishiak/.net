using System;
using XYZ;//User Defined Namespace 
using ABC;
using Namespace1 = XYZ;//Alias Namespaces
using namespace2 = ABC;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
         //  print.display();// if we haev declired that namespace earlier directly acesses through your Method name what u spesify.
          //  print.display();// compiler  get ambiguity when we use the same method name
                            //insted of thta we nned to spesify fully qalified namespaces or alias names for it.


            //XYZ . print.display();
            //ABC.print.display();// So, these type of spesification is called as Qalified Namespaces


            Namespace1.print.display();
            namespace2.print.display();



        }
    }
}

namespace XYZ
{
    class  print
    {
        public static void display()
        {
            Console.WriteLine("XYZ Namespace");


        }
    }
}

namespace ABC
{
    class print
    {
        public static void display()
        {
            Console.WriteLine("ABC Namespace");
            Console.ReadLine();

        }
    }
}