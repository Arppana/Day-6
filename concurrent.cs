using System;
Using System.Collections;
namespace Day_6
{
class Class8
{
public static void Main();
{
BlockingCollection<int> vs = new BlockingCollection<int>(2);
Task.Run(() =. {
while(!vs.IsCompleted)
{
int x = 0;
try
{
x = vs.Take();
}
catch(InvalidOperationException)
{
}
if(xl=0)
{
//Process(x);
}
}
}0;
Task.Run(()=>
while(some condition here)
{
int x = 0;
vs.Add(x);
}
}
vs.CompleteAdding();
);
}