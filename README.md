# 🎯 C# Learning Journey — One Week Bootcamp

> **Start Date:** 20-05-2026  
> **Goal:** Learn C# from scratch in 7 days  
> **Status:** 🟡 In Progress

---

## 👤 About Me

| Field | Details |
|-------|---------|
| Name | Ritesh Mane |
| Background | BTech Grad. |
| Why C#? | App / Web Development |
| Daily Study Time | 2 hrs/day |

---

## 📊 Overall Progress

```
Day 1 ████████████████████ ✅
Day 2 ████████████████████ ✅
Day 3 ░░░░░░░░░░░░░░░░░░░░ ⏳
Day 4 ░░░░░░░░░░░░░░░░░░░░ ⏳
Day 5 ░░░░░░░░░░░░░░░░░░░░ ⏳
Day 6 ░░░░░░░░░░░░░░░░░░░░ ⏳
Day 7 ░░░░░░░░░░░░░░░░░░░░ ⏳
```

**[ 2 / 7 days completed ]**

---

## 🗓️ Weekly Plan

---

### ✅ Day 1 — Foundations & Setup
**Date:** 21-05-2026 | **Status:** ✅ Done

#### Topics Covered
- [x] Environment setup (VS Code + .NET SDK)
- [x] Structure of a C# program (`namespace`, `class`, `Main`)
- [x] Data types — `int`, `double`, `decimal`, `float`, `char`, `string`, `bool`
- [x] Variables and constants (`var`, `const`)
- [x] `Console.WriteLine` / `Console.Write` / `Console.ReadLine`
- [x] String interpolation (`$"..."`)
- [x] Type conversion — `Parse`, `TryParse`, casting, `Convert`

#### Exercises Completed
- [x] Exercise 1 — Personal Card (name, age, city) → 9/10 ⭐
- [x] Exercise 2 — Circle Calculator (area & circumference) → 7.5/10 ⭐
- [x] Exercise 3 — Temperature Converter (°C → °F) → 8.5/10 ⭐

#### Notes & Key Learnings
```
- Use decimal (not double) for money calculations
- var is still strongly typed — compiler infers the type
- TryParse is safer than Parse (won't crash on bad input)
- String interpolation $"" is cleaner than concatenation +
- Console.Write() keeps cursor on same line (use for input prompts)
- Console.WriteLine() moves cursor to next line (use for output)
- Console.ReadLine() reads full line as string — use 99% of the time
- Console.ReadKey() reads single keypress instantly (no Enter needed)
- Always use double not float for math calculations (more precise)
- Write 9.0/5 not 9/5 in formulas — makes decimal division explicit
- Always use {} curly braces even for single-line if/else blocks
- Use 'return' to exit program early on invalid input
- Missing $ before "" in interpolation = compile error (common mistake!)
- Always close every } — one for Main, one for class, one for namespace
```

#### Struggles / Questions
```
- VS Code Insert key was accidentally pressed → caused Overtype mode
  (letters were being replaced instead of inserted — fixed by pressing Insert once)
- Forgot 'using System;' at the top → Console not recognized error  
- Forgot $ in string interpolation → syntax error won't compile
- Missing closing } for namespace → took time to spot
- Debugging .cs file without project → only supported in .NET 10+
  (fixed by using: dotnet new console -n ProjectName)
- Typos in error messages: "nvalid", "Inalid", "temprature" → spell carefully!
```

---

### ✅ Day 2 — Operators, Conditions & Loops
**Date:** 22-05-2026 | **Status:** ✅ Done

#### Topics Covered
- [x] Arithmetic operators (`+`, `-`, `*`, `/`, `%`, `++`, `--`, `+=`)
- [x] Comparison operators (`==`, `!=`, `>`, `<`, `>=`, `<=`)
- [x] Logical operators (`&&`, `||`, `!`)
- [x] `if` / `else if` / `else`
- [x] Ternary operator (`? :`)
- [x] `switch` statement & `switch` expression
- [x] `for` loop
- [x] `while` loop
- [x] `do-while` loop
- [x] `break` and `continue`

