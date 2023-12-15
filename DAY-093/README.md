# DAY-093:

## Protecting shared resources:

**What happens if shared resources are not protected from concurrent access in multithreaded program?**

The output or behaviour or the program can become inconsistent if the shared resources are not protected from concurrent access in multithreaded program.

**How to resove it?**

**Approach 1**: Using Interlocked.Increment() method.

**Approach 2**: Using locking.

**Which option is better?**

From a performance perspective, using Interlocked class is better over using locking. Locking locks out all the other threads except a single thread to read and increment the Total variable. This will ensure that the Total variable is updated safely. The downside is that since all the other threads are locked out, there is a performance hit.

The interlocked class can be used with addition / subtraction (increment, decrement, add, etc.) on and int or long field. The Interlocked class has method for incrementing, decrementing, adding, and reading variables automatically.