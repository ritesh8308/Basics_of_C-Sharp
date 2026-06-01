# 🎯 C# Learning Journey — One Week Bootcamp

> **Start Date:** 21-05-2026  
> **Goal:** Learn C# from scratch in 7 days  
> **Status:** ✅ COMPLETED — All 7 Days Done!

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
Day 3 ████████████████████ ✅
Day 4 ████████████████████ ✅
Day 5 ████████████████████ ✅
Day 6 ████████████████████ ✅
Day 7 ████████████████████ ✅
```

**[ 7 / 7 days completed ]** 🎉

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

### ✅ Day 3 — Methods, Arrays & Strings
**Date:** 23-05-2026 | **Status:** ✅ Done

#### Topics Covered
- [x] Defining and calling methods
- [x] Parameters and return types
- [x] Method overloading
- [x] `out` and `ref` parameters
- [x] Optional parameters & named arguments
- [x] Single-dimension arrays
- [x] Multi-dimensional arrays
- [x] `foreach` loop
- [x] Common string methods (`Trim`, `Split`, `Join`, `Substring`, `IndexOf`, `Replace`)
- [x] `StringBuilder`

#### Exercises Completed
- [x] Exercise 1 — Calculator with Methods → 4.5/10 ⭐
- [x] Exercise 2 — Find Max/Min in Array → 5.5/10 ⭐
- [x] Exercise 3 — Word Counter (guided solution) → 📖 Learned
- [x] Exercise 4 — Reverse String & Palindrome → 7/10 ⭐
- **Day Average: 5.7/10**

#### Notes & Key Learnings
```
- void methods CANNOT return a value — return type and void are mutually exclusive
- out and return are two roads to same destination — never mix them
- out parameter = must be assigned before method exits (compiler enforces this)
- return type method = use when returning ONE value — cleaner and simpler
- out parameter = use when returning MULTIPLE values from one method
- int.MinValue and int.MaxValue are PROPERTIES not methods — no () needed
- Always use arr.Length not hardcoded numbers — works for any array size
- Array index starts at 0 — last element is arr[arr.Length - 1]
- s[i] accesses a single character at position i in a string
- foreach (char c in string) loops through every character in a string
- sentence.Split(' ') breaks sentence into string[] array by space separator
- char comparison uses single quotes: c == 'a' not c == "a"
- string.IsNullOrWhiteSpace() — always guard against empty input
- StringComparison.OrdinalIgnoreCase — compare strings ignoring case
- StringBuilder — use when building strings in loops (faster than + operator)
- new StringBuilder() not new StringBuidler() — easy typo to make
- Loop backwards for reverse: for (int i = s.Length - 1; i >= 0; i--)
- Dictionary<string, int> for word frequency — key=word, value=count
- Class names must be PascalCase with NO underscores — Max_Min_of_Array ❌ ArrayAnalyzer ✅
- double.NaN — return this when division by zero, means "Not a Number"
- string.Join(" - ", array) — joins array elements with separator
```

#### Struggles / Questions
```
- Mixed void + out + return in Calculator — void can't return a value!
  (fix: use 'static double MethodName()' with return, drop out entirely)
- double a = Console.ReadLine() — type mismatch, ReadLine returns string
  (fix: always use double.TryParse like Day 1 & 2)
