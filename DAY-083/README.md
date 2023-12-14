# DAY-082:

## Generic Stack collection class:

Stack is a generic LIFO (Last In First Out) collection class that is present in System.Collections.Generic namespace. 

The stack collection class is analogous to a stack of plates. If you want to add a new plate to the stack of plates, you place it on top of all the already existing plates. If you want to remove a plate from the stack, you will first remove the one that you have last added.

The Stack collection class operates in a similar fashion. The last item to be added(pushed) to the queue, will be the first item to be removed(popped) from the queue.

## Useful functions in Stack collection class:

`To add items to the top of the stack, use Push() method.`

`To remove an item that is present at the top of the stack, use Pop() method.`

A foreach loop iterates through the items in the stack, but will not remove them from the stack. The items from the stack are retrieved in LIFO (Last In First Out) order. The last element added to the stack is the first one to be returned.

`To check if an item exists in the stack, use Contains() method.`

**Difference between Pop() and Peek() methods**: `Pop()` method removes and returns the item at the top of the stack, whereas `Peek()` returns the item at the top, without removing it.