/* 
Prameterized Constructor:
if a constructor method is defined with out any parameters we 
call that as parameterzed consructor and these constructors can 
be defined by the programmers only but never can be defined implicitly.

*/



using System;
class parameterizedConDemo
{
    int x;
    public parameterizedConDemo(int i)
    {
        Console.WriteLine("parameterized Constructor is called: "+ i);

    }
    public void Display()
    {
        Console.WriteLine("value of x is:"+x);

    }
    static void main()
    {
        parameterizedConDemo cd1 =new parameterizedConDemo(10);
        parameterizedConDemo cd2 =new parameterizedConDemo(20);
        Console.WriteLine(cd1.x);
        Console.WriteLine(cd2.x);
        cd1.Display();
        cd2.Display();


         Console.ReadLine();
    }
    
}