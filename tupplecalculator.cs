using System;

namespace ConsoleApp8
{
   public  class Program
    {
        public static Tuple<double, double, double, double> Calculator(double a, double b)//declare type of tupple
        {
            return new Tuple<double, double, double, double>((a+b), (a* b), (a-b), (a/b));//declare number and value of tupple
}
   public static void Main()
    {
        Tuple<double, double, double, double> output = Program.Calculator(3.5, 2.0);
        Console.WriteLine("Sum = " + output.Item1 + "Multiplication Value= " + output.Item2 + "Subtraction value = " + output.Item3 + "Division value = " + output.Item4);
        
    }
}
}