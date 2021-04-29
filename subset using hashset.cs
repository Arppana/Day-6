using System;
namespace Day_6
{
class Class4
{
public static void Main()
{

HashSet<int> ts1 = new HashSet<int>();
ts1.Add(1); ts1.Add(2); ts1.Add(3);

HashSet<int> ts2 = new HashSet<int>();
ts2.Add(1); ts2.Add(2);
Console.WriteLine(ts2.IsSubsetOf(ts1));


}
}
}