using System.IO;
using System;

class Program
{
    static void Main()
    {
        Hashtable g = new Hashtable();
        g.Add(1,"Welcome");
        g.Add(2,"to");
        g.Add(3, "C sharp");
        g.Add(4, "CLass");
        ICollection key = g.Keys;
        
        foreach (var item in key)
        {
            Console.WriteLine(key + "-" +g[item]);
        }
        Console.ReadLine();
    }
}