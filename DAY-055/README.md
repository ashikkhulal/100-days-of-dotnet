# DAY-055:

## Early binding vs late binding:

- Early binding can flag errors at compile time. With late binding, there is a risk of run time exceptions
- Early binding is much better for performance and should always be preferred over late binding. Use late binding only when working with an object(s) that are not available at compile time.

## Late binding using reflection:

Early binding example:

```
Customer C1 = new Customer();
string C1FullName = C1.GetFullName("John", "Doe");
Console.WriteLine("Full Name = {0}", C1FullName);
```

Late binding example:

```
Assembly executingAssembly = Assembly.GetExecutingAssembly();
Type businessType = executingAssembly.GetType("ConsoleApp.Business");
object businessInstance = Activator.CreateInstance(businessType);
MethodInfo getMethodName = businessType.GetMethod("GetFullCompanyName");
string[] parameters = new string[2];
parameters[0] = "Apple";
parameters[1] = "Inc.";
string fullCompanyName = (string)getMethodName.Invoke(businessInstance, parameters);
Console.WriteLine("Full Company Name = {0}", fullCompanyName);
```


