using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codeExamples.Lambdas
{
    public class SimpleLambda
    {
        public void Example()
        {
            //Action lamda = () => Console.WriteLine("Hello OKC#!");
            var callLamda = new CallLamda();
            callLamda.Call(() => Console.WriteLine("Hello OKC#!"));
            string fromOutsideTheScopeOfTheLamda = "Hello from a different scope";
            callLamda.Call(() => Console.WriteLine(fromOutsideTheScopeOfTheLamda));
            //int[] a = {1};
            //var c = 1;
            //var b = a.Select(x => x == c);
        }
    }

    public class CallLamda
    {
        public void Call(Action lamda)
        {
            lamda();
        }
    }
}
