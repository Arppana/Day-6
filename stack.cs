using System;
namespace Day_6
{
class Class7
{
public static void Main()
{
//LIFO
Stack<string> vs = new Stack<string>();
vs.Push("Vikash")
vs.Push("Verma");
foreach (var item in vs)
{
Console.WriteLine(item);
}
}
}
}