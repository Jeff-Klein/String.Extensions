
# String.Extensions
<h2>This library helps you with String manipulation, avoiding repetitive syntax and regex use. All methods extend from default String type.</h2>

To download String.Extensions, using the Package Manager Console, type:

<b>Install-Package String.Extensions</b>

Or using the Nuget Package Manager, search for <i>String.Extensions</i>.

![Alt text](/String.Extensions/img/nuget_download.png?raw=true "Nuget Package")

Current methods avaliable are:

| Method  | Description | Parameters |
| ------------- | ------------- | ------------- |
| String.Remove(params string[] toRemove)  | This method allows you to pass multiple Strings to be removed  | <i>toRemove</i>: List of values to be removed. |
| String.Remove(bool ignoreCase, params string[] toRemove) | Replaces multiple elements with one same element specified. Case will be considered.  | <i>ignoreCase</i>: Ignore the case of the value to be removed. </br><i>toRemove</i>: List of values to be removed. |
| RemoveAllNumbers() | Removes all numbers, keeping alphabetical letters and special characters. ||
| RemoveAllSpecialCharacters() | Removes all special characters, keeping alphabetical letters and numbers. ||
| RemoveAllAlphabeticalLetters() | Removes all alphabetical letters, keeping special characters and numbers. ||
| Replace(string replacerString, params string[] toReplace)| Replaces multiple elements with one same element specified. Case will be considered. | <i>replacerString</i>: New value. </br><i>toReplace</i>: List of old values|
| Replace(bool ignoreCase, string replacerString, params string[] toReplace)| Replaces multiple elements with one same element specified. Case can be considered or not. | <i>ignoreCase</i>: Ignore the case of the old value. </br><i>replacerString</i>: New value. </br><i>toReplace</i>: List of old values |
| KeepOnlyNumbers() | Keeps all numbers, removing alphabetical letters and special characters. ||
| KeepAllSpecialCharacters() | Keeps all special characters, removing alphabetical letters and numbers. ||
| KeepOnlyAlphabeticalLetters() | Keeps all alphabetical letters, removing special characters and numbers. ||

More methods will be added soon!


<b>Feel free to fork and help improve this library.</b>


