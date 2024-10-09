using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printHello();
            GreetUser("EDVIN");
            calculateSum(4, 5);

            printMessage("hI");
            printMessage();
            DisplayInfo("EDVIN");
            OrderCoffee(size: "medium", sugar: 100, milk: true);
            BookFlight("Srilanka", date: "19.02.2025", "Thirdclass");
            Multiply(4, 5);
            Multiply(4, 5);
            Multiply(4, 5, 6);
            Display("Edvin");
            Display(21);
            Display(31.4);
            calculatearea(4.5);
            calculatearea(4.5, 5);
            ConvertTemperature(35.5);
            ConvertTemperature(100);
            AddToCard("banana", 5, 100);
            Transfer(1000, 699900, 40000);





        }
        static void printHello()
        {

            Console.WriteLine("Hello,World!");
            Console.ReadLine();
        }
        static void GreetUser(string name)
        {
            Console.WriteLine("Hello " + name);
            Console.ReadLine();

        }
        static void calculateSum(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }
        static void printMessage(string message = "HelloWorld")

        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
        static void DisplayInfo(string name = " ", int age = 25)
        {
            Console.WriteLine("Name is " + name + " " + "\n" + "Age is" + age);

            Console.ReadLine();
        }
        static void OrderCoffee(string size, int sugar, bool milk)
        {
            Console.WriteLine("size is" + ":" + size + "\n " + "sugar gram is" + ":" + sugar + "\n" + "Do  want milk?" + ": " + milk);
            Console.ReadLine();
        }
        static void BookFlight(string destination, string date, string classType)
        {
            Console.WriteLine("destination is" + ":" + destination + "\n " + "date" + ":" + date + "\n" + "class type is" + ": " + classType);
            Console.ReadLine();
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine("answer is: " + a * b);

            Console.ReadLine();
        }
        static void Multiply(double a, double b)
        {
            Console.WriteLine("answer is: " + a * b);
            Console.ReadLine();
        }
        static void Multiply(int a, int b, int c)
        {
            Console.WriteLine("answer is: " + a * b * c);
            Console.ReadLine();
        }
        static void Display(string name)
        {
            Console.WriteLine("name is " + name);
            Console.ReadLine();
        }
        static void Display(int age)
        {
            Console.WriteLine("age is " + age);
            Console.ReadLine();
        }
        static void Display(double temperature)
        {
            Console.WriteLine("temperature is " + temperature);
            Console.ReadLine();
        }
        static void calculatearea(double a)
        {
            Console.WriteLine(" square area is " + a * a);
            Console.ReadLine();
        }
        static void calculatearea(double a, double b)
        {
            Console.WriteLine(" rectangle area is " + (a * b));
            Console.ReadLine();

        }
        static void ConvertTemperature(double temper)
        {
            Console.WriteLine("celcius value is " + ((temper * 5 / 9) - 32));
            Console.ReadLine();
        }
        static void ConvertTemperature(int temperatures)
        {
            Console.WriteLine(" Fahrenheit value is " + (temperatures * 9 / 5) + 32);
            Console.ReadLine();
        }
        static void AddToCard(string productname, int quantity, int price)
        {
            Console.WriteLine("product name is " + productname + "\n" + "quantity numbers: " + quantity + "\n" + "total is " + price * quantity);
            Console.ReadLine();
        }
        static void Transfer(int depositamount, int number, int transfer)
        {
            Console.WriteLine("deposit amount is " + depositamount + "\n" + "your account number is " + number + "\n" + "your balance is " + (transfer + depositamount));
            Console.ReadLine();
        }
        static void


    }
}