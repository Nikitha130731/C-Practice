// See https://aka.ms/new-console-template for more information
using HelloWorldTutorial;

Console.WriteLine("Hello, World!");
Console.WriteLine("DateTime is " +DateTime.Now);

// basic operations

int a=5;
int b=10;
int c= a+b;
Console.WriteLine(c);

// Type conversion

// implicit conversions

// int num = 567657645;
// long bigNum = num;
// Console.WriteLine(bigNum);

// //Explicit conversions
// double x =2345.98;
// int ans;
// ans=(int)x;
// Console.WriteLine(ans);

// // string to int
// string val ="hjkn";
// int result ;
// if(int.TryParse(val, out result))
// {
//    Console.WriteLine("Success "+result); 
// }
// else{
//     Console.WriteLine("failure "); 
// }
StackHeapExample stackHeap = new StackHeapExample();
stackHeap.AddFive(1);


