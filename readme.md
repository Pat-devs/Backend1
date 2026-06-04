# Kodehode - Backend Modul 1: Uke 1

## NB! KI Bruksnotat: *Følgende ble genereret vha. ChatGPT 5.5 utfra mine commit kommentarer, commit innhold og noe ekstra prompting. Det aller meste skal være korrekt men det kan være noen ting er litt uklart.*




### Tema:

* Create and run a C# console application
* Print text to the terminal
* Use `Console.WriteLine`, `Console.Write`, and `Console.ReadLine`
* Declare variables
* Use common data types: `string`, `int`, `double`, and `bool`
* Convert text input into numbers
* Use arithmetic operators
* Understand integer division and decimal division
* Use explicit casting
* Understand scope
* Write Boolean expressions
* Use comparison operators
* Use `if`, `else if`, and `else`
* Combine conditions with `&&` and `||`
* Validate user input
* Build small console applications

---

# Session 1: C# Basics, Variables, Types, and Input

Session 1 introduces the C# console project, output, strings, variables, primitive data types, and basic user input.

---

## Commit 1: `setup project`

### Learning objective

Set up the initial C# console project and understand the basic files in a .NET application.

### Code changes

This commit creates the starting project structure:

* `.gitignore`
* `.csproj`
* `Program.cs`

The first program contains:

```csharp
Console.WriteLine("Hello, World!");
```

### Explanation for beginners

A C# console application is a program that runs in a terminal.

The most important beginner files are:

* `Program.cs`: where the program code starts
* `.csproj`: describes the project to .NET
* `.gitignore`: tells Git which files should not be saved

The line:

```csharp
Console.WriteLine("Hello, World!");
```

prints text to the console.

`Console` represents the terminal.

`WriteLine` writes text and then moves to a new line.

### Mini tasks

1. Run the program and confirm that it prints `Hello, World!`.
2. Change the message to print your own name.
3. Add a second `Console.WriteLine`.
4. Open the `.csproj` file and find the target framework.

### Expected outcome

The learner should understand the basic shape of a C# console project and know where the program starts.

---

## Commit 2: `Console WriteLine and Write example`

### Learning objective

Learn the difference between `Console.WriteLine` and `Console.Write`.

### Code changes

The program changes to multiple output examples:

```csharp
Console.WriteLine("A");
Console.WriteLine("B");
Console.Write("C");
Console.WriteLine("D");
```

### Explanation for beginners

`Console.WriteLine` prints text and then moves to the next line.

`Console.Write` prints text but stays on the same line.

Example:

```csharp
Console.Write("C");
Console.WriteLine("D");
```

This prints `CD` together on one line.

Comments are also introduced:

```csharp
// Writing to console
```

A comment is a note for humans. C# ignores comments when running the program.

### Mini tasks

1. Predict the output before running the program.
2. Replace `"A"`, `"B"`, `"C"`, and `"D"` with your own words.
3. Add two `Console.Write` statements that print on the same line.
4. Add comments explaining what each line does.

### Expected outcome

The learner should understand console output, line breaks, and comments.

---

## Commit 3: `plus operator with strings and numbers`

### Learning objective

Understand how the `+` operator behaves differently with strings and numbers.

### Code changes

The commit introduces examples like:

```csharp
Console.WriteLine("Hi " + " there");
Console.WriteLine("2" + 2);
Console.WriteLine(2 + 2);
```

### Explanation for beginners

The `+` operator can do different things depending on the data.

With numbers, `+` performs addition:

```csharp
2 + 2
```

Result:

```text
4
```

With strings, `+` joins text together. This is called string concatenation:

```csharp
"Hi " + "there"
```

Result:

```text
Hi there
```

If one side is a string and the other side is a number, C# treats the number like text:

```csharp
"2" + 2
```

Result:

```text
22
```

That is not math addition. It is text joining.

### Mini tasks

1. Uncomment each example one at a time and run the program.
2. Write an example where `+` performs math addition.
3. Write an example where `+` joins two strings.
4. Write an example where a string and a number are joined.
5. Explain why `"10" + 5` gives `105`, not `15`.

### Expected outcome

The learner should understand that operators can behave differently depending on data types.

