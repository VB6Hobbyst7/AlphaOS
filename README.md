AlphaOS: /README.md
==================

##	master/AlphaOS.sln
The solution file for AlphaOS.

##	master/AlphaOS/AlphaOS.vbproj
The project file for AlphaOS.

##	master/AlphaOS/Kernel.vb
The most important file, containing the main code for the OS. 

###	The `User` Class
```vb
'   A user account class
Public Class User
	Public Name As String
	Public Password As String
	Public CurrentDir As String = "/"
End Class
```
I made this class to define a user account, but currently it gets reset when the OS restarts, because the user properties are set up inside `Kernel.vb` and not a separate, permanent file.

###	The `BeforeRun()` Method
The `BeforeRun()` method and the `Run()` method are the only two things that are already included in `Kernel.vb` when it is created by COSMOS. (Besides some testing print statements) The `BeforeRun()` method is for startup functions and drivers.


### The `Run` Method
The `Run()` method is called after the OS is ready to go. For example, I put some welcoming print statements, a user login function, and a command interpreter in there. This snippet shows the original intended structure of `Kernel.vb`:
```vb
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace OS_Name

	Public Class Kernel
		Inherits Cosmos.System.Kernel

		Protected Overrides Sub BeforeRun()

		'	(Put startup functions/drivers here)

		End Sub

		Protected Overrides Sub Run()

		'	(Start here)

		End Sub

	End Class

End Namespace
```

###	The `GetCommand()` Method
I made the `GetCommand()` method to get command input. When an existing command is entered, it calls the method for that command. 

###	The `DirCmd()` Method


###	The `OpenCmd()` Method

##	master/AlphaOS/AlphaOSBoot.cosmos
There's nothing here yet.

##	master/AlphaOS/AlphaFAT.vb
There's nothing here yet.
