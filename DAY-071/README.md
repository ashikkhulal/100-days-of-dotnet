# DAY-071:

## Code snippets in visual studio:

Code snippets are ready-made snippets of code you can quickly insert into your code. To insert code snippets there are several ways
1. Keyboard shortcut: `CTRL K, X`
2. Right click and select "Insert Snippet...", from the context menu
3. Click on Edit - Intellisense - Insert Snippet
4. Use code snippets short cut. For example to use "for loop" code snippet, type "for" and press TAB key twice

Once a code snippet is inserted, the editable fields are highlighted in yellow, and the first editable field is selected automatically. Upon changing the first editable field, press TAB to move to the next editable field. To come to the previous editable field use SHIFT + TAB. Press ENTER or ESC keys to cancel field editing and return the Code Editor to normal.

Code Snippet Types:
**Expansion**: These snippets allows the code snippet to be inserted at the cursor.
**SurroundsWith**: These snippets allows the code snippet to be placed around a selected piece of code.
**Refactoring**: These snippets are used during code refactoring. 

**Surround-with code snippets:**
These snippets surrounds the selected code, with the code snippets code.
1. Select the code to surround, and use keyboard shortcut `CTRL K, S`
2. Select the code to surround, right click and select "Surround with.." option from the context menu
3. Select the code to surround, then click on Edit menu, select "IntelliSense" and then select the "Surround With" command.

Code snippets can be used with any type of applications that you create with visual studio. For example, you can use them with
1. Console applications
2. ASP.NET web applications
3. ASP.NET MVC applications etc..

Code snippets are available for many languages. 

### Code Snippet Manager:
It can be used to Add or remove code snippets. You can also find the following information about a code snippet.
1. Description
2. Shortcut
3. Snippet Type
4. Author

To access code snippet manager, click on "Tools" and then select "Code Snippet Manager". Code snippets are xml files and have .snippet extension.