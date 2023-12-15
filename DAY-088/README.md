# DAY-088:

## Purpose of ThreadStart Delegate:

```
Thread T1 = new Thread(Number.PrintNumbers);
T1.Start();
```

We can rewrite above line using ThreadStart delegate as shown below:

```
Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));
T1.Start();
```

**Wht a delegate needs to be passed as a parameter to the Thread class constructor?**

The purpose of creating a thread is to execute a function. A delegate is a type safe function pointer, meaning it points to a function that the thread has to execute. In short, all threads require an entry point to start execution. Any thread you create will need an explicitly defined entry point, i.e. a pointer to the function where they should begin execution. So threads always require a delegate.

**In the first code, we are not explicitly creating the ThreadStart delegate, then how is it working here?**

It's working in spite of not creating the ThreadStart delegate explicitly because the framework is doing it automatically for us.

We can also rewrite the second above code using delegate() keyword:

`Thread T1 = new Thread(delegate() { Number.PrintNumbers(); }) ;`

Or even using lambda expression:

`Thread T1 = new Thread(()=> Number.PrintNumbers()) ;`

Also, thread function need not be a static function always. It can also be a non-static function, in which case, we can create an instance of the class and use that to call the method.