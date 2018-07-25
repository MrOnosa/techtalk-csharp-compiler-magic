/************
* Example .net program. In Visual Studio Code, go to File -> Open Folder... and select vscode/codeExamples
* In the terminal, run "dotnet restore"
* With the C# extention installed, you can place breakpoints and use the debugger tool.
************/

using System;
using codeExamples.AnonymousTypes;
using codeExamples.Async;
using codeExamples.Lambdas;
using codeExamples.Sugar;

namespace codeExamples
{    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Type Examples");
            Console.WriteLine("Example 1");
            new AnonymousTypeExamples().Example1();
            Console.WriteLine();
            Console.WriteLine("Example 2");
            dynamic dynamic = new AnonymousTypeExamples().Example2();
            Console.WriteLine(dynamic.ID);
            Console.WriteLine(dynamic.Name);
            Console.WriteLine();
            Console.WriteLine("Example 3");
            new AnonymousTypeExamples().UsingLegalAnonymousType();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lamda Expression Examples");
            Console.WriteLine("Example 1");
            new LambdaExample1().Example();
            Console.WriteLine();
            Console.WriteLine("Example 2");
            new LambdaExample2().Example();
            Console.WriteLine();
            Console.WriteLine("Example 3");
            new LambdaExample3().Example();
            Console.WriteLine();
            Console.WriteLine("Example 4");
            new LambdaExample4().Example();
            Console.WriteLine();
            Console.WriteLine("Example 5");
            new LambdaExample5().Example();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Async Examples");
            Console.WriteLine("Example 1");
            new AsyncExample1().ExampleAsync().Wait();
            new AsyncExample1().Example();
            Console.WriteLine("Misc Examples");
            Console.WriteLine("Example 1");
            new Setter().Example();
        }
    }
}
