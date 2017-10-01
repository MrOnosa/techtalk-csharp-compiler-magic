using System;
using System.Linq;

namespace codeExamples.Lambdas
{
    public class LambdaExample2
    {
        public void Example()
        {
            int[] numbers = { 1, 2, 3 };
            //var result = numbers.Aggregate(0, AddMethod);
            var result = numbers.Aggregate(0, (left, right) => left + right);
            Console.WriteLine($"Aggregation equals {result}");
        }

        private int AddMethod(int left, int right)
        {
            return left + right;
        }
    }
}
/*
// Decompiled with JetBrains decompiler
// Type: codeExamples.Lambdas.LambdaExample2
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
  public class LambdaExample2
  {
    public void Example()
    {
      // ISSUE: method pointer
      Console.WriteLine(string.Format("Aggregation equals {0}", (object) ((IEnumerable<int>) new int[3]
      {
        1,
        2,
        3
      }).Aggregate<int, int>(0, LambdaExample2.<>c.<>9__0_0 ?? (LambdaExample2.<>c.<>9__0_0 = new Func<int, int, int>((object) LambdaExample2.<>c.<>9, __methodptr(<Example>b__0_0))))));
    }

    private int AddMethod(int left, int right)
    {
      return left + right;
    }

    public LambdaExample2()
    {
      base..ctor();
    }

    [CompilerGenerated]
    [Serializable]
    private sealed class <>c
    {
      public static readonly LambdaExample2.<>c <>9;
      public static Func<int, int, int> <>9__0_0;

      static <>c()
      {
        LambdaExample2.<>c.<>9 = new LambdaExample2.<>c();
      }

      public <>c()
      {
        base..ctor();
      }

      internal int <Example>b__0_0(int left, int right)
      {
        return left + right;
      }
    }
  }
}
*/
