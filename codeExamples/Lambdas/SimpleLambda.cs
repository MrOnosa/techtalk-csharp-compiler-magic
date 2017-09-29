using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codeExamples.Lambdas
{
    public class LambdaExample1
    {
        public void Example()
        {
            new CallLamda().Call(() => Console.WriteLine("Jeff"));
        }
    }
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

    public class LambdaExample3
    {
        public void Example()
        {
            //The compiler generated class for the lambda has both example 1 and 2's code!
            new CallLamda().Call(() => Console.WriteLine("Jeff"));

            int[] numbers = { 1, 2, 3 };
            var result = numbers.Aggregate(0, (left, right) => left + right);
            Console.WriteLine($"Aggregation equals {result}");
        }
    }

    public class LambdaExample4
    {
        public void Example()
        {
            int n = 42;
            new CallLamda().Call(() => Console.WriteLine($"Calling a variable set from another scope: {n}"));
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
