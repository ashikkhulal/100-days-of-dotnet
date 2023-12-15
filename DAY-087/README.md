# DAY-087:

## Advantages and disadvantages of multithreading:

Advantages:
- To maintain a responsive user interface.
- To make efficient use of processor time while waiting for I/O operations to complete.
- To split large CPU bound tasks to be processed simultaneously on a machine that has multiple processors (cores).

Disadvantages:
- On a single processor (core) machine, threading can affect performance negatively as there is overhead involved with context-switching.
- Have to write more lines of code to accomplish the same task.
- Multi-threaded applications are difficult to write, understand, debug and maintain.

Hence, only use multithreading when the advantages of doing so outweigh the disadvantages.
