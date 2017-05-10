using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            getarea(7,11);
        }

        static void getarea(int x, int y){
            int area = x * y; 
            Console.WriteLine("The area of a 7x11 rectangle is " + area + ".");
        }
    }

}