---

## Commit 4: `using var to declare a variable`

### Learning objective

Introduce variables and assignment.

### Code changes

The code introduces a variable:

```csharp
var greeting = "Hello";
Console.WriteLine(greeting);
```

### Explanation for beginners

A variable is a named container for a value.

In this example:

```csharp
var greeting = "Hello";
```

* `var` tells C# to figure out the type automatically
* `greeting` is the variable name
* `=` assigns a value
* `"Hello"` is the value stored in the variable

After that, the program can use the variable name:

```csharp
Console.WriteLine(greeting);
```

### Mini tasks

1. Change the value of `greeting`.
2. Rename the variable to `message`.
3. Add another variable called `courseName`.
4. Print both variables.
5. Replace `var` with `string`.

### Expected outcome

The learner should understand what a variable is and how assignment works.

---

## Commit 5: `using multiple string variables`

### Learning objective

Practice declaring multiple string variables and combining them.

### Code changes

The code uses explicitly typed string variables:

```csharp
string greeting = "Hello";
string userName = "Patryk";

Console.WriteLine(greeting + " " + userName);
```

### Explanation for beginners

A `string` stores text.

This line:

```csharp
string greeting = "Hello";
```

creates a text variable named `greeting`.

This line:

```csharp
Console.WriteLine(greeting + " " + userName);
```

joins:

1. The value of `greeting`
2. A space `" "`
3. The value of `userName`

The result is a full greeting.

Variable names like `userName` use camelCase.

### Mini tasks

1. Change `userName` to your own name.
2. Add a `lastName` variable.
3. Print a full name using `firstName` and `lastName`.
4. Add a `courseName` variable and print a sentence using it.

### Expected outcome

The learner should be able to create string variables and combine them into useful output.

---

## Commit 6: `int, double and bool example`

### Learning objective

Introduce common primitive data types: `string`, `int`, `double`, and `bool`.

### Code changes

The program adds more user data:

```csharp
string userName = "Patryk";
int userAge = 46;
double userHeight = 1.8;
bool userIsOnline = true;
```

### Explanation for beginners

C# is strongly typed. Each variable has a specific type.

Common beginner types:

```csharp
string userName = "Patryk";
```

Stores text.

```csharp
int userAge = 46;
```

Stores a whole number.

```csharp
double userHeight = 1.8;
```

Stores a decimal number.

```csharp
bool userIsOnline = true;
```

Stores either `true` or `false`.

Choosing the correct type matters.

### Mini tasks

1. Create a `string` variable for a city.
2. Create an `int` variable for a year.
3. Create a `double` variable for a price.
4. Create a `bool` variable for whether a user is logged in.
5. Print all four variables with labels.

### Expected outcome

The learner should understand basic C# data types and when to use each one.

---

## Commit 7: `readLine and how to terminate an app`

### Learning objective

Introduce `Console.ReadLine` and show that programs can wait for user input.

### Code changes

The previous example is replaced with:

```csharp
Console.ReadLine();
```

### Explanation for beginners

`Console.ReadLine()` waits for the user to type something and press Enter.

A program normally runs from top to bottom.

When C# reaches:

```csharp
Console.ReadLine();
```

the program pauses and waits.

The commit also discusses terminating the program with `Ctrl-C`.

### Mini tasks

1. Run the program and observe that it waits.
2. Type something and press Enter.
3. Add a `Console.WriteLine` before `Console.ReadLine`.
4. Add a `Console.WriteLine` after `Console.ReadLine`.
5. Explain when each line runs.

### Expected outcome

The learner should understand that console programs can pause and wait for input.

---

## Commit 8: `using readline and casting`

### Learning objective

Read user input, store it in variables, and convert text input into numbers.

### Code changes

The program becomes interactive:

```csharp
Console.WriteLine("Enter your first name: ");
string userName = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int userAge = int.Parse(Console.ReadLine());

userAge = userAge + 2000;

Console.WriteLine(" you are " + userAge + " years old.");
```

### Explanation for beginners

`Console.ReadLine()` always returns text.

Text in C# is a `string`.

This works naturally:

```csharp
string userName = Console.ReadLine();
```

But age should be a number. To convert text into an integer, the code uses:

