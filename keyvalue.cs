using System;
using System.Collections.Generic;
namespace ConsoleApp8
{
   public class Class4
    {
        public static void Main()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Arppana");
            keyValuePairs.Add(2, "Rohith");
            keyValuePairs.Add(3, "Aathira");
            if(keyValuePairs.ContainsKey(4)==true)
            {
                Console.WriteLine("Key found");
            }
            else
            {
                Console.WriteLine("Key not found");
            }
            if(keyValuePairs.ContainsValue("Sudeep S"))
            {
                Console.WriteLine("Value found");
            }
            else
            {
                Console.WriteLine("Value not found");
            }
            Console.ReadLine();
        }
    }
}

