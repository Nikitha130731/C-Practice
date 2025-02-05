/* 
Copy constructor; 
if we want  to create multiple instances with the same 
values then we use these copy constructors, in a copy constructor
 it takes the same class as a parameter to it.
*/

using System;
class CopyConDemo
{
    int x;
    public CopyConDemo(int i)   // default constructor
    {
        x= i;
    }
    public CopyConDemo(CopyConDemo obj) // constructor acts as datatype for obj 
    {
        x= obj.x;
    }

    public void Display()
    {
        Console.WriteLine("The value of X is: "+x);

    }
    public static void main()
    {
        CopyConDemo obj1 = new CopyConDemo(10);
        obj1.Display();
        CopyConDemo obj2 = new CopyConDemo(obj1);
        obj2.Display();
        
    }
}