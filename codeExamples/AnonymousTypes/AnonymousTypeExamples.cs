using System;

namespace codeExamples.AnonymousTypes
{

    public class AnonymousTypeExamples
    {
        public void Example1()
        {
            var jeff = new { ID = 42, Name = "Jeff" }; //<>f__AnonymousType0`2
            Console.WriteLine(jeff);
        }

        /*
        // Decompiled with JetBrains decompiler
        // Type: codeExamples.AnonymousTypes.AnonymousTypeExamples
        // Assembly: codeExamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
        // MVID: A9C7109F-679C-4AD8-B652-2CD80BAA5CB2
        // Assembly location: C:\Development\techtalk-csharp-compiler-magic\codeExamples\bin\Debug\netcoreapp2.0\codeExamples.dll
        // Compiler-generated code is shown
        public void Example1()
        {
            var data = new <>f__AnonymousType0<int, string>(42, "Jeff");
            Console.WriteLine((object)data);
        }
        */

        public dynamic Example2()
        {
            int ID = 42;
            string Name = "Jeff";
            var myAnonymousObject2 = new { ID, Name }; //<>f__AnonymousType0`2
            Console.WriteLine(myAnonymousObject2);
            Console.WriteLine(new { ID = 42, Name = "Jeff" }.Equals(myAnonymousObject2));
            Console.WriteLine(new { Name = "Jeff", ID = 42 }.Equals(myAnonymousObject2));
            dynamic d = myAnonymousObject2;

            return d;
        }
        
        /*
        // Decompiled with JetBrains decompiler
        // Type: codeExamples.AnonymousTypes.AnonymousTypeExamples
        // Assembly: codeExamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
        // MVID: A9C7109F-679C-4AD8-B652-2CD80BAA5CB2
        // Assembly location: C:\Development\techtalk-csharp-compiler-magic\codeExamples\bin\Debug\netcoreapp2.0\codeExamples.dll
        // Compiler-generated code is shown
        public void Example2()
        {
            var data = new <>f__AnonymousType0<int, string>(42, "Jeff");
            Console.WriteLine((object)data);
            Console.WriteLine(new <>f__AnonymousType0<int, string>(42, "Jeff").Equals((object)data));
            Console.WriteLine(new <>f__AnonymousType1<string, int>("Jeff", 42).Equals((object)data));
        }
        */

        public void UsingLegalAnonymousType()
        {
            var myAnon = new f__AnonymousType0<int, string>(42, "Jeff");
            Console.WriteLine(new f__AnonymousType0<int, string>(42, "Jeff").Equals(myAnon));
        }

        //Nothing unexpected was generated for UsingLegalAnonymousType() becuase I used standard classes, not anonymous types.
    }
}
