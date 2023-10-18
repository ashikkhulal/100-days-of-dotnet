# DAY-007:

## Implicit conversions:
Implicit conversion is done by the compiler:
- When there is no loss of information if the conversion is done.
- If there is no possibility of throwing exceptions during the conversion

```
int i = 100;
int f = i;
Console.WriteLine("Implicitly converting int type i to float type f: {0}", f);
```

## Explicit conversions:
Whereas when converting a float to an int, we loose the fractional part and also a possibility of overflow exception. Hence, in this case an explicit conversion is required.

For explicit conversion we can use cast operator or the convert class in C#.

```
float x = 123.45f;
int y = (int)x;
//int y = Convert.ToInt32(x);
Console.WriteLine("Explicitly converting float type x to int type y: {0}", y);
```

Cast operator does not throw overflow exception whereas Convert class does if the value is either too large or too small while converting to the target type.

## Difference between Parse() and TryParse():

If the number is in a string format, you have two options:
- Parse(), and
- TryParse()

Parse() method throws an exception if it cannot parse the value, whereas TryParse() returns a bool indicating whether it succeeded or failed.

**Use Parse() if you are sure the value will be valid, otherwise use TryParse().**