```csharp
int.Parse(Console.ReadLine())
```

If the user types:

```text
20
```

C# first receives it as:

```csharp
"20"
```

Then `int.Parse` converts it into the number:

```csharp
20
```

This commit also changes a variable after it has been created:

```csharp
userAge = userAge + 2000;
```

### Mini tasks

1. Ask the user for their name and print it back.
2. Ask the user for their age and convert it with `int.Parse`.
3. Add `10` to the age and print the result.
4. Try typing text instead of a number for age.
5. Add comments explaining why parsing is needed.

### Expected outcome

The learner should understand that console input is text and must be converted before number operations.

---

# Session 2: Arithmetic, Modulo, Calculator, and Casting

Session 2 builds on input and variables by introducing arithmetic, modulo, calculator logic, division problems, and casting.

---

## Commit 9: `standard math ops (+,-,*,/)`

### Learning objective

Practice arithmetic operators in C#.

### Code changes

The program asks for a lucky number:

```csharp
Console.WriteLine("Enter your lucky number: ");
int luckyNumber = int.Parse(Console.ReadLine());
```

It includes arithmetic examples:

```csharp
luckyNumber = luckyNumber + 2000;
luckyNumber = luckyNumber - 2;
luckyNumber = luckyNumber * 5;
luckyNumber = luckyNumber / 5;
```

It also introduces shortcut assignment operators:

```csharp
+=
-=
*=
/=
```

### Explanation for beginners

C# supports standard math operators:

* `+` addition
* `-` subtraction
* `*` multiplication
* `/` division

This line:

```csharp
luckyNumber = luckyNumber + 2000;
```

means: take the old value, add `2000`, and save the new value.

A shorter version is:

```csharp
luckyNumber += 2000;
```

Both do the same thing.

### Mini tasks

1. Ask for a number and add `10` to it.
2. Ask for a number and multiply it by `2`.
3. Rewrite one operation using `+=`.
4. Rewrite another operation using `*=`.
5. Print the value after each operation.

### Expected outcome

The learner should be able to perform basic arithmetic and update variable values.

---

## Commit 10: `modulo example`

### Learning objective

Introduce the modulo operator `%` and use it to find remainders.

### Code changes

A modulo example is added:

```csharp
int divisor = 2;

Console.WriteLine(10 % divisor);
Console.WriteLine(9 % divisor);
Console.WriteLine(8 % divisor);
Console.WriteLine(7 % divisor);
```

### Explanation for beginners

The modulo operator `%` gives the remainder after division.

Example:

```csharp
5 % 2
```

`5 / 2` fits two times, with `1` left over.

So:

```csharp
5 % 2
```

gives:

```text
1
```

Modulo is useful for checking whether a number is even or odd.

If:

```csharp
number % 2
```

gives `0`, the number is even.

### Mini tasks

1. Print the result of `15 % 2`.
2. Print the result of `20 % 2`.
3. Ask the user for a number and calculate `number % 2`.
4. Add a comment explaining how modulo helps detect even numbers.
5. Try using a different divisor, such as `3`.

### Expected outcome

The learner should understand remainders and know how modulo can help classify numbers.

---

## Commit 11: `simple calc start`

### Learning objective

Start designing a simple calculator by planning the program steps and reading the first number.

### Code changes

The program begins a calculator:

```csharp
// A simple calculator
// 1. Greeting
// 2. Ask user for first number
// 3. Ask user for second number
// 4. Show user the sum of the two numbers

Console.WriteLine("Sum of two numbers (a simple calculator)");
Console.WriteLine("Enter the first number");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("user entered: " + firstNumber);
```

### Explanation for beginners

This commit moves from small experiments to a small useful program.

The comments describe the plan before the code is complete.

The calculator needs to:

1. Tell the user what the program does
2. Ask for the first number
3. Ask for the second number
4. Calculate the result
5. Print the result

At this stage, the program only reads the first number and prints it back.

### Mini tasks

1. Read the comments and explain the planned calculator flow.
2. Change the greeting message.
3. Ask for the first number and print it back.
4. Add a prompt for the second number.
5. Write comments for the next steps before coding them.

### Expected outcome

