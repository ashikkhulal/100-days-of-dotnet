# DAY-097:

## Performance implications of a multithreaded program:

On a machine that has multiple processors, multiple threads can execute application code in parallel on different cores. For example, if there are two threads and two cores, then each thread would run on an individual core. This means, performance is better.

If two threads take 10-milli-seconds each to complete, then on a machine with two processors, the total time taken is 10 milli-seconds.

On a machine that has a single processor, multiple threads execute, one after the other or wait until one thread finishes. It is not possible for a single processor system to execute multiple threads in parallel. Since the operating system switches between the threads so fast, it gives us the illusion that the threads run in parallel. On a single core / processor machine, multiple threads can affect performance negatively as there is overhead involved with context-switching.

If two threads take 10 milli-seconds each to complete, then on a machine with 1 processor, the total time taken is 20 milli-seconds + (thread context switching time, if any).