# DAY-051:

## Access modifiers for types:

You have 5 access modifiers (`Private, Public, Protected, Internal and Protected Internal`) with type members, but types allow only `internal, and public` access modifiers. It is a compile time error to use private, protected and protected internal access modifiers with types.

|Access Modifier|Accessibility|
|-|-|
|Private|Only within the containing class(**Default for type members**)|
|Public|Anywhere, no restrictions|
|Protected|Within the containing types and types derived from the containing type|
|Internal|Anywhere within the containing assembly(**Default for types**)|
|Protected Internal|Anywhere within the conatining assembly, and from within a derived class in any other assembly|

