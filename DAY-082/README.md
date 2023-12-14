# DAY-082:

## Generic Queue collection class:

Queue is a generic FIFO (First In First Out) collection class that is present in System.Collections.Generic namespace. 

The Queue collection class is analogous to a queue at the ATM machine to withdraw money. The order in which people queue up, will be the order in which they will be able to get out of the queue and withdraw money from the ATM.

The Queue collection class operates in a similar fashion. The first item to be added(enqueued) to the queue, will be the first item to be removed(dequeued) from the queue.

## Useful functions in Queue collection class:

`To add items to the end of the queue, use Enqueue() method.`

`To remove an item that is present at the beginning of the queue, use Dequeue() method.`

A foreach loop iterates through the items in the queue, but will not remove them from the queue.

`To check if an item exists in the queue, use Contains() method.`

**Difference between Dequeue() and Peek() methods**: `Dequeue()` method removes and returns the item at the beginning of the queue, whereas `Peek()` returns the item at the beginning, without removing it.