#### Exercises Completed
- [x] Exercise 1 — Grade Calculator (if/else based on marks) → 7/10 ⭐
- [x] Exercise 2 — FizzBuzz (1–100, multiples of 3/5) → 9/10 ⭐
- [x] Exercise 3 — Multiplication Table (nested loops) → 5/10 ⭐
- [x] Exercise 4 — Number Guessing Game (while loop) → 6.5/10 ⭐
- **Day Average: 6.9/10**

#### Notes & Key Learnings
```
- Variable SCOPE — where you declare a variable decides where you can use it
- Variables declared inside a loop/if block die when that block ends
- int attempts = 0 must be OUTSIDE the loop to survive across iterations
- 'out int x' inside an if block = x is scoped to that if only (tricky!)
- while(true) + break = infinite loop pattern used in menus & game loops
- continue = skip current iteration and go to next
- do-while = always runs at least once — use for password prompts/menus
- Most specific condition FIRST in if/else (FizzBuzz: check %3&&%5 before %3)
- Loop counter: i=1 not i=0 for multiplication tables (saves useless zero row)
- i <= 10 is cleaner than i < 11 — write what you mean
- Prompt must be INSIDE the loop so it shows on every retry, not just once
- string[] args — only needed for command-line tools, skip it for now
- while(true) + break is used in real game loops and server listeners
- $"{i}" is unnecessary — Console.WriteLine(i) converts int automatically
- Use {value,width} in interpolation for aligned column output e.g. {i,2}
- Ternary ?: for simple one-line conditions — marks >= 40 ? "Pass" : "Fail"
```

#### Struggles / Questions
```
- guess never updated inside loop → program froze in infinite loop
  (fix: move Console.ReadLine() INSIDE the do-while block)
- attempts declared inside loop → reset to 0 every iteration + scope error
  (fix: always declare counter variables OUTSIDE the loop)
- 'out int marks' inside if → marks invisible outside the if block
  (fix: declare 'int marks = 0' before the loop, use 'out marks' without 'int')
- ConsoleWriteLine → missing dot between Console and WriteLine (typo)
- Loop started at i=0 → printed useless '5 x 0 = 0' row
- Prompt shown before loop → blank screen on invalid input retry
- Forgot to validate marks range 0-100 (bonus requirement missed)
- Forgot Pass/Fail print (part of exercise requirements)
- Unused string[] args in Main — habit to avoid
```

---

### ⏳ Day 3 — Methods, Arrays & Strings
**Date:** ___________ | **Status:** 🔲 Pending

#### Topics to Cover
- [ ] Defining and calling methods
- [ ] Parameters and return types
- [ ] Method overloading
- [ ] `out` and `ref` parameters
- [ ] Optional parameters & named arguments
- [ ] Single-dimension arrays
- [ ] Multi-dimensional arrays
- [ ] `foreach` loop
- [ ] Common string methods (`Trim`, `Split`, `Join`, `Substring`, `IndexOf`, `Replace`)
- [ ] `StringBuilder`

#### Exercises
- [ ] Calculator with methods (add, subtract, multiply, divide)
- [ ] Find max/min in an array without built-in methods
- [ ] Word counter — count words in a sentence
- [ ] Reverse a string

#### Notes & Key Learnings
```
- 
- 
- 
```

#### Struggles / Questions
```
- 
- 
```

---

### ⏳ Day 4 — OOP Part 1: Classes & Objects
**Date:** ___________ | **Status:** 🔲 Pending

#### Topics to Cover
- [ ] What is OOP? (4 pillars overview)
- [ ] Defining a class
- [ ] Fields and Properties (`get`, `set`, `auto-properties`)
- [ ] Constructors (default, parameterized)
- [ ] Creating objects (`new` keyword)
- [ ] `this` keyword
- [ ] Static vs instance members
- [ ] Access modifiers (`public`, `private`, `protected`, `internal`)

#### Exercises
- [ ] Create a `BankAccount` class (deposit, withdraw, balance)
- [ ] Create a `Student` class (name, grades, average)
- [ ] Create a `Rectangle` class (area, perimeter methods)

#### Notes & Key Learnings
```
- 
- 
- 
```

