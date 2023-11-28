using System;

namespace Lab3
{
    class Program
    {
        public void Add()
        {
            Console.WriteLine("Empty parameter add function \n");
        }

        public void Add(int x) { 
            Console.WriteLine("Single parameter add function with value {0} \n", x);
        }

        public void Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum of {0} and {1} = {2} \n", x, y, sum);
        }

        public void Add(int x, int y, int z)
        {
            Console.WriteLine("Sum of {0}, {1} and {2} = {3} \n", x, y, z, (x + y + z));
        }

        static void Main(string[] args) { 
            Program obj = new Program();
            obj.Add();
            obj.Add(5);
            obj.Add(5, 6);
            obj.Add(5, 6, 7);
            Console.ReadKey();
        }
    }
}