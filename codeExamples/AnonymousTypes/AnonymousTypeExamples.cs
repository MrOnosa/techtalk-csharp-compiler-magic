using System;

namespace codeExamples.AnonymousTypes
{
    public class AnonymousTypeExamples
    {
        public void Main()
        {
            //<>f__AnonymousType0`2
            var myAnonymousObject = new {ID = 42, Name = "Jeff"};
            Console.WriteLine(myAnonymousObject);

            //<>f__AnonymousType0`2
            int ID = 42;
            string Name = "Jeff";
            var myAnonymousObject2 = new { ID, Name };
            Console.WriteLine(myAnonymousObject2);
            Console.WriteLine(new { ID = 42, Name = "Jeff" }.Equals(myAnonymousObject2));
            Console.WriteLine(new { Name = "Jeff", ID = 42 }.Equals(myAnonymousObject2));
        }

        public void UsingLegalAnonymousType()
        {
            var myAnon = new f__AnonymousType0<int, string>(42, "Jeff");
            Console.WriteLine(new f__AnonymousType0<int, string>(42, "Jeff").Equals(myAnon));
        }
    }
}