#### Struggles / Questions
```
- 
- 
```

---

### ⏳ Day 5 — OOP Part 2: Inheritance & Interfaces
**Date:** ___________ | **Status:** 🔲 Pending

#### Topics to Cover
- [ ] Inheritance (`:` syntax)
- [ ] `base` keyword
- [ ] Method overriding (`virtual` / `override`)
- [ ] Abstract classes and methods
- [ ] Interfaces (`interface`, `IComparable`, `IEnumerable`)
- [ ] Polymorphism
- [ ] Sealed classes

#### Exercises
- [ ] Animal hierarchy — `Animal` → `Dog`, `Cat`, `Bird`
- [ ] Shape hierarchy — `Shape` → `Circle`, `Rectangle`, `Triangle`
- [ ] Implement `IComparable` on a `Product` class

#### Notes & Key Learnings
```
- 
- 
- 
```

#### Struggles / Questions
```
- 
- 
```

---

### ⏳ Day 6 — Collections, Exceptions & Files
**Date:** ___________ | **Status:** 🔲 Pending

#### Topics to Cover
- [ ] `List<T>`
- [ ] `Dictionary<TKey, TValue>`
- [ ] `Queue<T>` and `Stack<T>`
- [ ] `HashSet<T>`
- [ ] `try` / `catch` / `finally`
- [ ] Custom exceptions
- [ ] `File.ReadAllText` / `File.WriteAllText`
- [ ] `StreamReader` / `StreamWriter`
- [ ] `using` statement for resource management

#### Exercises
- [ ] To-Do list app using `List<string>`
- [ ] Word frequency counter using `Dictionary`
- [ ] Safe file reader with exception handling
- [ ] Simple contact book (save/load from file)

#### Notes & Key Learnings
```
- 
- 
- 
```

#### Struggles / Questions
```
- 
- 
```

---

### ⏳ Day 7 — LINQ & Mini Project
**Date:** ___________ | **Status:** 🔲 Pending

#### Topics to Cover
- [ ] What is LINQ?
- [ ] `Where`, `Select`, `OrderBy`, `GroupBy`
- [ ] `First`, `FirstOrDefault`, `Any`, `All`, `Count`
- [ ] Method syntax vs Query syntax
- [ ] Lambda expressions `=>`
- [ ] `Func<>` and `Action<>` delegates (intro)
- [ ] Nullable types (`int?`, `string?`)
- [ ] Null coalescing (`??`, `?.`)

#### Mini Project Options (pick one)
- [ ] 🏦 **Banking Console App** — accounts, deposit, withdraw, transaction history
- [ ] 📚 **Library Manager** — add books, search, borrow/return
- [ ] 🛒 **Shopping Cart** — products, cart, total with discount
- [ ] 🎮 **Quiz Game** — 10 questions, score, timer

#### Mini Project: Chosen → `_______________________`

#### Notes & Key Learnings
```
- 
- 
- 
```

#### Struggles / Questions
```
- 
- 
```

---

## 📚 Resources

