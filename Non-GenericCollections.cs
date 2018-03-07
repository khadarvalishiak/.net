using System;
using System.Collections;


//Collections are dynamic Arrays where we can insert data at runtime.
//where the collection have a flexibilty to add or remove an element in the runtime.
//The collections classes are stored in System.Collection; NmaeSpace.

//In General collections contains many Collection classes are Available 
//In Version 1.0 these collections are Introdused So where those collections are called NON-GENERIC COLLECTIONS 
//Example :- Stack,queue,List,LinkedList,Sorted List, Array List..ETC ALl of these classes are Implemented In .net just we need to use the classes and create 
// object and we can use it.
namespace CSharpBasics
{
    class Collections
    {
        static void Main(String[] args)
        {

            ArrayList al = new ArrayList();//ArrayList () is a default construtor . that collection interface have been provided
            //There is one more constructor that is avaliable with parameter i.e ArrayList(Initial Capacity)
            //Ex:- ArrayList al=new ArrayList(20); Where we can spesify initial size of an arraylist.
            Console.WriteLine(al.Capacity);
            //Internally there wont be any size for this array list .So Lets try to insert few elements and see the size.
            al.add(10);
            Console.WriteLine(al.Capacity);
            //Now if we check the size of arrayList we will find the value 4 so we can store 3 more Items into ArrayList.
            al.add(20);
            al.add(30);
            al.add(40);
            //Now If we try to add one more element into the arrayList 
            al.add(50);
            Console.WriteLine(al.Capacity);
            //Now the capacity will be 8 

            foreach(Object obj in al)
            {
                Console.WriteLine(obj);
            }
            //Now if we want to Insert a value in the middle of an arraylist, We can use Insert method it takes two parameters (index and value)

            al.Insert(3, 60);

            //Now if we want to remove an Item in the middle of an arraylist , we can use Remove mthod takes the parameter as value what we want to remove.

            al.Remove(30);
            //We can remove the value based on the index position also 
            al.Remove(2);



                }

    }
}


//The problem with arrayList is its a combo of Key(Predefiened) & value  but if we are storing multimple items or values suddenly if we want to fetch data we cant acesses directly untill
//and unless if we know he index value , that is the problem with Array List thats y Hash Tables are Introdused.