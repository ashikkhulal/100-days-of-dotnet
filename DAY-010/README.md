# DAY-010:

## if, else if, else statement:

The if statement contains a boolean condition followed by a single or multi-line code block to be executed. At runtime, if a boolean condition evaluates to true, then the code block will be executed, otherwise not.

Multiple else if statements can be used after an if statement. It will only be executed when the if condition evaluates to false. So, either if or one of the else if statements can be executed, but not both.

The else statement can come only after if or else if statement and can be used only once in the if-else statements. The else statement cannot contain any condition and will be executed when all the previous if and else if conditions evaluate to false.

## Difference between && and &:

Compiler checks all conditions with `&` during runtime.
Compiler checks just first false conditions with `&&` during runtime.

## Difference between || and |:

Compiler checks all conditions with `|` during runtime.
Compiler checks just first true conditions with `||` during runtime.