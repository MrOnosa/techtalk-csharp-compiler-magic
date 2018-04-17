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
      AsyncExample1.\u003CExampleAsync\u003Ed__0 stateMachine = new AsyncExample1.\u003CExampleAsync\u003Ed__0();
      stateMachine.\u003C\u003E4__this = this;
      stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
      stateMachine.\u003C\u003E1__state = -1;
      stateMachine.\u003C\u003Et__builder.Start<AsyncExample1.\u003CExampleAsync\u003Ed__0>(ref stateMachine);
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    public void Example()
    {
      int num1 = 1;
      int num2 = num1;
      Console.WriteLine(string.Format("I: {0} | J: {1}", (object) (num1 + 1), (object) num2));
    }

    public AsyncExample1()
    {
      base.\u002Ector();
    }

    [CompilerGenerated]
    private sealed class \u003CExampleAsync\u003Ed__0 : IAsyncStateMachine
    {
      public int \u003C\u003E1__state;
      public AsyncTaskMethodBuilder \u003C\u003Et__builder;
      public AsyncExample1 \u003C\u003E4__this;
      private int \u003Ci\u003E5__1;
      private int \u003Cj\u003E5__2;
      private int \u003C\u003Es__3;
      private TaskAwaiter<int> \u003C\u003Eu__1;

      public \u003CExampleAsync\u003Ed__0()
      {
        base.\u002Ector();
      }

      void IAsyncStateMachine.MoveNext()
      {
        int num1 = this.\u003C\u003E1__state;
        try
        {
          TaskAwaiter<int> awaiter;
          int num2;
          if (num1 != 0)
          {
            this.\u003Ci\u003E5__1 = 1;
            awaiter = Task.FromResult<int>(this.\u003Ci\u003E5__1).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
              this.\u003C\u003E1__state = num2 = 0;
              this.\u003C\u003Eu__1 = awaiter;
              AsyncExample1.\u003CExampleAsync\u003Ed__0 stateMachine = this;
              this.\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AsyncExample1.\u003CExampleAsync\u003Ed__0>(ref awaiter, ref stateMachine);
              return;
            }
          }
          else
          {
            awaiter = this.\u003C\u003Eu__1;
            this.\u003C\u003Eu__1 = new TaskAwaiter<int>();
            this.\u003C\u003E1__state = num2 = -1;
          }
          this.\u003C\u003Es__3 = awaiter.GetResult();
          this.\u003Cj\u003E5__2 = this.\u003C\u003Es__3;
          ++this.\u003Ci\u003E5__1;
          Console.WriteLine(string.Format("I: {0} | J: {1}", (object) this.\u003Ci\u003E5__1, (object) this.\u003Cj\u003E5__2));
        }
        catch (Exception ex)
        {
          this.\u003C\u003E1__state = -2;
          this.\u003C\u003Et__builder.SetException(ex);
          return;
        }
        this.\u003C\u003E1__state = -2;
        this.\u003C\u003Et__builder.SetResult();
      }

      [DebuggerHidden]
      void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
      {
      }
    }
  }
}
 */