| Resource | Link | Type |
|----------|------|------|
| Microsoft C# Docs | https://learn.microsoft.com/en-us/dotnet/csharp/ | 📖 Official Docs |
| C# Yellow Book (Free PDF) | http://www.csharpcourse.com/ | 📕 Book |
| dotnetfiddle (online compiler) | https://dotnetfiddle.net/ | 🛠️ Tool |
| LeetCode (C# practice) | https://leetcode.com/ | 🏋️ Practice |
| CS50 on edX | https://cs50.harvard.edu/ | 🎓 Course |

---

## 💡 Daily Habit Tracker

| | Mon | Tue | Wed | Thu | Fri | Sat | Sun |
|-|-----|-----|-----|-----|-----|-----|-----|
| Studied | ⬜ | ⬜ | ⬜ | ✅ | ✅ | ⬜ | ⬜ |
| Exercises done | ⬜ | ⬜ | ⬜ | ✅ | ✅ | ⬜ | ⬜ |
| Notes written | ⬜ | ⬜ | ⬜ | ✅ | ✅ | ⬜ | ⬜ |

---

## 🏆 Milestone Badges

| Badge | Condition | Earned? |
|-------|-----------|---------|
| 🌱 First Program | Ran Hello World | ✅ |
| 🔢 Type Master | Mastered all data types | ✅ |
| 🛡️ Safe Parser | Used TryParse in all exercises | ✅ |
| 🔁 Loop Hero | Completed all loop exercises | ✅ |
| 🧱 OOP Initiate | Built first class & object | ⬜ |
| 🧬 Inheritor | Used inheritance successfully | ⬜ |
| 🗂️ Collector | Used List & Dictionary | ⬜ |
| ⚡ LINQ Ninja | Wrote 5+ LINQ queries | ⬜ |
| 🚀 Week Complete | Finished the mini project | ⬜ |

---

## 🔖 Code Snippets to Remember

```csharp
// String interpolation — ALWAYS use this over +
string msg = $"Hello, {name}! You are {age} years old.";

// Safe parse with early exit — Day 1 pattern
Console.Write("Enter age: ");
if (!int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine("Invalid input!");
    return;
}

// Write vs WriteLine
Console.Write("Enter name: ");       // cursor stays same line
Console.WriteLine("Hello!");         // cursor moves to next line

// ReadLine vs ReadKey
string input = Console.ReadLine();    // reads full line (use always)
ConsoleKeyInfo k = Console.ReadKey(); // reads single keypress instantly

// Decimal division — always write 9.0 not 9 in formulas
double F = (C * 9.0 / 5) + 32;

// while(true) + break — infinite loop pattern (menus, game loops)
int marks = 0;
while (true)
{
    Console.Write("Enter marks (0-100): ");
    if (!int.TryParse(Console.ReadLine(), out marks))
    {
        Console.WriteLine("Numbers only!");
        continue;    // skip, ask again
    }
    if (marks < 0 || marks > 100)
    {
        Console.WriteLine("Must be 0-100!");
        continue;
    }
    break;           // valid input — exit loop
}

// Ternary operator — one line if/else
string result = marks >= 40 ? "Pass ✅" : "Fail ❌";

// Column alignment in interpolation
Console.WriteLine($"{a} x {i,2} = {a * i,3}");  // right-aligns numbers

// do-while — runs at least once (password, menu)
string password;
do
{
    Console.Write("Enter password: ");
    password = Console.ReadLine();
} while (password != "secret123");

// FizzBuzz pattern — most specific condition FIRST
if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
else if (i % 3 == 0)           Console.WriteLine("Fizz");
else if (i % 5 == 0)           Console.WriteLine("Buzz");
else                           Console.WriteLine(i);

// Null coalescing (Day 7)
string result2 = name ?? "Unknown";

// LINQ basics (Day 7)
var adults = people.Where(p => p.Age >= 18).ToList();
```

---

## 🗒️ General Notes & Observations

```
Week started on: 21-05-2026

Things I found easy:
- Understanding data types (Day 1)
- String interpolation syntax (Day 1)
- Basic program structure (namespace → class → Main) (Day 1)
- FizzBuzz logic — got condition order right instinctively (Day 2)
- for loop structure and counting (Day 2)

Things I found hard:
- Remembering to close all curly braces (especially namespace) (Day 1)
- Remembering $ before "" in interpolation (Day 1)
- Setting up VS Code to run .cs files without a project (Day 1)
- Overtype mode in VS Code Insert key issue (Day 1)
- Variable scope — variables inside blocks die outside them (Day 2)
- 'out int x' inside if = x scoped to that if block only (Day 2)
- Remembering to update guess inside the loop (Day 2)
- Moving prompt inside loop for retry UX (Day 2)

What helped me the most:
- Code reviews after each exercise — catching bugs early
- TryParse pattern with 'return' for safe input handling
- Elite-mode review on multiplication table — learned column alignment

What I want to explore after this week:
- ASP.NET Core for web development
- Building desktop apps with .NET MAUI
```

---

## ✍️ Author

**Name:** Ritesh Mane  
**GitHub:** ritesh8308  
**Started:** 21/05/2026  

---

*"Every expert was once a beginner. Keep going, one day at a time."* 💪