The learner should understand how to plan a program in small steps and test one piece at a time.

---

## Commit 12: `calculator: sum version`

### Learning objective

Complete the first working calculator version using addition.

### Code changes

The program asks for two numbers:

```csharp
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
```

It calculates their sum:

```csharp
int result = firstNumber + secondNumber;
```

Then it prints the full calculation:

```csharp
Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);
```

### Explanation for beginners

This is the first complete calculator.

The program follows input-process-output:

1. Input: get two numbers
2. Process: add the numbers
3. Output: print the result

The result is stored in a variable:

```csharp
int result = firstNumber + secondNumber;
```

Using a `result` variable makes the code easier to read.

### Mini tasks

1. Run the calculator with `3` and `4`.
2. Change the calculator to subtract instead of add.
3. Change the calculator to multiply instead of add.
4. Update the printed operator so the output matches the calculation.
5. Add comments explaining input, processing, and output.

### Expected outcome

The learner should be able to build a basic two-number calculator.

---

## Commit 13: `simple calc, note: division does not work with 0`

### Learning objective

Change the calculator from addition to division and notice a runtime error case.

### Code changes

The calculator changes from:

```csharp
int result = firstNumber + secondNumber;
```

to:

```csharp
int result = firstNumber / secondNumber;
```

The printed output also changes from `+` to `/`.

### Explanation for beginners

Division uses the `/` operator.

But division has an important rule: you cannot divide an integer by zero.

This code can fail:

```csharp
int result = firstNumber / secondNumber;
```

if `secondNumber` is `0`.

This causes a `DivideByZeroException`.

This commit also shows integer division. Because the values are `int`, C# gives a whole-number result.

Example:

```text
5 / 2
```

with integers gives:

```text
2
```

not:

```text
2.5
```

### Mini tasks

1. Run the calculator with `10` and `2`.
2. Run the calculator with `5` and `2`.
3. Run the calculator with `10` and `0`.
4. Add a comment explaining why division by zero is a problem.
5. Change the operator back to `+`, `-`, or `*`.

### Expected outcome

The learner should understand division, integer division, and why some user input can cause runtime errors.

---

## Commit 14: `decimals, and explicit / implicit casting`

### Learning objective

Fix integer division by introducing decimal results and explicit casting.

### Code changes

The result type changes from `int` to `double`:

```csharp
double result = (double)firstNumber / secondNumber;
```

### Explanation for beginners

In C#, dividing two integers gives an integer result.

Example:

```csharp
int result = 5 / 2;
```

Result:

```text
2
```

The decimal part is removed.

To get a decimal answer, at least one number must be a decimal-capable type such as `double`.

This commit uses explicit casting:

```csharp
(double)firstNumber
```

That means: temporarily treat `firstNumber` as a `double`.

Now:

```csharp
(double)firstNumber / secondNumber
```

can produce:

```text
2.5
```

The result variable also needs to be a `double`.

### Mini tasks

1. Run the calculator with `5` and `2`.
2. Remove `(double)` and observe the difference.
3. Change the result variable back to `int` and observe what happens.
4. Try `10` divided by `4`.
5. Add a comment explaining why casting is needed.

### Expected outcome

The learner should understand integer division, decimal division, and explicit casting.

---

# Session 3: Control Flow and Conditionals

Session 3 introduces control flow: how a program decides which code should run.

---

## Commit 15: `Control flow: intro (scope)`

### Learning objective

Introduce control flow, scope, and the idea that conditions evaluate to either `true` or `false`.

### Code changes

The calculator code is replaced with a control-flow example:

```csharp
{
    string myText = "Hi";

    Console.WriteLine("Line 1");
    Console.WriteLine("Line 2");
    Console.WriteLine("Line 3");

    Console.WriteLine(myText);
}
```

It also introduces:

```csharp
if (true)
{
    Console.WriteLine("Line 4");
}
```

### Explanation for beginners

A scope is an area of code inside curly braces:

```csharp
{
    // code inside this block
}
```

Variables created inside a scope only exist inside that scope.

Example:

```csharp
{
    string myText = "Hi";
}
```

The variable `myText` exists only inside those braces.

An `if` statement runs its code only when its condition is `true`.

### Mini tasks

