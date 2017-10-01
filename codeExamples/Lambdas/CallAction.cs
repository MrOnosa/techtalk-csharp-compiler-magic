using System;

namespace codeExamples.Lambdas
{
    /// <summary>
    /// This is a call to action.
    /// </summary>
    public class CallAction
    {
        public void Call(Action lamda)
        {
            lamda();
        }
    }
}