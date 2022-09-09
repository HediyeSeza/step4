using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] employees = new string[3];
            employees[0] = "John";
            employees[1] = "Mary";
            employees[2] = "Bob";

            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }

            string[] employees1 = { "Ali", "Hasan", "Hadi", "Sina" };
            Array.Sort(employees1);
            foreach (var i in employees1)
            {
                Console.WriteLine(i);
            }





            
            //List<string> employees = new List<string>();
            //employees.Add("Ali");   //index0
            //employees.Add("Hasan"); //index1
            //employees.Add("Vahid"); //index2
            //employees.Add("Sina");  //index3
            //employees.Add("Amir");  //index4

            //employees.RemoveAt(2);

            //employees.Insert(0, "Erfan");

            //employees.Remove("Amir");

            //int count = employees.Count;

            //bool check = employees.Contains("Sina");
            //bool ch = employees.Contains("Ramin");
            //employees.Sort();
            //foreach (var i in employees)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(check);
            //Console.WriteLine(ch);
            //Console.WriteLine(count);

            //Stack<string> MyEmployee = new Stack<string>();
            //MyEmployee.Push("ALi");
            //MyEmployee.Push("Sina");
            //MyEmployee.Push("Amir");
            //MyEmployee.Push("Ramin");

            //bool check= MyEmployee.Contains("Hediye");
            //Console.WriteLine(check);


            //Console.WriteLine("Last value:" + MyEmployee.Peek());

            //while(MyEmployee.Count>0)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine(MyEmployee.Pop());
            //    Console.ResetColor();
            //}

            Console.ReadKey();
        }
    }
}
