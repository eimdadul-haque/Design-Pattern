
using System;

namespace Singleton_pattern
{

//Singleton Parttetn
    class Singleton
    {
        private static Singleton obj = new Singleton();

        public static Singleton getObject()
        {
            return obj;
        }

        public void display()
        {
            Console.WriteLine("Hello from singleton pattern...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj = Singleton.getObject();
            obj.display();
        }
    }


//Factory Pattern


}
