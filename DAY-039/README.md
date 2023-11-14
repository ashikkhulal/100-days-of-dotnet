# DAY-039:

## Multicast delegates:
A multicast delegate is a delegate that has references to more than one function. When you invoke a multicast delegate, all the functions the delegate is pointing to, are invoked.

## Different ways to create a multicast delegate:
There are two approaches to create a multicast delegate. Depending on the approach you use:
`+` or `+=` to register a method with the delegate
`-` or `-=` to un-register a method with the delegate

*Note: A multicast delegate, invokes the methods in the invocation list, in the same order in which they are added.*

## What happens if a multicast delegate returns a value:
If the delegate has a return type other than void and if the delegate is a multicast delegate, only the value of the last invoked method will be returned. Along the same lines, if the delegate has an out parameter, the value of the output parameter, will be the value assigned by the last method.

Common interview question - **Where do you use multicast delegates?**
Multicast delegate makes implementation of observer design pattern very simple. Observer pattern is also called as publish/subscribe pattern.