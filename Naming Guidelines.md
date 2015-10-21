# Naming Guidelines

&#10003; **DO** use PascalCasing (capitalize the first letter of each word) for
all identifiers except parameter names. For example, use `TextColor` rather than
`Textcolor` or `Text_Color`.

&#10003; **DO** use camelCasing (capitalize first letters of each word except
for the first word) for all member parameter names. prefix descriptive type
parameter names with `T`.

```CSharp
public interface ISessionChannel<TSession> where TSession : ISession
{
    TSession Session { get; }
}
```

&#10003; **DO** use `_camelCase` for private fields.


&#10003; **CONSIDER** using `T` as the type parameter name for types with one
single letter type parameter.

&#10003; **DO** use PascalCasing or camelCasing for any acronyms over two
characters long. For example, use `HtmlButton` rather than `HTMLButton`, but
`System.IO` instead of `System.Io`.

&#10007; **DO NOT** use acronyms that are not generally accepted in the field.

&#10003; **DO** use well-known acronyms only when absolutely necessary. For
example, use `UI` for User Interface and `Html` for Hyper-Text Markup Language.

&#10007; **DO NOT** use underscores, hyphens, or any other non-alphanumeric
characters. This is incorrect: `public string Full_Name { get; }`

&#10007; **DO NOT** use the Hungarian notation.

&#10003; **DO** name types and properties with nouns or noun phrases.

&#10003; **DO** name methods and events with verbs or verb phrases. Always give
events names that have a concept of before and after using the present particle
and simple past tense. For example, an event that is raised before a `Form`
closes should be named `Closing`. An event raised after a `Form` is closed
should be named `Closed`.

&#10007; **DO NOT** use the `Before` or `After` prefixes to indicate pre and
post events.

&#10003; **DO** use the following prefixes:
* `I` for interfaces.
* `T` for generic type parameters (except single letter parameters).

&#10003; **DO** use the following postfixes:

* `Exception` for types inheriting from `System.Exception`.
* `Collection` for types implementing `IEnumerable`.
* `Dictionary` for types implementing `IDictionary` or `IDictionary<K,V>`.
* `EventArgs` for types inheriting from `System.EventArgs`.
* `EventHandler` for types inheriting from `System.Delegate`.
* `Attribute` for types inheriting from `System.Attribute`.
* `Async` for async methods.

&#10007; **DO NOT** use the postfixes listed above for any other types.

&#10007; **DO NOT** postfix type names with `Flags` or `Enum`.

&#10003; **DO** use plural noun phrases for flag enums (enums with values that
support bitwise operations) and singular noun phrases for non-flag enums.

&#10003; **DO** use the following template for naming namespaces:

    <Company>.<Technology>[.<Feature>].

For example, `Microsoft.Office.ClipGallery`. Operating System components should
use System namespaces instead for the <Company> namespaces.

&#10007; **DO NOT** use organizational hierarchies as the basis for namespace
hierarchies. Namespaces should correspond to scenarios regardless of what teams
contribute APIs for those scenarios.