1. Create a variable inside a block and print it inside the block.
2. Try to print that variable outside the block.
3. Change `if (true)` to `if (false)`.
4. Add a comment explaining scope.
5. Add a second block with a different variable.

### Expected outcome

The learner should understand that curly braces create scopes and that `if` statements run conditionally.

---

## Commit 16: `Example: scope within another scope, and too many scopes`

### Learning objective

Show that scopes can be nested, but too many nested scopes make code harder to read.

### Code changes

The code adds several blocks inside each other:

```csharp
{
    Console.WriteLine(myText);

    {
        Console.WriteLine(myText);

        {
            Console.WriteLine(myText);
        }
    }
}
```

### Explanation for beginners

A scope can contain another scope. This is called nested scope.

A variable declared in an outer scope can usually be used inside inner scopes:

```csharp
{
    string myText = "Hi";

    {
        Console.WriteLine(myText);
    }
}
```

But code outside the block cannot access variables created inside the block.

Too many nested blocks make code difficult to read.

### Mini tasks

1. Create an outer block with a variable called `message`.
2. Print `message` inside an inner block.
3. Create a variable inside an inner block and try to print it outside.
4. Reduce unnecessary nested blocks in the example.
5. Explain why too much nesting can make code confusing.

### Expected outcome

The learner should understand nested scope and why clean code avoids unnecessary nesting.

---

## Commit 17: `conditional Operators I`

### Learning objective

Introduce comparison operators that produce Boolean values.

### Code changes

The scope example is replaced with comparison examples:

```csharp
Console.WriteLine(2 > 2);
Console.WriteLine(2 < 2);
Console.WriteLine(5 > 4);
```

### Explanation for beginners

A condition must result in:

```csharp
true
```

or:

```csharp
false
```

Comparison operators compare values and produce a Boolean result.

Examples:

```csharp
5 > 4
```

Result:

```csharp
true
```

```csharp
2 > 2
```

Result:

```csharp
false
```

Common comparison operators:

```csharp
>   greater than
<   less than
>=  greater than or equal to
<=  less than or equal to
```

### Mini tasks

1. Print the result of `10 > 5`.
2. Print the result of `10 < 5`.
3. Print the result of `10 >= 10`.
4. Print the result of `7 <= 3`.
5. Predict each result before running the code.

### Expected outcome

The learner should understand that comparison expressions produce Boolean values.

---

## Commit 18: `Not equal and not operator`

### Learning objective

Introduce equality, inequality, and the NOT operator.

### Code changes

The commit adds examples of:

```csharp
==
!=
!
```

Examples:

```csharp
Console.WriteLine(5 == 5);
Console.WriteLine(500 != 400);
Console.WriteLine(!true);
Console.WriteLine(!!false);
```

### Explanation for beginners

The equality operator checks if two values are the same:

```csharp
5 == 5
```

Result:

```csharp
true
```

The not-equal operator checks if two values are different:

```csharp
500 != 400
```

Result:

```csharp
true
```

The NOT operator `!` flips a Boolean value:

```csharp
!true
```

becomes:

```csharp
false
```

Two NOT operators flip the value twice:

```csharp
!!false
```

Result:

```csharp
false
```

### Mini tasks

1. Print `10 == 10`.
2. Print `10 == 20`.
3. Print `10 != 20`.
4. Print `!true`.
5. Print `!!true` and explain the result.

### Expected outcome

The learner should understand equality, inequality, and how `!` reverses Boolean values.

---

## Commit 19: `single if statement`

### Learning objective

Use a comparison inside an `if` statement.

### Code changes

The code introduces:

```csharp
Console.Clear();

int userAge = 16;

if (userAge >= 18)
{
    Console.WriteLine("Hello, welcome in!");
}
```

### Explanation for beginners

This is the first practical `if` example.

The program checks whether the user is old enough:

```csharp
userAge >= 18
```

If the condition is `true`, the code inside the braces runs.

If the condition is `false`, the code inside the braces is skipped.

`Console.Clear()` clears the console window before printing new output.

### Mini tasks

1. Change `userAge` to `18`.
2. Change `userAge` to `25`.
3. Change `userAge` to `10`.
4. Add a second `if` checking whether `userAge < 18`.
5. Add comments explaining when the message prints.

