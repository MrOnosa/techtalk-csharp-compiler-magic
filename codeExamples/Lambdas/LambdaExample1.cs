using System;

namespace codeExamples.Lambdas
{
    public class LambdaExample1
    {
        public void Example()
        {
            new CallAction().Call(() => Console.WriteLine("Jeff"));
        }
    }
}

/*
// Decompiled with JetBrains decompiler
// Type: codeExamples.Lambdas.LambdaExample1
// Assembly: codeExamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A9C7109F-679C-4AD8-B652-2CD80BAA5CB2
// Assembly location: C:\Development\techtalk-csharp-compiler-magic\codeExamples\bin\Debug\netcoreapp2.0\codeExamples.dll
// Compiler-generated code is shown

using System;
using System.Runtime.CompilerServices;

namespace codeExamples.Lambdas
{
  public class LambdaExample1
  {
    public void Example()
    {
      // ISSUE: method pointer
      new CallLamda().Call(LambdaExample1.<>c.<>9__0_0 ?? (LambdaExample1.<>c.<>9__0_0 = new Action((object) LambdaExample1.<>c.<>9, __methodptr(<Example>b__0_0))));
    }

    public LambdaExample1()
    {
      base..ctor();
    }

    [CompilerGenerated]
    [Serializable]
    private sealed class <>c
    {
      public static readonly LambdaExample1.<>c <>9;
      public static Action <>9__0_0;

      static <>c()
      {
        LambdaExample1.<>c.<>9 = new LambdaExample1.<>c();
      }

      public <>c()
      {
        base..ctor();
      }

      internal void <Example>b__0_0()
      {
        Console.WriteLine("Jeff");
      }
    }
  }
}
*/
