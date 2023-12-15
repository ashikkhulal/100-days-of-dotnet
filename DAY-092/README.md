# DAY-092:

## Thread.Join:
Join blocks the current thread and makes it wait until the thread on which Join method is invoked completes. Join method also has a overload where we can specify the timeout. If we don't specify the timeout, the calling thread waits indefinitely, until the thread on which Join() is invoked completes. This overloaded Join(int millisecondsTimeout) method returns boolean; true if the thread has terminated otherwise false.

Join is particularly useful when we need to wait and collect results from a thread execultion or if we need to do some clean-up after the thread has completed.

## Thread.IsAlive:
Returns true if the thread is still executing, otherwise false.
