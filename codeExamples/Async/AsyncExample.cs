using System;
using System.Threading.Tasks;

namespace codeExamples.Async
{
    public class AsyncExample1
    {
        public async Task ExampleAsync()
        {
            var i = 1;
            var j = await Task.FromResult(i);
            i++;
            Console.WriteLine($"I: {i} | J: {j}");
        }
        public void Example()
        {
            var i = 1;
            var j = i;
            i++;
            Console.WriteLine($"I: {i} | J: {j}");
        }
    }
}

/*
// Decompiled with JetBrains decompiler
// Type: codeExamples.Async.AsyncExample1
// Assembly: codeExamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 58B33D89-FAA4-4E8A-AFD9-5056B53D8E48
// Assembly location: C:\Development\techtalk-csharp-compiler-magic\codeExamples\bin\Debug\netcoreapp2.0\codeExamples.dll
// Compiler-generated code is shown

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace codeExamples.Async
{
  public class AsyncExample1
  {
    public Task ExampleAsync()
    {
      AsyncExample1.<ExampleAsync>d__0 stateMachine = new AsyncExample1.<ExampleAsync>d__0();
      stateMachine.<>4__this = this;
      stateMachine.<>t__builder = AsyncTaskMethodBuilder.Create();
      stateMachine.<>1__state = -1;
      stateMachine.<>t__builder.Start<AsyncExample1.<ExampleAsync>d__0>(ref stateMachine);
      return stateMachine.<>t__builder.Task;
    }

    public void Example()
    {
      int num1 = 1;
      int num2 = num1;
      Console.WriteLine(string.Format("I: {0} | J: {1}", (object) (num1 + 1), (object) num2));
    }

    public AsyncExample1()
    {
      base..ctor();
    }

    [CompilerGenerated]
    private sealed class <ExampleAsync>d__0 : IAsyncStateMachine
    {
      public int <>1__state;
      public AsyncTaskMethodBuilder <>t__builder;
      public AsyncExample1 <>4__this;
      private int <i>5__1;
      private int <j>5__2;
      private int <>s__3;
      private TaskAwaiter<int> <>u__1;

      public <ExampleAsync>d__0()
      {
        base..ctor();
      }

      void IAsyncStateMachine.MoveNext()
      {
        int num1 = this.<>1__state;
        try
        {
          TaskAwaiter<int> awaiter;
          int num2;
          if (num1 != 0)
          {
            this.<i>5__1 = 1;
            awaiter = Task.FromResult<int>(this.<i>5__1).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              this.<>1__state = num2 = 0;
              this.<>u__1 = awaiter;
              AsyncExample1.<ExampleAsync>d__0 stateMachine = this;
              this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AsyncExample1.<ExampleAsync>d__0>(ref awaiter, ref stateMachine);
              return;
            }
          }
          else
          {
            awaiter = this.<>u__1;
            this.<>u__1 = new TaskAwaiter<int>();
            this.<>1__state = num2 = -1;
          }
          this.<>s__3 = awaiter.GetResult();
          this.<j>5__2 = this.<>s__3;
          ++this.<i>5__1;
          Console.WriteLine(string.Format("I: {0} | J: {1}", (object) this.<i>5__1, (object) this.<j>5__2));
        }
        catch (Exception ex)
        {
          this.<>1__state = -2;
          this.<>t__builder.SetException(ex);
          return;
        }
        this.<>1__state = -2;
        this.<>t__builder.SetResult();
      }

      [DebuggerHidden]
      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }
  }
}
 */