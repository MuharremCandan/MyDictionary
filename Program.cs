using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> users = new List<int>();
            MyDictionary<string> isimler = new MyDictionary<string>();
             
            
            while (true)
            {
                Console.Write("Please enter a name.(Press to q to finish.!)\nName:");
                string name = Console.ReadLine();
                if (name.ToUpper().Equals("Q"))
                {
                    Console.WriteLine("System shutting down...");
                    break;
                }
                isimler.Add(name);

            }
            isimler.ShowMyList();
        }
    }
}
