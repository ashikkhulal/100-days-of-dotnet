# DAY-004:

## Escape Sequence:

The complete set of escape sequences is as follows:

- \' - single quote, needed for character literals
- \" - double quote, needed for string literals
- \\ - backslash
- \0 - Unicode character 0
- \a - Alert (character 7)
- \b - Backspace (character 8)
- \f - Form feed (character 12)
- \n - New line (character 10)
- \r - Carriage return (character 13)
- \t - Horizontal tab (character 9)
- \v - Vertical tab (character 11)
- \uxxxx - Unicode escape sequence for character with hex value xxxx
- \xn[n][n][n] - Unicode escape sequence for character with hex value nnnn (variable length version of \uxxxx)
- \Uxxxxxxxx - Unicode escape sequence for character with hex value xxxxxxxx (for generating surrogates)

## Verbatim Literal:

Verbatim literal, is a string with an `@` symbol prefix, as in `@"Hello"`.

Verbatim literals make escape sequences translate as normal printable characters to enhance readability.

Example:

```
string Path = "C:\\Users\\ashik\\Desktop\\Repos\\Kudvenkat Csharp Course\\DAY-004";
Console.WriteLine("File Path: {0}", Path);
string VerbatimLiteralPath = @"C:\Users\ashik\Desktop\Repos\Kudvenkat Csharp Course\DAY-004";
Console.WriteLine("File Path (with verbatim literal): {0}", VerbatimLiteralPath);
```