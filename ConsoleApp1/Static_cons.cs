/*
Static constructors- 
if a constructor is explicitly declared by using static modifier
then we call it as s attsic constructor.
* if a class contaons any static variables then implicit static 
constructors will be present or else we need to define xplicitly.
* whereas non staticconstructors will be implicitly defined in
 ever class (except static class) provided we did not define 
 them explicitely.
* They are responsible in intializing static variables and aslo first to excute in a class
* they cant be parameterized , so overloading is not possible in static constructors.
*/
using System;
class Staticcons
{
    static Staticcons()
    {
        Console.WriteLine("Static constructor is executed");
    }

    static void main()
    {
        Console.WriteLine("main method is ThreadExceptionEventHandler");
    }
}

//After Execution;
// static constructor is executed"
// main method is ThreadExceptionEventHandler");

/*
class First
{
public int x=100;
}
class Second
{
    public int x;
    Public Second(int x)
    {
    this.x=x;   // this prints different variables passingthrough objects
    }
}
class TestClass
{
static void main()
{
  Second s1 = new Second(100);
  Second s2 = new Second(200);

}
}


*/