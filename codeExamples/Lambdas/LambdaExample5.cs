using System;

namespace codeExamples.Lambdas
{    
    public class LambdaExample5
    {
        public void Example()
        {
            int n = 42;
            new CallAction().Call(() => n=5);
            Console.WriteLine($"Calling a variable set from same scope: {n}");
        }
    }
}

/*
// Decompiled with JetBrains decompiler
// Type: codeExamples.Lambdas.LambdaExample5
// Assembly: codeExamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 202E645F-D7E9-41E5-8584-3AA9167C41DD
// Assembly location: C:\Development\techtalk-csharp-compiler-magic\codeExamples\bin\Debug\netcoreapp2.0\codeExamples.dll
// Compiler-generated code is shown

using System;
using System.Runtime.CompilerServices;

namespace codeExamples.Lambdas
{
  public class LambdaExample5
  {
    public void Example()
    {
      LambdaExample5.<>c__DisplayClass0_0 cDisplayClass00 = new LambdaExample5.<>c__DisplayClass0_0();
      cDisplayClass00.n = 42;
      // ISSUE: method pointer
      new CallAction().Call(new Action((object) cDisplayClass00, __methodptr(<Example>b__0)));
      Console.WriteLine(string.Format("Calling a variable set from same scope: {0}", (object) cDisplayClass00.n));
    }

    public LambdaExample5()
    {
      base..ctor();
    }

    [CompilerGenerated]
    private sealed class <>c__DisplayClass0_0
    {
      public int n;

      public <>c__DisplayClass0_0()
      {
        base.\u002Ector();
      }

      internal void <Example>b__0()
      {
        this.n = 5;
      }
    }
  }
}
*/
