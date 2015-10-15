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
 
## Design Guidelines

All `PressReader` projects should follow [Microsoft Framework Design Guidelines](https://msdn.microsoft.com/en-us/library/ms229042.aspx). In addition to this document we agree to follow coding conventions below. Microsoft Framework Design Guidelines is one [most popular](http://www.marlabs.com/top-seven-coding-standards-and-guideline-documents-cnet-developers) code conventions.

## Formatting

Use **utf-8** charset for all files in the project. Use **4 space indentation** for *.cs files in the project. 
Please use [EditorConfig plugin](http://editorconfig.org/#download) for your IDE to automatically set these settings for your project.

## Layout

- Use separate file for each entity (class, interface, enum) unless it's logically necessary.
- Don't use **#region** and **#endregion** directives
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


## Implicitly Typed Local Variables

- Use `var` wherever it possible instead of explicit type.
- Do not include the type of the variable in it's name.

```
var z = new List<string>();
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
