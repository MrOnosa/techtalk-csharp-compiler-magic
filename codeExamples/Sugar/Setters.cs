using System;

namespace codeExamples.Sugar
{    
    public class Setter
    {
        public RefGuid Version1 { get; } = new RefGuid();
        public RefGuid Version2 => new RefGuid();
        public void Example()
        {
            Console.WriteLine($"Initial value    : {Version1} {Version2}");
            Console.WriteLine($"Which one changed: {Version1} {Version2}"); //Version1 is the same. Version 2 is different.
        }
    }

    public class RefGuid
    {
        Guid value;
        public RefGuid()
        {
            value = Guid.NewGuid();
        }

        public override string ToString(){
            return value.ToString();
        }
    }
}

/*
// Decompiled with JetBrains decompiler
// Compiler-generated code is shown

namespace codeExamples.Sugar
{
  public class Setter
  {
    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly RefGuid <Version1>k__BackingField;

    public RefGuid Version1
    {
      get
      {
        return this.<Version1>k__BackingField;
      }
    }

    public RefGuid Version2
    {
      get
      {
        return new RefGuid();
      }
    }

    public void Example()
    {
      Console.WriteLine(string.Format("Initial value    : {0} {1}", (object) this.Version1, (object) this.Version2));
      Console.WriteLine(string.Format("Which one changed: {0} {1}", (object) this.Version1, (object) this.Version2));
    }

    public Setter()
    {
      this.<Version1>k__BackingField = new RefGuid();
      base..ctor();
    }
  }
} */