# Compiler Magic
Presentation by Tyler Palesano  
[@TPalesano](https://twitter.com/TPalesano)

[github.com/MrOnosa/techtalk-csharp-compiler-magic](https://github.com/MrOnosa/techtalk-csharp-compiler-magic)

Note: Press `s`. `esc` to see map. Arrow keys to use slides. Get a PowerShell terminal running for Example 1

---

## Anonymous Types &
## Lambdas Expressions
## In C\# #

---

# Anonymous Types

>C#'s anonymous type feature allows you to automatically declare an immutable tuple type using a very simple and succinct syntax.

<small>Richter, Jeffrey. "Chapter 10 Properties" _CLR via C#_, 3rd ed., Microsoft Press, 2010, pp. 247.</small>

---

# Syntax

```csharp
var jeff = new {ID = 42, Name = "Jeff"};
```

---

# Syntax - Cont.

```csharp
int ID = 42;
string Name = "Jeff";
var jeff = new { ID, Name };
new {ID = 42, Name = "Jeff"}.Equals(jeff);//TRUE
new {Name = "Jeff", ID = 42}.Equals(jeff);//FALSE
Console.WriteLine(jeff);//{ ID = 42, Name = Jeff }
```

Note: Inferred names. Only 2 classes generated, not 3. Equals, GetHashCode, and ToString generated. Order and property names matters.

---

```csharp
var jeff = new <>f__AnonymousType0<int, string>(42, "Jeff");
```

```csharp
internal sealed class <>f__AnonymousType0<<ID>j__TPar, 
                                          <Name>j__TPar> {
public <>f__AnonymousType0(<ID>j__TPar ID, <Name>j__TPar Name) {
    base..ctor();
    this.<ID>i__Field = ID;
    this.<Name>i__Field = Name;
  }
}
```

<small>Decompiled with [JetBrains decompiler](https://www.jetbrains.com/decompiler/)</small>

Note: Invalid Class name in C# but not CLR. Not shown: Fields, Equals, GetHashCode, and ToString.

---

* Generated code for Anonymous Types is sophisticated
 * Reuses code
 * Equals
 * ToString
 * Invalid names prevents naming conflicts

---

# Lambdas Expressions
# =>

---

Without Lambdas...
```csharp
public void Example()
{
    int[] numbers = { 1,2,3 };
    var result = numbers.Aggregate(0, AddMethod);
    Console.WriteLine($"Aggregation equals {result}"); //6
}

private int AddMethod(int left, int right)
{
    return left + right;
}
```

Note: Press down

vvv

Alternatively...
```csharp
public void Example()
{
    int[] numbers = { 1, 2, 3 };
    Func<int, int, int> func = AddMethod;
    var result = numbers.Aggregate(0, func);
    Console.WriteLine($"Aggregation equals {result}"); //6
}

private int AddMethod(int left, int right)
{
    return left + right;
}
```

---

## Lambdas Expressions

```csharp
public void Aggregate()
{
  int[] numbers = { 1,2,3 };
  var result = numbers.Aggregate(0, (left,right) => left+right);
  Console.WriteLine($"Aggregation equals {result}"); //6
}
```

Note: No need for AddMethod. Terse.

---

What was generated?
```csharp
//This
(left,right) => left+right
```
```csharp
//Created this...
LambdaExample2.<>c.<>9__0_0 ?? //null-coalescing operator
  (LambdaExample2.<>c.<>9__0_0 = 
  new Func<int, int, int>((object) LambdaExample2.<>c.<>9, 
                          __methodptr(<Example>b__0_0)))
```

---

```csharp
[CompilerGenerated] 
[Serializable]
private sealed class <>c //Using illegal names again
{
  public static readonly LambdaExample2.<>c <>9;//Singleton
  public static Func<int, int, int> <>9__0_0; //field
  static <>c()  { //Static fields means longer lifetimes
    LambdaExample2.<>c.<>9 = new LambdaExample2.<>c(); 
  }
  public <>c() { base..ctor(); }
  internal int <Example>b__0_0(int left, int right)  {
    return left + right;
  }
}
```

Note: Created static classes with fields. Same Func<,,> signature. Longer lifetime for the Func<,,> field.

---

## Lambdas Expressions: Scopes

```csharp
int n = 42;
new CallLamda().Call(
  () => Console.WriteLine(n) //42
);
```
```csharp
public void Call(Action lamda) { lamda(); }
```

Note: A class is generated to call the lambda, so how does this work?

---

```csharp
LambdaExample4.<>c__DisplayClass0_0 cDisplayClass00 =
              new LambdaExample4.<>c__DisplayClass0_0();
cDisplayClass00.n = 42; //Fixes scoping issue!
new CallLamda()
    .Call(new Action((object) cDisplayClass00, 
          __methodptr(<Example>b__0)));
```

```csharp
private sealed class <>c__DisplayClass0_0 {
  public int n; 
  internal void <Example>b__0() {
    Console.WriteLine(this.n);
  }
}
```

---

## Lambdas Expressions:
## Scopes Cont.

```csharp
int n = 42;
new CallAction().Call(() => n=5);
Console.WriteLine(n); //5
```
```csharp
public void Call(Action lamda) { lamda(); }
```

Note: Why was 5 written instead of 42?

---

```csharp
LambdaExample5.<>c__DisplayClass0_0 cDisplayClass00 = 
              new LambdaExample5.<>c__DisplayClass0_0();
cDisplayClass00.n = 42;
new CallAction().Call(new Action((object) cDisplayClass00, 
                      __methodptr(<Example>b__0)));
//Not n, but cDisplayClass00.n
Console.WriteLine(cDisplayClass00.n);
```

---

* Generated code for Lambda Expressions are sophisticated
 * Reuses code
 * Combines classes for Lambdas 
   * See LambdaExample3 on [GitHub](https://github.com/MrOnosa/techtalk-csharp-compiler-magic) 
 * Handles scoping

---

# Thank you

* Twitter: [@TPalesano](https://twitter.com/TPalesano)
* Presentation: [github.com/MrOnosa/techtalk-csharp-compiler-magic](https://github.com/MrOnosa/techtalk-csharp-compiler-magic)
* Created using: [reveal.js](https://github.com/hakimel/reveal.js/)

Note: True Pacifist Route ending