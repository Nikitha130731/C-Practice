/*
- it is a special method present under a class responsible 
  for  intializing the variable of that class
- the name of a constructor method is exactly 
  the same name of the class in which it was present
   and more over it's a non value returning method.
- Each and every class requires this constructor if 
   we wnat to create the instance of that class
- implicitly defined constructors are parameter less and 
  these are also known as default constructors.
- implicitly defined constructors are public
- we can also define a constructor under the class and if we
  define it we can call it as explicit constructor and 
  it can be parameter less or parameterized also.
*/


// implicit constructors
using System;
using System.Runtime.InteropServices.Marshalling;
// using System.Collections.Generic;
// using System.Linq;
// using System.Runtime.InteropServices.Marshalling;
// using System.Text;
// using System.Threading.Tasks;
namespace DemoProject
{
    class Program
    {
        int i; bool b;
        static void main(string[]args)
        {
            Program p = new Program();
            Console.WriteLine(p.i);
             Console.WriteLine(p.b);

             Console.ReadLine();
        }
    }
}

// explicit constructors
// syntax- [<modifiers>] <name> ([<parameter list>])
/*
class ExplicitConDemo
{
   public ExplicitConDemo()
  [
    Console.WriteLine("Cons is called");
  ]
  static void main(){
  ExplicitConDemo obj=new ExplicitConDemo();
  Console.ReadLine();
  }
}
*/
