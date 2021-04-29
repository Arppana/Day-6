using System;
namespace Day_6
{
class Class4
{
public static void Main()
{

LinkedList<string> vs = new LinkedList<string>();
vs.AddLast("Vikash");
vs.AddLast("Verma");
vs.AddLast("is");
vs.AddLast("in");
vs.AddLast("INDIA");
Console.WriteLine(vs.First.Value);
Console.WriteLine(vs.Last.Value);
Console.WriteLine(vs.contains("INDIA"));
foreach (var item in vs)
{
Console.WriteLine(item);
}
}
}
}