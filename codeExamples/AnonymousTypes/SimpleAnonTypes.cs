using System;

namespace codeExamples.AnonymousTypes
{
    public class SimpleAnonTypes
    {
        public void Main()
        {
            //<>f__AnonymousType0`2
            var myAnonymousClass = new {MyNumber = 42, MyString = "Hello"};
            Console.WriteLine(myAnonymousClass);

            //<>f__AnonymousType0`2
            var myAnonymousClass2 = new { MyNumber = 24, MyString = "olleH" };
            Console.WriteLine(myAnonymousClass2);

            //<>f__AnonymousType1`1
            var myDifferentAnonymousClass = new { MyDouble = 2.4 };
            Console.WriteLine(myDifferentAnonymousClass);

            var similarType = new SimilarType{MyNumber = 42, MyString = "Hello"};
            Console.WriteLine(similarType);
        }
    }

    public class SimilarType
    {
        public int MyNumber { get; set; }
        public string MyString { get; set; }
    }
}