### Expected outcome

The learner should be able to write a simple `if` statement using a comparison.

---

## Commit 20: `control flow: if and remaining code flow`

### Learning objective

Understand that code outside an `if` block always runs.

### Code changes

The user age is changed:

```csharp
int userAge = 25;
```

A line is added after the `if` block:

```csharp
Console.WriteLine("We cannot allow you in!");
```

### Explanation for beginners

An `if` statement controls only the code inside its braces.

Example:

```csharp
if (userAge >= 18)
{
    Console.WriteLine("Hello, welcome in!");
}

Console.WriteLine("We cannot allow you in!");
```

The welcome message is conditional.

The final message is outside the `if` block, so it always runs.

This can create a logic problem.

### Mini tasks

1. Run the program with `userAge = 25`.
2. Notice that the code after the `if` still runs.
3. Move the final message into a separate `if`.
4. Add comments marking conditional code and always-running code.
5. Explain why the output may be confusing.

### Expected outcome

The learner should understand that only code inside the `if` block is controlled by the condition.

---

## Commit 21: `if, then another if`

### Learning objective

Use two separate `if` statements for two separate conditions.

### Code changes

The age changes to:

```csharp
int userAge = 17;
```

A second `if` statement is added:

```csharp
if (userAge < 18)
{
    Console.WriteLine("Hello, we cannot welcome you inside!");
}
```

### Explanation for beginners

This commit shows two independent conditions:

```csharp
if (userAge >= 18)
{
    Console.WriteLine("Hello, welcome in!");
}

if (userAge < 18)
{
    Console.WriteLine("Hello, we cannot welcome you inside!");
}
```

C# checks both `if` statements one after the other.

In this example, only one condition can be true, but they are still separate checks.

### Mini tasks

1. Set `userAge` to `17`.
2. Set `userAge` to `18`.
3. Set `userAge` to `30`.
4. Add a third `if` checking whether `userAge == 18`.
5. Explain the difference between the `if` blocks and remaining code.

### Expected outcome

The learner should understand that multiple `if` statements are checked independently.

---

## Commit 22: `if, else example`

### Learning objective

Introduce `else` as the alternative path when an `if` condition is false.

### Code changes

The two separate `if` statements are replaced with:

```csharp
if (userAge >= 18)
{
    Console.WriteLine("Hello, welcome in!");
}
else
{
    Console.WriteLine("Hello, we cannot welcome you inside!");
}
```

### Explanation for beginners

An `else` block belongs to an `if`.

The `if` block runs when the condition is true.

The `else` block runs when the condition is false.

Only one branch runs.

This is better than two separate `if` statements when there are only two possible outcomes.

### Mini tasks

1. Set `userAge` to `19`.
2. Set `userAge` to `16`.
3. Replace the messages with your own messages.
4. Write an `if/else` that checks whether a number is positive.
5. Explain why `else` is useful when there are two possible outcomes.

### Expected outcome

The learner should understand how `if/else` creates two alternative paths.

---

## Commit 23: `check if a number is odd or even`

### Learning objective

Combine modulo `%`, equality `==`, and `if/else`.

### Code changes

The age-check example is replaced with an odd/even checker:

```csharp
int number = 3;

if (number % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}
```

### Explanation for beginners

The modulo operator gives the remainder after division:

```csharp
number % 2
```

If a number divided by `2` has a remainder of `0`, it is even:

```csharp
number % 2 == 0
```

If the condition is false, the number is odd.

This combines:

* variables
* arithmetic
* comparison
* Boolean results
* `if/else`

### Mini tasks

1. Change `number` to `4`.
2. Change `number` to `7`.
3. Try `number = 0`.
4. Ask the user to enter a number.
5. Convert the input with `int.Parse` and check odd/even.

### Expected outcome

The learner should be able to combine modulo and conditionals to classify numbers.

---

## Commit 24: `comparing strings`

### Learning objective

Compare user input against a stored string.

### Code changes

The odd/even example is replaced with a password check:

