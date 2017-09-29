# Compiler Magic
Presentation by Tyler Palesano  
[@TPalesano](https://twitter.com/TPalesano)

[github.com/MrOnosa/techtalk-csharp-compiler-magic](https://github.com/MrOnosa/techtalk-csharp-compiler-magic)

Note: Press `s`. `esc` to see map. Arrow keys to use slides. Get a PowerShell terminal running for Example 1

---

## Anonymous Types &
## Lambdas Expressions
## In C\# #

<!-- vvv

Test -->

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
```

Note: Inferred names. Equals, GetHashCode, and ToString generated. Order and property names matters.

---

```csharp
var jeff = new <>f__AnonymousType0<int, string>(42, "Jeff");
```

```csharp
internal sealed class <>f__AnonymousType0<<ID>j__TPar, <Name>j__TPar>
{
public <>f__AnonymousType0(<ID>j__TPar ID, <Name>j__TPar Name)
  {
    base..ctor();
    this.<ID>i__Field = ID;
    this.<Name>i__Field = Name;
  }
}
```

Note: Invalid Class name in C# but not CLR. Not shown: Fields, Equals, GetHashCode, and ToString.

---

# Thank you

* Twitter: [@TPalesano](https://twitter.com/TPalesano)
* Presentation: [github.com/MrOnosa/techtalk-csharp-compiler-magic](https://github.com/MrOnosa/techtalk-csharp-compiler-magic)
* Created using: [reveal.js](https://github.com/hakimel/reveal.js/)

Note: True Pacifist Route ending