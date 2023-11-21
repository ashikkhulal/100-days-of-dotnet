# DAY-049:

## Access modifiers:

In C# there are five different access modifiers:
1. Private
2. Protected
3. Internal
4. Protected Internal
5. Public

Type members can have all the access modifiers, whereas types can have only 2 (internal, public) of the 5 access modifiers.

## Private, public and protected:

Private members are available only within the containing type, whereas public members are available anywhere; there is no restriction.

Protected members are available within the containing type and to the types that derive from the containing type.


|Access Modifiers|Accessibility|
|-|-|
|Private|Only with in the containing class|
|Public|Anywhere, no restrictions|
|Protected|Within the containing types, and the types derived from the containing type|
