# DAY-099:

## Lambda expressions in C#:

Anonymous methods and Lambda expressions are very similar. Anonymous methods were introduced in C# 2 and Lambda expressions in C# 3.

To find an employee with Id = 1002, using anonymous method:

`Customer customer1002UsingAnynomousMethod = listCustomers.Find(delegate (Customer cust) { return cust.Id == 1002; });`

To find an employee with Id = 1002, using lambda expression:

`Customer customer1002UsingLamdaExpression = listCustomers.Find(cust => cust.Id == 1002);`

You can also explicitly specify the input type, but not required:

`Customer customer1002UsingLamdaExpression = listCustomers.Find((Customer cust) => cust.Id == 1002);`

=> is called lambda operator and read as GOES TO. Notice that with a Lambda expression, you don't have to use the delegate keyword explicitly and don't have to specify the input parameter type explicitly. The parameter type is inferred. Lambda expressions are more convenient to use than anonymous methods. Lambda expressions are particularly helpful for writing LINQ query expressions.

## Lambda expression vs Anonymous methods:

In most of the cases Lambda expressions supersedes anonymous methods. To my knowledge, the only time I prefer to use anonymous methods over lambdas is, when we have to omit the parameter list when its not used within the body.

Anonymous methods allow the parameter list to be omitted entirely when its not used within the body, whereas with lambda expressions this is not the case.

For example, with anonymous method notice that we have omitted the parameter list as we are not using them within the body:

```
Button1.Click += delegate
{
    MessageBox.Show("Button Clicked");
}
```

The above code can be rewritten using lambda expression as shown below. Notice that with lambda we cannot omit the parameter list:

```
Button1.Click += (eventSender, eventArgs) =>
{
   MessageBox.Show("Button Clicked"); 
}
```