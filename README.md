
# String.Extensions
<h2>These library helps you with String manipulation, avoiding repetitive syntax and regex use.</h2>

To download String.Extensions, using the Package Manager Console, type:

Install-Package String.Extensions

Or using the Nuget Package Manager, search for "String.Extensions".

![Alt text](/String.Extensions/img/nuget_download.png?raw=true "Nuget Package")

Current methods avaliable are:

| Method  | Description | Parameters |
| ------------- | ------------- | ------------- |
| String.Remove(params string[] toRemove)  | This method allows you to pass multiple Strings to be removed  | <i>toRemove</i>: List of values to be removed. |
| String.Remove(bool ignoreCase, params string[] toRemove) | Replaces multiple elements with one same element specified. Case will be considered.  | <i>ignoreCase: Ignore the case of the value to be removed. </i> <i>toRemove</i>: List of values to be removed. |

String.Remove:

This method allows you to pass an array of Strings to be removed.

![Alt text](/String.Extensions/img/overload1.png?raw=true "First Overload")

You can also pass a boolean value to rather ignore case or not. If you don't pass this parameter, case will be considered by default.

![Alt text](/String.Extensions/img/overload2.png?raw=true "Second Overload")

More methods will be added soon!


<b>Feel free to fork and help improve this library.</b>


