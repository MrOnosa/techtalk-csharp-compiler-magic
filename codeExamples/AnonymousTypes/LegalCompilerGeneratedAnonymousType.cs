// I used DotPeek 2017.2 to see the compiler generated code for this anonymous type. I then made it use legal syntax for C#. I left out the .ToString method.
// The originally compiler generated code is shown at the end of this file.
namespace codeExamples.AnonymousTypes
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [CompilerGenerated]
    [DebuggerDisplay("\\{ ID = {ID}, Name = {Name} }", Type = "<Anonymous Type>")]
    internal sealed class f__AnonymousType0<ID_j_TPar, Name_j_TPar>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ID_j_TPar ID_i__Field;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Name_j_TPar Name_i__Field;

        public ID_j_TPar ID
        {
            get
            {
                return this.ID_i__Field;
            }
        }

        public Name_j_TPar Name
        {
            get
            {
                return this.Name_i__Field;
            }
        }

        [DebuggerHidden]
        public f__AnonymousType0(ID_j_TPar ID, Name_j_TPar Name)
        {
            //base..ctor();
            this.ID_i__Field = ID;
            this.Name_i__Field = Name;
        }

        [DebuggerHidden]
        public override bool Equals(object value)
        {
            var data = value as f__AnonymousType0<ID_j_TPar, Name_j_TPar>;
            if (data != null && EqualityComparer<ID_j_TPar>.Default.Equals(this.ID_i__Field, data.ID_i__Field))
                return EqualityComparer<Name_j_TPar>.Default.Equals(this.Name_i__Field, data.Name_i__Field);
            return false;
        }

        [DebuggerHidden]
        public override int GetHashCode()
        {
            return (unchecked(1870403278 * -1521134295) + EqualityComparer<ID_j_TPar>.Default.GetHashCode(this.ID_i__Field)) * -1521134295 + EqualityComparer<Name_j_TPar>.Default.GetHashCode(this.Name_i__Field);
        }
    }
}

/*
// Decompiled with JetBrains decompiler
// Type: <>f__AnonymousType0`2
// Assembly: codeExamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B41CC73E-98E3-4D43-AE44-B9A50A80571D
// Assembly location: C:\Development\techtalk-csharp-compiler-magic\codeExamples\bin\Debug\netcoreapp2.0\codeExamples.dll
// Compiler-generated code is shown

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
[DebuggerDisplay("\\{ ID = {ID}, Name = {Name} }", Type = "<Anonymous Type>")]
internal sealed class <>f__AnonymousType0<<ID>j__TPar, <Name>j__TPar>
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly <ID>j__TPar <ID>i__Field;
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly <Name>j__TPar <Name>i__Field;

  public <ID>j__TPar ID
  {
    get
    {
      return this.<ID>i__Field;
    }
  }

  public <Name>j__TPar Name
  {
    get
    {
      return this.<Name>i__Field;
    }
  }

  [DebuggerHidden]
  public <>f__AnonymousType0(<ID>j__TPar ID, <Name>j__TPar Name)
  {
    base..ctor();
    this.<ID>i__Field = ID;
    this.<Name>i__Field = Name;
  }

  [DebuggerHidden]
  public override bool Equals(object value)
  {
    var data = value as <>f__AnonymousType0<<ID>j__TPar, <Name>j__TPar>;
    if (data != null && EqualityComparer<<ID>j__TPar>.Default.Equals(this.<ID>i__Field, data.<ID>i__Field))
      return EqualityComparer<<Name>j__TPar>.Default.Equals(this.<Name>i__Field, data.<Name>i__Field);
    return false;
  }

  [DebuggerHidden]
  public override int GetHashCode()
  {
    return (1870403278 * -1521134295 + EqualityComparer<<ID>j__TPar>.Default.GetHashCode(this.<ID>i__Field)) * -1521134295 + EqualityComparer<<Name>j__TPar>.Default.GetHashCode(this.<Name>i__Field);
  }

  [DebuggerHidden]
  public override string ToString()
  {
    // ISSUE: variable of the null type
    __Null local1 = null;
    string format = "{{ ID = {0}, Name = {1} }}";
    object[] objArray = new object[2];
    int index1 = 0;
    <ID>j__TPar idIField = this.<ID>i__Field;
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    <ID>j__TPar& local2 = @idIField;
    string str1;
    if ((object) default (<ID>j__TPar) == null)
    {
      // ISSUE: explicit reference operation
      <ID>j__TPar idJTpar = ^local2;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      <ID>j__TPar& local3 = @idJTpar;
      if ((object) idJTpar == null)
      {
        str1 = (string) null;
        goto label_4;
      }
      else
        local2 = local3;
    }
    // ISSUE: explicit reference operation
    str1 = (^local2).ToString();
label_4:
    objArray[index1] = (object) str1;
    int index2 = 1;
    <Name>j__TPar nameIField = this.<Name>i__Field;
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    <Name>j__TPar& local4 = @nameIField;
    string str2;
    if ((object) default (<Name>j__TPar) == null)
    {
      // ISSUE: explicit reference operation
      <Name>j__TPar nameJTpar = ^local4;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      <Name>j__TPar& local3 = @nameJTpar;
      if ((object) nameJTpar == null)
      {
        str2 = (string) null;
        goto label_8;
      }
      else
        local4 = local3;
    }
    // ISSUE: explicit reference operation
    str2 = (^local4).ToString();
label_8:
    objArray[index2] = (object) str2;
    return string.Format((IFormatProvider) local1, format, objArray);
  }
}
*/