```csharp
string secretPassword = "l33th4x0r";

Console.Write("Enter password: ");
string userInputPassword = Console.ReadLine();

if (userInputPassword == secretPassword)
{
    Console.WriteLine("Access Granted!");
}
else
{
    Console.WriteLine("Access Denied!");
}
```

### Explanation for beginners

Strings can be compared with `==`.

This checks whether two strings contain exactly the same text:

```csharp
userInputPassword == secretPassword
```

String comparison is exact. Capitalization, spelling, and symbols matter.

```text
l33th4x0r
```

is not the same as:

```text
L33TH4X0R
```

### Mini tasks

1. Run the program and enter the correct password.
2. Run the program and enter the wrong password.
3. Change the secret password.
4. Add a username variable and check the username separately.
5. Add comments explaining why exact string matching matters.

### Expected outcome

The learner should understand how to compare text input and use it in an `if/else`.

---

## Commit 25: `pseudocode (attempt with faults) for greeting based on time`

### Learning objective

Introduce pseudocode as a planning tool before writing final code.

### Code changes

The password-checking program is replaced with comments describing a new app:

```csharp
// greeting based on time of day App
// time of day will be a number (0-23)
// if hour < 12 say "Good morning"
// if hour > 12 say "Good afternoon"
// if hour > 17 say "Good evening"
// in all other cases say goodnight
```

### Explanation for beginners

Pseudocode is a plain-language plan for a program.

It is not always valid C# code. It describes what the program should do.

This commit is useful because programmers often plan before coding.

The commit message says this is an attempt with faults. Planning is useful, but plans can still contain logic mistakes.

For example, order matters. If the program checks `hour < 12` before checking night hours, then `3` may incorrectly become `"Good morning"`.

### Mini tasks

1. Rewrite the pseudocode in your own words.
2. Identify possible problems in the pseudocode.
3. Decide exact hour ranges for night, morning, afternoon, and evening.
4. Write test values: `0`, `6`, `7`, `12`, `17`, `18`, `23`.
5. Explain why planning before coding helps.

### Expected outcome

The learner should understand how to use pseudocode and how to review logic before implementation.

---

## Commit 26: `example of AND OR operators`

### Learning objective

Introduce logical AND `&&`, logical OR `||`, and grouping with parentheses.

### Code changes

The greeting plan is expanded:

```csharp
int hour = 0;

// AND operator: &&
// OR operator: ||
```

Examples include:

```csharp
Console.Write(true && false || true);
Console.Write(true && (false || true));
```

### Explanation for beginners

Logical operators combine Boolean expressions.

The AND operator `&&` means both sides must be true:

```csharp
true && true
```

Result:

```csharp
true
```

But:

```csharp
true && false
```

Result:

```csharp
false
```

The OR operator `||` means at least one side must be true:

```csharp
true || false
```

Result:

```csharp
true
```

Parentheses can group parts of a condition:

```csharp
true && (false || true)
```

This is useful for conditions like:

```csharp
hour < 0 || hour > 23
```

### Mini tasks

1. Print the result of `true && true`.
2. Print the result of `true && false`.
3. Print the result of `false || true`.
4. Print the result of `false || false`.
5. Write a condition that checks whether `hour` is between `0` and `23`.

### Expected outcome

The learner should understand how to combine Boolean expressions with AND and OR.

---

## Commit 27: `implement invalid time`

### Learning objective

Use `||` and `else` to validate a range before continuing.

### Code changes

Two separate invalid checks become one combined check:

```csharp
if (hour < 0 || hour > 23)
{
    Console.WriteLine("Invalid time!");
}
else
{
    // user entered a valid time
}
```

### Explanation for beginners

A valid hour should be between `0` and `23`.

An invalid hour is:

```csharp
hour < 0
```

or:

```csharp
hour > 23
```

These can be combined with OR:

```csharp
hour < 0 || hour > 23
```

This is a common pattern:

1. Check for invalid input first.
2. Show an error if needed.
3. Continue only when the input is valid.

### Mini tasks

1. Set `hour` to `-1`.
2. Set `hour` to `24`.
3. Set `hour` to `12`.
4. Add a message inside the `else` block, such as `"Valid time!"`.
5. Rewrite the condition using `&&` to check whether the time is valid.

### Expected outcome

