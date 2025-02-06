// Access Specifiers: It's a special kind of modifiers using which we can 
//define the scope of a type and its members.

// - Private -->accesssed only within class
// - Internal-->accessible only within project
// -protected ---> these can ebe accessed only with child cllass and within class
// -protected internal----> if protected and internal is accible then pi is accessible
// -Public


// private, protected, protected internal cannot be used on classes , it only works with member functions
using System;
namespace Accesspecifer //namespace
{
    public class Program  //class
    {
        private void Test1()  //method
        {
            Console.WriteLine("Private Method");
        }
        internal void Test2()  //method
        {
            Console.WriteLine("Internal Method");
        }
        protected void Test3()  //method
        {
            Console.WriteLine("Protected Method");
        }
        protected internal void Test4()  //method
        {
            Console.WriteLine("protected internal Method");
        }
        public void Test5()  //method
        {
            Console.WriteLine("Public Method");
        }
    static void main(string[] args)
    {

    Program p =new Program();
    p.Test1();
    p.Test2();
    p.Test3();
    p.Test4();
    p.Test5();
    Console.ReadLine();


    }
    }

}