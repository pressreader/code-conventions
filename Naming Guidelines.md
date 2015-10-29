# Naming Guidelines

&#10003; **DO** use PascalCasing (capitalize the first letter of each word) for all identifiers except parameter names, local variables and private fields. See [Example](https://github.com/PressReader/code-conventions/blob/5-naming-protected/Sample.cs)

```Csharp
public string FirstName { get; }
```

&#10007; **DO NOT** use underscores, hyphens, or any other non-alphanumeric characters. This is incorrect:

```Csharp
public string Full_Name { get; }
public string Full__name { get; }
```

&#10007; **DO NOT** use underscore as variable name. This is incorrect:

```CSharp
new Timer((_) => DownloadNewspapersInfo(), null, null);
task.ContinueWith((_) => _activeTasks.Release());
```

&#10003; **DO** use camelCasing (capitalize first letters of each word except for the first word) and add **underscore** to private fields.

```CSharp
private bool _isActive;
private IService _service;
```

&#10003; **Consider** using `T` as the type parameter name for types with one single letter type parameter.

```CSharp
public class AzureQueue<T> : IAzureQueue<T> { }
```

&#10003; **DO** use PascalCasing or camelCasing for any acronyms over two
characters long. For example, use `HtmlButton` rather than `HTMLButton`, but
`System.IO` instead of `System.Io`.


&#10007; **DO NOT** use the Hungarian notation. This is incorrect:

```Csharp
public bool bIsActive { get; }
public bool objValue { get; }
```

&#10003; **DO** use the following prefixes:
* `I` for interfaces.
* `T` for generic type parameters (except single letter parameters).

```CSharp
public interface ISessionChannel<TSession> where TSession : ISession
{
    TSession Session { get; }
} 
```

&#10003; **DO** use the following postfixes:

* `Exception` for types inheriting from `System.Exception`.
* `Collection` for types implementing `IEnumerable`.
* `Dictionary` for types implementing `IDictionary` or `IDictionary<K,V>`.
* `EventArgs` for types inheriting from `System.EventArgs`.
* `EventHandler` for types inheriting from `System.Delegate`.
* `Attribute` for types inheriting from `System.Attribute`.
* `Async` for async methods.

&#10007; **DO NOT** postfix type names with `Flags` or `Enum`. This is incorrect:

```Csharp
public enum LayoutOptionsFlags { ... }
public enum LayoutOptionsEnum { ... }
```

&#10003; **DO** use plural noun phrases for flag enums (enums with values that
support bitwise operations) and singular noun phrases for non-flag enums.

```CSharp
[Flags]	
public enum ClusterOptions 
{
    ... 
}

public enum StreamType { ... }
```

&#10003; **DO** use the following template for naming namespaces: `<Company>.<Technology>[.<Feature>]`.
For example:

```CSharp
namespace PressReader.Models.TopNewsFeed 
{
   ....
}
```
