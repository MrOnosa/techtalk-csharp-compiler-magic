/************
* Example .net program. In Visual Studio Code, go to File -> Open Folder... and select vscode/codeExamples
* In the terminal, run "dotnet restore"
* With the C# extention installed, you can place breakpoints and use the debugger tool.
************/

using System;
using codeExamples.AnonymousTypes;
using codeExamples.Lambdas;

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
            new AnonymousTypeExamples().Example2();
            Console.WriteLine();
            Console.WriteLine("Example 3");
            new AnonymousTypeExamples().UsingLegalAnonymousType();
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Lamda Expression Examples");
            Console.WriteLine("Example 1");
            new LambdaExample1().Example();
            Console.WriteLine();
            Console.WriteLine("Example 2");
            new LambdaExample2().Example();
            Console.WriteLine();
            Console.WriteLine("Example 3");
            new LambdaExample4().Example();
            Console.ReadKey();
        }
    }
}
