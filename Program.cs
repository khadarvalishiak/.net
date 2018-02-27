using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            int id=10;//takes 4 bytes of memory
            string Name = "Khadar";//takes the string Length
            long MobileNumber = 8143989689;
            float salary = 20000.3f;
            bool flag = true;
            Console.WriteLine("EmployeeId :" +id  +"\n "  +"EmployeeName:" +Name +"\n" +"Employee Mobile Number :" + MobileNumber + "\n" +"Employee Salary"+salary+"\n");
           
            Console.ReadLine();
        }
    }
}