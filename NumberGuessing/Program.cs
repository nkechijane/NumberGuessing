using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is " + num);
            
            //Declare a variable first name and assign a value to it, using var as data type
            var firstName = "Jane";
            Console.WriteLine(firstName);
            
            //Declare an integer variable without assigning a value
            int number;
            
            //Declare a variable that accepts true or false and assign a value to it using the var data type
            var isNumber = true;
            Console.WriteLine(isNumber);
            
            
            
        }
    }
}
