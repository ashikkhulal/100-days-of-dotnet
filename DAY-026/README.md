# DAY-026:

## Why Properties:

Marking the class fields public and exposing to the external world is bad, as you will not have control over what gets assigned and returned.

```
using System;

public class Program
{
    public static void Main()
    {
        Student S1 = new Student();
        S1.ID = -10;
        S1.Name = null;
        S1.PassMark = 0;

    }
}

public class Student
{
    public int ID;
    public string Name; 
    public int PassMark = 35;
}
```

**Problems above with public fields:**
- ID should always be non negative number
- Name cannot be set to NULL
- If student name is missing "No Name" should be returned
- PassMark should be readonly.

**Getters and setters methods:**
Programming languages that does not have properties use getter and setter methods to encapsulate and protect fields.

In our example, we use SetId(int id) and GetId() methods to encapsulate _id class field. As a result, we have better control over what gets assigned and returned from the _id field.

Encapsulation is one of the primary pillars of object oriented programming.