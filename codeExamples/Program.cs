/************
* Example .net program. In Visual Studio Code, go to File -> Open Folder... and select vscode/codeExamples
* In the terminal, run "dotnet restore"
* With the C# extention installed, you can place breakpoints and use the debugger tool.
************/

using System;
using codeExamples.AnonymousTypes;

namespace codeExamples
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello OKC#!");
            new AnonymousTypeExamples().Main();
            new AnonymousTypeExamples().UsingLegalAnonymousType();
            Console.ReadKey();
        }
    }
}
