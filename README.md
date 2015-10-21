# C# code conventions

- The only valid measurement of code quality: WTFs/minute
- Always code as if the guy who ends up maintaining your code will be a violent psychopath who knows where you live
- Do not write "smart" code that is difficult to read by others.
- The Boy Scout Rule: "Leave the campground cleaner than you found it".

## Why do we need this

Coding conventions serve the following purposes:
- They create a consistent look to the code, so that reeaders can focus on content, not layout.
- They enable readers to understand the code more quickly by making assumptions based on previous experience.
- They facilitate copying, changing, and maintaining the code.
 
## Formatting

Use **utf-8** charset for all files in the project. Use **4 space indentation** for *.cs files in the project. 
Please use [EditorConfig plugin](http://editorconfig.org/#download) for your IDE to automatically set these settings for your project.

*A tab could be a different number of columns depending on your environment, but a space is always one column.
In terms of how many spaces (or tabs) constitutes indentation, it's more important to be consistent throughout your code than to use any specific tab stop value. According to some research done by folks (who tend to research these kinds of things), 6 spaces obscures reading of the code and makes it harder to read. Similar is the case with 2 spaces. 4 spaces is said to be optimum for reading clarity and understanding the logical hierarchy of a program at a glance. See discussion [here](http://programmers.stackexchange.com/questions/57/tabs-versus-spaces-what-is-the-proper-indentation-character-for-everything-in-e) and [here](http://stackoverflow.com/questions/4802381/why-4-spaces-are-used-as-the-unit-of-indentation-in-java)*

## Layout

- Use separate file for each entity (class, interface, enum) unless it's logically necessary. *When designing classes we respect the Single Responsibility Principle. Reading code becomes a lot easier if its shape follows its semantics, hence splitting files by class is sensible. See discussions [here](http://stackoverflow.com/questions/144783/c-sharp-classes-in-separate-files) and [here](http://programmers.stackexchange.com/questions/53088/multiple-classes-in-a-single-cs-file-good-or-bad).*
- Don't use **#region** and **#endregion** directives. *See [discussion](http://programmers.stackexchange.com/questions/53086/are-regions-an-antipattern-or-code-smell).*
- Write only one statement/declaration per line.
- Add at least one blank line between method definitions, property definitions, constructors etc.

```
public class Example
{
    public Example() 
    {
        IsActive = true;
    }
    
    public string IsActive { get; set; }
  
    public void Write(char value) 
    {
        if (IsActive) 
        {
            Console.WriteLine(value);
        }
    }
}
```

## Сurly brackets
- Always use curly brackets even for one line code, place your statement on the next line:
```C#
if (a == "b") 
{
    Consloe.WriteLine("A equals to B");
    return;
}
```

- Note: for one line null-checks with exception throw statement it's allowed to use the same line.
```C#
if (catalogManager == null)  { throw new ArgumentNullException(nameof(catalogManager)); }
```

*Skimping on braces might save you a few keystrokes the first time, but the next coder who comes along, adds something to your else clause without noticing the block is missing braces is going to be in for a lot of pain.* See discussions [here](http://programmers.stackexchange.com/questions/2715/should-curly-braces-appear-on-their-own-line) and [here](http://stackoverflow.com/questions/359732/why-is-it-considered-a-bad-practice-to-omit-curly-braces)

## Naming Guidelines

Use [Naming Guidelines](https://github.com/PressReader/code-conventions/blob/master/Naming%20Guidelines.md) document. 
*The document is based on [Microsoft Framework Naming Guidelines](https://msdn.microsoft.com/en-us/library/ms229002(v=vs.110).aspx).*


## Use C# type keywords in favor of .NET type names

When using a type that has a C# keyword the keyword is used in favor of the .NET type name. For example, these are correct:

```
public string TrimString(string s) {
    return string.IsNullOrEmpty(s)
        ? null
        : s.Trim();
}

var intTypeName = nameof(Int32); // can't use C# type keywords with nameof
```

The following are incorrect:

```
public String TrimString(String s) {
    return String.IsNullOrEmpty(s)
        ? null
        : s.Trim();
}
```
*There is no diference between `System.String` and `string`, we decided to use `string` for consitentency*

## Class members

- Avoid `this.` unless absolutely necessary.
- Always specify member visiblity, even if it's the default (i.e. `private string foo;` not `string _foo;`).
- Classes member should be alphabetized, and grouped into sections:

0. Constant Fields
0. Fields
0. Constructors and Finalizers
0. Delegates and Events
0. Properties and Indexers
0. Methods
0. Nested Structs and Classes

Within each of these groups order by access:

0. public
0. internal
0. protected
0. private

*These are from `StyleCop Rules Documentation`, see [discussion](http://stackoverflow.com/questions/150479/order-of-items-in-classes-fields-properties-constructors-methods)*

## Use only complete words or common/standard abbreviations in public APIs

Public namespaces, type names, member names, and parameter names must use complete words or common/standard abbreviations.

These are correct:

```
public void AddReference(AssemblyReference reference);
public EcmaScriptObject SomeObject { get; }
```

These are incorrect:

```
public void AddRef(AssemblyReference ref);
public EcmaScriptObject SomeObj { get; }
```


## Implicitly Typed Local Variables

- Use `var` wherever it possible instead of explicit type.
- Do not include the type of the variable in it's name.

```
var lines = new List<string>();
```
*It makes code more readable. When dealing with interfaces, you are emphatically not interested in the type a variable has. See [discussion](http://stackoverflow.com/questions/41479/use-of-var-keyword-in-c-sharp)*

## Comments
- Don't comment redundant code, not used code should be removed.
- Place the comment on a separate line, not at the end of a line of code.
- Insert one space between the comment delimiter (//) and the comment text, as shown in the following example.
```
// Region of the default user, used for test purposes
private const long RegionId = 1231231;
```
- For xml comments begin comment text with an uppercase letter and end with a period.
```
/// <summary>
/// Generates slugged URL from a string value.
/// </summary>
public static string GenerateSlug(string value)
```