The learner should understand how to validate a range with OR and separate valid and invalid cases.

---

## Commit 28: `implement greeting conditionals for all cases`

### Learning objective

Complete the time-based greeting app with nested conditionals and `else if`.

### Code changes

The pseudocode is improved:

```csharp
// if hour is outside of 0-23 range print invalid time
// if hour is between 0 and 6 say "Good night"
// if hour is between 7 and 11 say "Good morning"
// if hour is between 12 and 17 say "Good afternoon"
// if hour is between 18 and 23 say "Good evening"
```

The code checks invalid time first:

```csharp
if (hour < 0 || hour > 23)
{
    Console.WriteLine("Invalid time!");
}
else
{
    if (hour <= 6)
    {
        Console.WriteLine("Good night");
    }
    else if (hour <= 11)
    {
        Console.WriteLine("Good morning");
    }
    else if (hour <= 17)
    {
        Console.WriteLine("Good afternoon");
    }
    else
    {
        Console.WriteLine("Good night");
    }
}
```

### Explanation for beginners

This commit introduces a full decision tree.

First, the program checks whether the hour is invalid:

```csharp
if (hour < 0 || hour > 23)
```

If the hour is invalid, it prints an error.

If the hour is valid, the program checks which range the hour belongs to.

The code uses `else if`:

```csharp
else if (hour <= 11)
```

An `else if` means: if the earlier condition was false, check this next condition.

Because the program already checked `hour <= 6`, the next condition:

```csharp
hour <= 11
```

really means 7 through 11.

The order matters:

1. `hour <= 6`
2. `hour <= 11`
3. `hour <= 17`
4. otherwise, the hour must be 18 through 23

Teacher note: the final `else` currently prints `"Good night"`, but according to the pseudocode it should probably print `"Good evening"`.

### Mini tasks

1. Test the program with `hour = -1`.
2. Test the program with `hour = 0`.
3. Test the program with `hour = 7`.
4. Test the program with `hour = 12`.
5. Test the program with `hour = 18`.
6. Fix the final `else` so evening hours print `"Good evening"`.
7. Replace the hardcoded `hour` value with user input.

### Expected outcome

The learner should understand how to build a multi-branch decision system using `if`, `else if`, and `else`.


## Project 1: Personal Greeting App

Build a console app that:

1. Asks for the user’s first name.
2. Asks for the user’s age.
3. Prints a greeting using the name.
4. Prints whether the user is 18 or older.

Example:

```text
Enter your name:
Alex
Enter your age:
20
Hello Alex!
You are an adult.
```

### Concepts practiced

* `Console.WriteLine`
* `Console.ReadLine`
* `string`
* `int`
* `int.Parse`
* `if/else`

---

## Project 2: Four-Operation Calculator

Build a calculator that:

1. Asks for two numbers.
2. Asks for an operator: `+`, `-`, `*`, or `/`.
3. Performs the chosen operation.
4. Prints the full calculation.
5. Prevents division by zero.
6. Shows decimal answers for division.

Example:

```text
Enter first number:
10
Enter second number:
4
Choose operation (+, -, *, /):
/
10 / 4 = 2.5
```

### Concepts practiced

* Variables
* Arithmetic operators
* String comparison
* `if/else if/else`
* Division by zero
* `double`
* Explicit casting

---

## Project 3: Odd or Even Checker

Build a program that:

1. Asks the user for a number.
2. Converts the input to an `int`.
3. Uses modulo `%` to check whether the number is odd or even.
4. Prints the result.

Example:

```text
Enter a number:
7
The number is odd.
```

### Concepts practiced

* `Console.ReadLine`
* `int.Parse`
* `%`
* `==`
* `if/else`

---

## Project 4: Time-Based Greeting App

Build a program that:

1. Asks the user to enter an hour from `0` to `23`.
2. Converts the input to an `int`.
3. Prints `"Invalid time!"` if the hour is below `0` or above `23`.
4. Prints `"Good night"` for `0` through `6`.
5. Prints `"Good morning"` for `7` through `11`.
6. Prints `"Good afternoon"` for `12` through `17`.
7. Prints `"Good evening"` for `18` through `23`.

Example:

```text
Enter hour:
18
Good evening
```
