using System;
using System.Collections.Generic;


namespace Day6
{
   public class Class2
    {
        public static void Main()
        {
            List<int> mylist = new List<int>();
          
            for(int i=0;i<10;i++)
                {
                Console.WriteLine("enter a number");
                i = Convert.ToInt32(Console.ReadLine());
                mylist.Add(i);

                }
            foreach (var item in mylist)
            {
                if(item%2==0)
                {
                    Console.WriteLine("EVEN :" + item);
                }
                else
                {
                    Console.WriteLine("odd :" + item);
                }
            }
            
            Console.ReadLine();
        }

    }
}