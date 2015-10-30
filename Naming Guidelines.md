# Naming Guidelines

&#10003; **DO** use PascalCasing (capitalize the first letter of each word) for all identifiers except parameter names, local variables and private fields. 

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

See all class members usages in one example:
```Csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace PressReader.Naming.Sample
{
    /// <summary>
    /// Sample class.
    /// Use only to check naming conventions.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Private const.
        /// </summary>
        private const string DefaultFirstName = "Anonymus";


        /// <summary>
        /// Protected static field.
        /// </summary>
        protected static string Logger;


        /// <summary>
        /// Private static readonly field.
        /// </summary>
        private static readonly IEnumerable<string> _deniedNames = new[] { "root", "admin" };


        /// <summary>
        /// Private static field.
        /// </summary>
        private static IEnumerable<string> _excludedEmails;


        /// <summary>
        /// Protected internal field.
        /// </summary>
        protected internal string Address;


        /// <summary>
        /// Protected field.
        /// </summary>
        protected string LastName;


        /// <summary>
        /// Private readonly field.
        /// </summary>
        private readonly string _email;


        /// <summary>
        /// Private field.
        /// </summary>
        private string _firstName;


        /// <summary>
        /// Public constructor.
        /// </summary>
        public Person(string firstName, string email)
        {
            if (_excludedEmails.Contains(_email)) { }


            _firstName = firstName ?? DefaultFirstName;
            _email = email;
        }


        /// <summary>
        /// Public property.
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value?.ToLower(); }
        }


        /// <summary>
        /// Protected internal property.
        /// </summary>
        protected internal bool IsDefault => StringComparer.InvariantCultureIgnoreCase.Equals(_firstName, DefaultFirstName);


        /// <summary>
        /// Protected static property.
        /// </summary>
        protected static bool IsInitialized => _excludedEmails != null;


        /// <summary>
        /// Protected property.
        /// </summary>
        protected string FulllName => $"{_firstName} {LastName}";


        /// <summary>
        /// Protected property.
        /// </summary>
        protected virtual bool IsDenied => _deniedNames.Contains(_firstName);


        /// <summary>
        /// Public static method.
        /// </summary>
        public static void Init(IEnumerable<string> excludedEmails)
        {
            _excludedEmails = excludedEmails;
        }


        /// <summary>
        /// Public method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{_firstName}: {_email}";
        }
    }
}
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
