using System;

namespace Day_6
{
class Program
{
public static Tuple<double,double> AddMultiSubDiv(double a,double b)\\declare type of tupple
{
return new Tuple<double, double>((a+b), (a*b), (a-b), (a/b));\\declare number and value of tupple
}
static void Main()
{
Tuple<double, double> output = Program.AddMultiSubDiv(3,5,2,0);
Console.WriteLine("Sum = "+output.Item1+"Multiplication Value= "+output.Item2+"Subtraction Value= "+output.Item3+"Division Value= "+output.Item4);
Console.ReadLine();
}
}
}
