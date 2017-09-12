/************
* Example .net program. In Visual Studio Code, go to File -> Open Folder... and select vscode/codeExamples
* In the terminal, run "dotnet restore"
* With the C# extention installed, you can place breakpoints and use the debugger tool.
************/

using System;
namespace example3
{    
    class Program
    {
        static Random FUN = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello OKC#!");
            ICombatant c1 = PickCombatant();
            ICombatant c2;
            do { c2 = PickCombatant(); } while (c1.Name == c2.Name);

            var battleQueue = new[] { c1, c2 };

            Console.WriteLine($"{battleQueue[0].Name} VS {battleQueue[1].Name}");

            do
            {
                var dmg = (int)(Math.Max(1, battleQueue[0].AT * FUN.NextDouble() - battleQueue[1].DF / 2));
                dmg = Math.Min(dmg, battleQueue[1].HP);
                Console.WriteLine($"{battleQueue[0].Name} attacked for {dmg}.");
                battleQueue[1].HP -= dmg;
                battleQueue = new[] { battleQueue[1], battleQueue[0] };
            } while (battleQueue[0].HP > 0);

            Console.WriteLine($"{battleQueue[1].Name} was victorious!");
        }

        static ICombatant PickCombatant()
        {
            switch (FUN.Next(7))
            {
                case 0: return new Frisk();
                case 1: return new Chara();
                case 2: return new Undyne();
                case 3: return new Sans();
                case 4: return new Papyrus();
                case 5: return new Asgore();
                case 6: return new Toriel();
                default: return new WDGaster();
            }
        }
    }
}
