using System;
using System.Linq;

namespace codeExamples.Lambdas
{
    public class LambdaExample3
    {
        public void Example()
        {
            //The compiler generated class for the lambda has both example 1 and 2's code!
            new CallAction().Call(() => Console.WriteLine("Jeff"));

            int[] numbers = { 1, 2, 3 };
            var result = numbers.Aggregate(0, (left, right) => left + right);
            Console.WriteLine($"Aggregation equals {result}");
        }
    }
}
/*
// Decompiled with JetBrains decompiler
// Type: codeExamples.Lambdas.LambdaExample3
// Assembly: codeExamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A9C7109F-679C-4AD8-B652-2CD80BAA5CB2
// Assembly location: C:\Development\techtalk-csharp-compiler-magic\codeExamples\bin\Debug\netcoreapp2.0\codeExamples.dll
// Compiler-generated code is shown

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace codeExamples.Lambdas
{
  public class LambdaExample3
  {
    public void Example()
    {
      // ISSUE: method pointer
      new CallLamda().Call(LambdaExample3.<>c.<>9__0_0 ?? (LambdaExample3.<>c.<>9__0_0 = new Action((object) LambdaExample3.<>c.<>9, __methodptr(<Example>b__0_0))));
      // ISSUE: method pointer
      Console.WriteLine(string.Format("Aggregation equals {0}", (object) ((IEnumerable<int>) new int[3]
      {
        1,
        2,
        3
      }).Aggregate<int, int>(0, LambdaExample3.<>c.<>9__0_1 ?? (LambdaExample3.<>c.<>9__0_1 = new Func<int, int, int>((object) LambdaExample3.<>c.<>9, __methodptr(<Example>b__0_1))))));
    }

    public LambdaExample3()
    {
      base..ctor();
    }

    [CompilerGenerated]
    [Serializable]
    private sealed class <>c
    {
      public static readonly LambdaExample3.<>c <>9;
      public static Action <>9__0_0;
      public static Func<int, int, int> <>9__0_1;

      static <>c()
      {
        LambdaExample3.<>c.<>9 = new LambdaExample3.<>c();
      }

      public <>c()
      {
        base..ctor();
      }

      internal void <Example>b__0_0()
      {
        Console.WriteLine("Jeff");
      }

      internal int <Example>b__0_1(int left, int right)
      {
        return left + right;
      }
    }
  }
}
*/
