using System;

namespace codeExamples.Lambdas
{
    public class LambdaExample4
    {
        public void Example()
        {
            int n = 42;
            new CallAction().Call(() => Console.WriteLine($"Calling a variable set from another scope: {n}"));
        }
    }
}

/*
// Decompiled with JetBrains decompiler
// Type: codeExamples.Lambdas.LambdaExample4
// Assembly: codeExamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A9C7109F-679C-4AD8-B652-2CD80BAA5CB2
// Assembly location: C:\Development\techtalk-csharp-compiler-magic\codeExamples\bin\Debug\netcoreapp2.0\codeExamples.dll
// Compiler-generated code is shown

using System;
using System.Runtime.CompilerServices;

namespace codeExamples.Lambdas
{
  public class LambdaExample4
  {
    public void Example()
    {
      LambdaExample4.<>c__DisplayClass0_0 cDisplayClass00 = new LambdaExample4.<>c__DisplayClass0_0();
      cDisplayClass00.n = 42;
      // ISSUE: method pointer
      new CallLamda().Call(new Action((object) cDisplayClass00, __methodptr(<Example>b__0)));
    }

    public LambdaExample4()
    {
      base..ctor();
    }

    [CompilerGenerated]
    private sealed class <>c__DisplayClass0_0
    {
      public int n;

      public <>c__DisplayClass0_0()
      {
        base..ctor();
      }

      internal void <Example>b__0()
      {
        Console.WriteLine(string.Format("Calling a variable set from another scope: {0}", (object) this.n));
      }
    }
  }
}
*/