- Math.int.minValue() — completely wrong syntax
  (fix: int.MinValue — it's a property, no Math, no (), capital M and V)
- Wrong TryParse syntax — missing 'int.' prefix and comma before 'out'
  (fix: int.TryParse(Console.ReadLine(), out int a))
- FindMin loop used i < 4 — missed the last element at index 4
  (fix: always use i < arr.Length not a hardcoded number)
- Copy-paste error: both output lines said "Max value" — missed Min label
- StringBuilder typo: StringBuidler → StringBuilder
- Word Counter — Split(' ') trick was the missing piece
  (once Split was understood, rest of the exercise clicked immediately)
- Char vs string comparison: c == "a" fails, must use c == 'a' single quotes
- Gave up on Word Counter initially — broke it into steps and solved it
```

---

### ✅ Day 4 — OOP Part 1: Classes & Objects
**Date:** 24-05-2026 | **Status:** ✅ Done

#### Topics Covered
- [x] What is OOP? (4 pillars overview — Encapsulation, Inheritance, Polymorphism, Abstraction)
- [x] Defining a class
- [x] Fields and Properties (`get`, `set`, `auto-properties`)
- [x] Constructors (default vs parameterized)
- [x] Creating objects (`new` keyword)
- [x] `this` keyword
- [x] Static vs instance members
- [x] Access modifiers (`public`, `private`, `protected`, `internal`)

#### Exercises Completed
- [x] Exercise 1 — BankAccount class (Deposit, Withdraw, Balance) → 6/10 ⭐
- [x] Exercise 2 — Student class (Grades, Average, GradeLetter) → 6.5/10 ⭐
- [x] Exercise 3 — Rectangle class (Area, Perimeter, IsSquare) → 9.5/10 ⭐
- **Day Average: 7.3/10**

#### Notes & Key Learnings
```
- Class = blueprint, Object = instance created from the blueprint
- Constructor name MUST match class name — enforced by compiler
- File name SHOULD match class name — convention only (unlike Java)
- Default constructor = no parameters, Parameterized = takes arguments
- private fields — only the class itself can access them
- public properties — controlled access from outside via get/set
- Auto-property: public string Name { get; set; } — shorthand
- private set: public int Count { get; private set; } — read from outside, set only inside
- 'this' keyword = refers to current object instance
- Static member = ONE copy shared across ALL objects — access via ClassName.Member
- Instance member = each object has its OWN copy — access via object.Member
- TotalTransactions++ in constructor = wrong — fires on creation not transaction
- TotalTransactions should be instance not static — each account tracks its own
- Withdraw should be void not double — no value to return
- Class fields accessible to all methods — no need to pass them as parameters!
- double.MinValue / double.MaxValue — same pattern as int.MinValue
- == is comparison, = is assignment — High == g is a bug, High = g is correct
- :F2 format specifier — shows exactly 2 decimal places
- {"Label:",-12} — left-aligns label in 12-char field for neat output
- Calculate expensive values once, store in variable, reuse — don't call twice
- Ternary in interpolation: {(IsSquare() ? "Yes ✅" : "No ❌")}
- Negative value rejection in constructor: Width = width < 0 ? 0 : width
- static Compare(r1, r2) — utility method that doesn't belong to one object
- Writing code yourself > asking for final code — Rectangle 9.5 proves it
```

#### Struggles / Questions
```
- TotalTransactions++ placed in constructor — fires on account creation not transaction
  (fix: move TotalTransactions++ inside Deposit() and Withdraw())
- Withdraw declared as double but returns nothing — compile error
  (fix: use void — Withdraw doesn't need to return a value)
- new BankAccount() — forgot to pass owner name to constructor
  (fix: new BankAccount("Ritesh") — constructor requires the argument)
- Console.WriteLine(PrintStatement()) — void method returns nothing to print
  (fix: just call b1.PrintStatement() directly)
- Missing semicolon after Deposit() call
- TotalTransactions as static — all accounts shared one counter
  (fix: instance variable — each account tracks its own transactions)
- GetAverage(double[] Grades) — unnecessary parameter, class already has Grades
  (fix: public double GetAverage() — use class field directly)
- Grades.length → Grades.Length — capital L always
- double.Min-Val → double.MinValue — hyphen is subtraction not part of name
- High == g instead of High = g — comparison vs assignment (classic bug)
- IsPassing(double GetAverage(Grades)) — invalid syntax for parameter
  (fix: public bool IsPassing() — no parameter, call GetAverage() inside)
- PrintReport() left empty with blank Console.WriteLines
- Missing $ in string interpolation — "{Name}" instead of $"{Name}"
- "Default Constructor" comment on parameterized constructor — misleading
```

---

### ✅ Day 5 — OOP Part 2: Inheritance & Interfaces
**Date:** 25-05-2026 | **Status:** ✅ Done

#### Topics Covered
- [x] Inheritance (`:` syntax)
- [x] `base` keyword — calling parent constructor
- [x] Method overriding (`virtual` / `override`)
- [x] Abstract classes and abstract methods
- [x] Interfaces — contract vs implementation
- [x] Field vs Property in interfaces
- [x] Polymorphism — same method, different behavior
- [x] `IComparable<T>` — sorting with CompareTo()
- [x] Pattern matching — `if (a is Dog dog)`
- [x] Sealed classes
- [x] `GetType().Name` — gets class name at runtime

#### Exercises Completed
- [x] Exercise 1 — Animal Hierarchy (Dog, Cat, Bird) → 6.5/10 ⭐
- [x] Exercise 2 — Shape Hierarchy (Circle, Rectangle, Triangle) → 6/10 ⭐
- [x] Exercise 3 — Product Interface + IComparable → 📖 Guided
- **Day Average: 6.3/10**

#### Notes & Key Learnings
```
- Inheritance syntax: class Dog : Animal  (colon = inherits from)
- base() = calls parent constructor — always needed when parent has params
- virtual = parent says "child CAN override me"
- override = child says "I AM replacing parent's version"
- abstract method = NO body in parent — child MUST implement it
- abstract class = cannot create object directly — only used as base
- new Shape() → compile error — abstract class can never be instantiated
- Interface = pure contract — no implementation, no fields, no constructor
- Interface CAN have property signatures — string Name { get; } is a property not a field
- Field vs Property: string name; = field ❌ | string Name { get; } = property ✅
- A class can inherit ONE parent but implement MULTIPLE interfaces
- IComparable<T> = built-in interface for sorting — implement CompareTo()
- CompareTo() returns: negative = comes first, 0 = equal, positive = comes last
- Array.Sort(array) uses CompareTo() automatically after implementing IComparable
- Polymorphism = Animal[] holds Dog, Cat, Bird — a.Speak() calls correct version
- Pattern matching: if (a is Dog dog) — checks type AND creates variable in one line
- GetType().Name — returns "Circle", "Rectangle" etc. at runtime — very elegant!
- Class members are PRIVATE by default — always write public explicitly
- static methods CANNOT access instance members like Name, Age
- Heron's formula: s = (a+b+c)/2, area = Math.Sqrt(s*(s-a)*(s-b)*(s-c))
- ** is Python syntax — C# uses Math.Sqrt() and Math.Pow()
- base.Speak() inside override = calls parent version first, then adds more
- Sealed class = no further inheritance allowed
```

#### Struggles / Questions
```
- Name and Age missing public in Animal → child classes couldn't see them
  (fix: always explicitly write public on properties in base class)
- Fetch(), Purr(), Fly() declared static → can't access instance member Name
  (fix: instance methods not static — static belongs to class not object)
- Cat → Fetch() instead of Purr(), Bird → Fetch() instead of Fly() — copy-paste
- new bird() lowercase → compile error (Bird not bird)
- Rectangle constructor typo: Reactanlge + base(string color) wrong syntax
  (fix: base(color) — just pass value, never the type keyword)
- Triangle typo: Traingle — misspelled class and constructor name
- A = A self-assignment in Triangle constructor — property assigned to itself
  (fix: A = a — uppercase property, lowercase parameter)
- s calculated as class field → always 0 because A,B,C not set yet
  (fix: calculate s INSIDE GetArea() method after values are assigned)
- ** operator doesn't exist in C# → use Math.Sqrt() for Heron's formula
- Triangle missing GetPerimeter() entirely → abstract method not implemented
- Comment left as code in Main → syntax error
- Interface concept for IComparable — needed guided walkthrough
```

---

### ✅ Day 6 — Collections, Exceptions & Files
**Date:** 26-05-2026 | **Status:** ✅ Done

#### Topics Covered
- [x] `List<T>` — dynamic array, Add/Insert/Remove/Contains
- [x] `Dictionary<TKey, TValue>` — key-value pairs, TryGetValue
- [x] `Queue<T>` (FIFO) and `Stack<T>` (LIFO)
- [x] `HashSet<T>` — no duplicates
- [x] `try` / `catch` / `finally`
- [x] Custom exceptions
- [x] `File.ReadAllText` / `File.WriteAllText` / `File.ReadAllLines`
- [x] `StreamReader` / `StreamWriter`
- [x] `using` statement for resource management

#### Exercises Completed
- [x] Exercise 1 — To-Do List App (List + menu) → 9/10 ⭐
- [x] Exercise 2 — Word Frequency Counter (Dictionary + LINQ) → 9.5/10 ⭐
- [x] Exercise 3 — Safe File Reader (try/catch + File I/O) → 8.5/10 ⭐
- [x] Exercise 4 — Contact Book (Dictionary + save/load) → 📖 Guided
- **Day Average: 9/10 🔥 (best day!)**

#### Notes & Key Learnings
```
- List<T> = dynamic array — grows automatically, .Add() .Remove() .RemoveAt()
- List.Count not .Length — Length is for arrays, Count is for collections
- Dictionary<K,V> = key-value pairs — scores["Ritesh"] = 95
- TryGetValue(key, out value) = safe read, won't crash on missing key
- ContainsKey() checks if a key exists before accessing
- Queue = FIFO (first in first out) — Enqueue/Dequeue/Peek
- Stack = LIFO (last in first out) — Push/Pop/Peek
- HashSet = no duplicates allowed — great for removing dupes from a list
- try/catch stops program from crashing on errors — handles gracefully
- catch (SpecificException) before catch (Exception) — specific first
- finally block ALWAYS runs — whether error happened or not
- throw new CustomException() — raise your own errors
- File.WriteAllText overwrites, File.AppendAllText adds to existing
- File.ReadAllLines returns string[] — one element per line
- using (StreamWriter sw = ...) auto-closes file when block ends
- Math.Min(5, lines.Length) — prevents crash on files shorter than 5 lines
- File.Exists(path) — check before reading to avoid exceptions
- Split each saved line by ',' to reload Dictionary from file
- Regex.Replace(input, @"[^\w\s]", "") — removes punctuation (advanced!)
- StringSplitOptions.RemoveEmptyEntries — skips empty words from Split
- OrderByDescending used a day early — that's LINQ from Day 7!
```

#### Struggles / Questions
```
- Saved wrong code into wrong files — Contact_Book.cs had File Reader code,
  Safety_Reader.cs had Word Frequency code (file mix-up on upload)
- E04 Contact Book was never actually written — used guided skeleton
- Missing namespace in all 4 files (works but bad practice)
- No empty-input guard on file path → could crash on blank Enter
- Summary path "notes.txt.summary.txt" → double extension
  (fix: Path.GetFileNameWithoutExtension() + "_summary.txt")
- if/else chain for menu → switch is cleaner for fixed options
NOTE: This was the strongest day — nearly all exercises 8.5+!
```

---

### ✅ Day 7 — LINQ & Mini Project
**Date:** 27-05-2026 | **Status:** ✅ Done

#### Topics Covered
- [x] What is LINQ?
- [x] `Where`, `Select`, `OrderBy`, `OrderByDescending`, `GroupBy`
- [x] `First`, `FirstOrDefault`, `Any`, `All`, `Count`
- [x] `Sum`, `Average`, `Min`, `Max`, `Take`, `Skip`, `Distinct`
- [x] Method syntax vs Query syntax
- [x] Lambda expressions `=>`
- [x] Anonymous types — `new { Category = g.Key, Count = g.Count() }`
- [x] `Func<>` and `Action<>` delegates (intro)
- [x] Nullable types (`int?`, `string?`)
- [x] Null coalescing (`??`, `?.`)

#### Exercises Completed
- [x] Exercise 1 — LINQ on Students → 9.5/10 ⭐
- [x] Exercise 2 — LINQ on Products → 8.5/10 ⭐
- **Day Average: 9/10 🔥**

#### Mini Project: Chosen → `🛒 Shopping Cart`
- [x] Product & CartItem classes
- [x] Cart with LINQ totals & discounts
- [x] Save receipt to file
- (Building in stages — applies everything from the week)

#### Notes & Key Learnings
```
- LINQ = query collections like SQL, directly in C#
- Lambda: n => n > 5 means "for each n, return whether n > 5"
- Where(x => condition) = filter — keeps items matching condition
- Select(x => transform) = project — transforms each item
- OrderBy / OrderByDescending = sort ascending / descending
- GroupBy(x => key) = group items, access via group.Key and group.Count()
- First() = first item, throws if empty | FirstOrDefault() = safe, returns null/0
- Count(condition), Sum(x => val), Average(x => val), Min(), Max() — aggregates
- Any(condition) = is there at least one? | All(condition) = do all match?
- Take(n) = first n items | Skip(n) = skip first n | Distinct() = remove dupes
- Chain operations: .Where().OrderBy().Select().ToList()
- .ForEach() only works on List<T> — IEnumerable needs .ToList() first!
- LINQ methods return IEnumerable — add .ToList() to use ForEach or index
- MaxBy() is .NET 6+ only — use OrderByDescending().First() for compatibility
- Anonymous types: new { Category = g.Key, AvgPrice = g.Average(p => p.Price) }
- ToString() override makes objects print nicely everywhere — reuse!
- Interpolation format order: {value,alignment:format} — comma BEFORE colon
- {Price,-10:F2} correct | {Price:F2,-10} wrong (won't format right)
- int? = nullable int — can hold null | use ?? for default if null
- s?.Length = null-conditional — returns null instead of crashing on null
- Func<int,int,int> add = (a,b) => a+b — delegate that returns a value
- Action<string> = delegate that returns void
```

#### Struggles / Questions
```
- MaxBy() failed → CS1061 error, not available below .NET 6
  (fix: reverted to OrderByDescending().First() — works everywhere)
- .ForEach() called on Where()/Select() result → IEnumerable has no ForEach
  (fix: add .ToList() before .ForEach())
- ToString format order wrong: {Price:F2,-10} → {Price,-10:F2}
  (fix: alignment comes before colon, format after)
- Missing namespace in LINQ exercises
- // ...existing code... leftover AI comments in file
NOTE: Day 7 Student exercise had ZERO logic bugs — first time all week!
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
| Studied | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ |
| Exercises done | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ |
| Notes written | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ |

**🔥 Perfect 7/7 streak — every single day!**

---

## 🏆 Milestone Badges

| Badge | Condition | Earned? |
|-------|-----------|---------|
| 🌱 First Program | Ran Hello World | ✅ |
| 🔢 Type Master | Mastered all data types | ✅ |
| 🛡️ Safe Parser | Used TryParse in all exercises | ✅ |
| 🔁 Loop Hero | Completed all loop exercises | ✅ |
| 🔧 Method Master | Wrote methods with return types | ✅ |
| 🔤 String Wizard | Used Split, StringBuilder, Palindrome | ✅ |
| 🧱 OOP Initiate | Built first class & object | ✅ |
| 🧬 Inheritor | Used inheritance successfully | ✅ |
| 🗂️ Collector | Used List & Dictionary | ✅ |
| ⚡ LINQ Ninja | Wrote 5+ LINQ queries | ✅ |
| 🚀 Week Complete | Finished the mini project | ✅ |

---

## 🔖 Code Snippets to Remember

```csharp
// String interpolation — ALWAYS use this over +
string msg = $"Hello, {name}! You are {age} years old.";

// Safe parse with early exit
Console.Write("Enter age: ");
if (!int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine("Invalid input!");
    return;
}

// while(true) + break — infinite loop pattern
int marks = 0;
while (true)
{
    Console.Write("Enter marks (0-100): ");
    if (!int.TryParse(Console.ReadLine(), out marks))
    { Console.WriteLine("Numbers only!"); continue; }
    if (marks < 0 || marks > 100)
    { Console.WriteLine("Must be 0-100!"); continue; }
    break;
}

// CLASS structure — Day 4 pattern
class BankAccount
{
    // Private field — no one outside touches this directly
    private double balance;

    // Public property — controlled access
    public string Owner { get; set; }

    // Instance counter — each object has its own
    public int TotalTransactions { get; private set; }

    // Static counter — shared across ALL objects
    public static int TotalAccounts { get; private set; }

    // Parameterized constructor
    public BankAccount(string owner)
    {
        this.Owner   = owner;
        this.balance = 0;
        TotalAccounts++;   // static — increments for whole class
    }

    public void Deposit(double amt)
    {
        if (amt <= 0) { Console.WriteLine("Invalid!"); return; }
        balance += amt;
        TotalTransactions++;   // instance — only this account
    }

    public void Withdraw(double amt)
    {
        if (amt <= 0 || amt > balance)
        { Console.WriteLine("Invalid!"); return; }
        balance -= amt;
        TotalTransactions++;
    }

    public double GetBalance() { return balance; }

    public void PrintStatement()
    {
        Console.WriteLine($"{"Owner:",-15} {Owner}");
        Console.WriteLine($"{"Balance:",-15} {balance:F2}");
        Console.WriteLine($"{"Transactions:",-15} {TotalTransactions}");
    }
}

// Reject negatives in constructor — ternary
Width  = width  < 0 ? 0 : width;
Height = height < 0 ? 0 : height;

// Static method — belongs to class not object
Rectangle.Compare(r1, r2);

// :F2 format — always 2 decimal places
Console.WriteLine($"Average: {GetAverage():F2}");

// Label alignment — {label,-width}
Console.WriteLine($"{"Name:",-12} {Name}");
Console.WriteLine($"{"Balance:",-12} {balance:F2}");

// Early return pattern — separate ifs with return
if (avg >= 90) return "A";
if (avg >= 75) return "B";
if (avg >= 60) return "C";
if (avg >= 40) return "D";
return "F";

// INHERITANCE — Day 5 patterns
abstract class Animal
{
    public string Name { get; set; }   // public — child classes can see it!
    public int Age  { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age  = age;
    }

    public abstract void Speak();      // child MUST implement

    public virtual void Describe()     // child CAN override
    {
        Console.WriteLine($"{"Name:",-10} {Name}");
        Console.WriteLine($"{"Age:",-10} {Age} yrs");
    }
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void Speak() =>
        Console.WriteLine($"{Name} says: Woof! 🐕");

    public void Fetch() =>             // instance method — NOT static!
        Console.WriteLine($"{Name}: fetching the ball!");
}

// ABSTRACT CLASS with expression body methods
abstract class Shape
{
    public string Color { get; set; }
    public Shape(string color) { Color = color; }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public void PrintInfo()
    {
        Console.WriteLine($"{"Shape:",-12} {GetType().Name}"); // runtime name!
        Console.WriteLine($"{"Color:",-12} {Color}");
        Console.WriteLine($"{"Area:",-12} {GetArea():F2}");
        Console.WriteLine($"{"Perimeter:",-12} {GetPerimeter():F2}");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius, string color) : base(color) { Radius = radius; }
    public override double GetArea()      => Math.PI * Radius * Radius;
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}

class Triangle : Shape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public Triangle(double a, double b, double c, string color) : base(color)
    { A = a; B = b; C = c; }           // lowercase param → uppercase property
    public override double GetArea()
    {
        double s = (A + B + C) / 2;    // s inside method — not as field!
        return Math.Sqrt(s * (s-A) * (s-B) * (s-C));  // Heron's formula
    }
    public override double GetPerimeter() => A + B + C;
}

// INTERFACE — contract only, no implementation
interface IProduct
{
    string GetDescription();
    double GetPrice();
}

// Implementing multiple contracts
class Product : IProduct, IComparable<Product>
{
    public string Name     { get; set; }
    public double Price    { get; set; }
    public string Category { get; set; }

    public Product(string name, double price, string category)
    { Name = name; Price = price; Category = category; }

    public string GetDescription() => $"{Name} ({Category})";
    public double GetPrice()       => Price;

    public int CompareTo(Product other) =>
        this.Price.CompareTo(other.Price);  // enables Array.Sort()
}

// POLYMORPHISM — array of base type, calls correct version
Animal[] animals = { new Dog("Bruno", 3), new Cat("Sinee", 1) };
foreach (Animal a in animals)
    a.Speak();    // calls Dog.Speak() or Cat.Speak() automatically

// PATTERN MATCHING — check type and create variable in one line
if (a is Dog dog)   dog.Fetch();
if (a is Cat cat)   cat.Purr();
if (a is Bird bird) bird.Fly();

// Array.Sort using IComparable
Array.Sort(products);   // sorts by CompareTo() automatically

// COLLECTIONS — Day 6
List<string> tasks = new List<string>();
tasks.Add("task");           // add
tasks.RemoveAt(0);           // remove by index
tasks.Count;                 // size (not .Length!)

Dictionary<string, string> contacts = new Dictionary<string, string>();
contacts["Ritesh"] = "98765";          // add/update
if (contacts.TryGetValue("Ritesh", out string phone))  // safe read
    Console.WriteLine(phone);
contacts.Remove("Ritesh");             // delete
contacts.ContainsKey("Ritesh");        // check

// Queue (FIFO) and Stack (LIFO)
Queue<string> q = new Queue<string>();
q.Enqueue("a"); q.Dequeue();           // add back, remove front
Stack<string> s = new Stack<string>();
s.Push("a"); s.Pop();                  // add top, remove top

// EXCEPTION HANDLING — Day 6
try
{
    string[] lines = File.ReadAllLines(path);
}
catch (FileNotFoundException)        { Console.WriteLine("Not found!"); }
catch (UnauthorizedAccessException)  { Console.WriteLine("No access!"); }
catch (Exception ex)                 { Console.WriteLine(ex.Message); }
finally                              { Console.WriteLine("Always runs"); }

// FILE I/O with using — auto-closes
using (StreamWriter sw = new StreamWriter("file.txt"))
{
    foreach (var pair in contacts)
        sw.WriteLine($"{pair.Key},{pair.Value}");
}

// Load back — split each line
foreach (string line in File.ReadAllLines("file.txt"))
{
    string[] parts = line.Split(',');
    if (parts.Length == 2) contacts[parts[0]] = parts[1];
}

// LINQ — Day 7
var passing   = students.Where(s => s.Grade >= 75).ToList();
var ranked    = students.OrderByDescending(s => s.Grade).ToList();
var names     = students.Select(s => s.Name).ToList();
var top       = students.OrderByDescending(s => s.Grade).First();
var avg       = students.Average(s => s.Grade);
var count     = students.Count(s => s.Grade >= 40);
var top3      = students.OrderByDescending(s => s.Grade).Take(3).ToList();

// LINQ GroupBy with anonymous type
var byCategory = products
    .GroupBy(p => p.Category)
    .Select(g => new { Category = g.Key, Avg = g.Average(p => p.Price) });

// .ForEach needs List — add .ToList() to LINQ results first!
students.Where(s => s.Grade >= 75).ToList().ForEach(s => Console.WriteLine(s));

// Interpolation format: {value,alignment:format} — comma BEFORE colon
Console.WriteLine($"{Name,-20} ₹{Price,-10:F2}");

// Func and Action delegates
Func<int, int, int> add = (a, b) => a + b;       // returns value
Action<string> greet = name => Console.WriteLine($"Hi {name}");  // returns void

// Null coalescing (Day 7)
string result = name ?? "Unknown";

// Null conditional — no crash on null
int? len = text?.Length;

// LINQ basics
var adults = people.Where(p => p.Age >= 18).ToList();
```

---

## 🗒️ General Notes & Observations

```
Week started on: 21-05-2026

Things I found easy:
- Understanding data types (Day 1)
- String interpolation syntax (Day 1)
- Basic program structure namespace → class → Main (Day 1)
- FizzBuzz logic — got condition order right instinctively (Day 2)
- for loop structure and counting (Day 2)
- Palindrome logic — reverse loop and comparison (Day 3)
- Array input loop structure (Day 3)
- Static vs Instance concept — answered quiz 4/4 correctly (Day 4)
- Rectangle class — wrote cleanly with barely any bugs (Day 4)
- Ternary operator for negative rejection in constructor (Day 4)
- Polymorphism array — correct structure instinctively (Day 5)
- base() constructor calls — used correctly throughout (Day 5)
- Abstract class structure — right thinking from start (Day 5)
- GetType().Name — found elegant solution independently (Day 5)

Things I found hard:
- Remembering to close all curly braces especially namespace (Day 1)
- Remembering $ before "" in interpolation (Day 1)
- Setting up VS Code to run .cs files without a project (Day 1)
- Variable scope — variables inside blocks die outside them (Day 2)
- Mixing void + out + return in Calculator (Day 3)
- int.MinValue syntax — kept thinking it was Math.something (Day 3)
- Word Counter — Split(' ') trick was completely unknown (Day 3)
- TotalTransactions placement — constructor vs methods (Day 4)
- High == g vs High = g — comparison vs assignment (Day 4)
- public missing on base class properties — child classes invisible (Day 5)
- static methods on instance data — Fetch/Purr/Fly were wrongly static (Day 5)
- A = A self-assignment — uppercase param same as property name (Day 5)
- s as class field instead of local variable in GetArea() (Day 5)
- ** Python syntax used instead of Math.Sqrt() (Day 5)
- IComparable concept — needed full walkthrough to understand (Day 5)

What helped me the most:
- Code reviews after each exercise — catching bugs early
- Breaking problems into plain English steps before coding
- Elite-mode reviews — push to write professional code
- Step-by-step guided breakdown when completely stuck
- Writing Rectangle myself instead of asking for final code → 9.5/10
- Quiz-style questions on static vs instance — locked in the concept
- Consistent daily practice — 7/7 days, no skips

Biggest wins this week:
- Went from "Hello World" to building a Shopping Cart in 7 days
- Day 6 averaged 9/10 — collections & files clicked completely
- Day 7 LINQ Students exercise had ZERO logic bugs (first time!)
- Used Regex and LINQ a day before they were even taught
- Now building an Enterprise Payroll Management System independently

Score progression (improvement is real):
- Day 1: 8.3 | Day 2: 6.9 | Day 3: 5.7 (hardest)
- Day 4: 7.3 | Day 5: 6.3 | Day 6: 9.0 | Day 7: 9.0
- Trend: dipped mid-week with new concepts, then soared

What I want to explore after this week:
- ASP.NET Core for web development
- Building desktop apps with .NET MAUI
- GitHub portfolio of C# projects
- Enterprise Payroll Management System (already started!)
```

---

## ✍️ Author

**Name:** Ritesh Mane  
**GitHub:** ritesh8308  
**Started:** 21/05/2026  
**Completed:** 27/05/2026 🎉

---

## 📊 Final Scoreboard

| Day | Topic | Avg Score |
|-----|-------|-----------|
| Day 1 | Foundations & Setup | 8.3/10 |
| Day 2 | Operators, Conditions & Loops | 6.9/10 |
| Day 3 | Methods, Arrays & Strings | 5.7/10 |
| Day 4 | OOP — Classes & Objects | 7.3/10 |
| Day 5 | OOP — Inheritance & Interfaces | 6.3/10 |
| Day 6 | Collections, Exceptions & Files | 9.0/10 |
| Day 7 | LINQ & Mini Project | 9.0/10 |
| **Overall** | **Full Week** | **7.5/10** |

---

## 🛒 Capstone Project — Shopping Cart

A complete multi-file console application demonstrating the entire week's curriculum:

```
Shopping_Cart/
├── src/
│   ├── Product.cs    → model class (Day 4)
│   ├── CartItem.cs   → calculated property (Day 4)
│   ├── Cart.cs       → List<T> + LINQ (Day 6, 7)
│   └── Receipt.cs    → StringBuilder + File I/O + try/catch (Day 3, 6)
├── Program.cs        → menu loop + switch + discount logic (Day 2, 6)
└── receipt.txt       → generated output
```

**Concepts used from every single day:**
- Day 1 — string interpolation, TryParse, :F2 formatting
- Day 2 — while(true) + break menu, switch, ternary
- Day 3 — methods, StringBuilder
- Day 4 — classes, properties, calculated property, static methods
- Day 5 — (ToString override, encapsulation)
- Day 6 — List, Dictionary, try/catch, File.WriteAllText
- Day 7 — LINQ (Where, Sum, FirstOrDefault, Distinct), null coalescing

**From zero to building a Shopping Cart + an Enterprise Payroll System in 7 days.** 🚀

---

*"Every expert was once a beginner. Keep going, one day at a time."* 💪