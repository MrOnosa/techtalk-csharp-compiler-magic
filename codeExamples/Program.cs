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
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Type Examples");
            new AnonymousTypeExamples().Main();
            new AnonymousTypeExamples().UsingLegalAnonymousType();
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Lamda Expression Examples");
            new LambdaExample1().Example();
            new LambdaExample2().Example();
            new LambdaExample4().Example();
            Console.ReadKey();
        }
    }
}
