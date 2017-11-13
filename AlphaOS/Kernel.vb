﻿Imports System
Imports System.Collections.Generic
Imports System.Text

'   Build 1001
'   Alpha Pixel Software
'       Jonathan "Hertz"
'       John Paul Rutigliano
'       Epiphan Mushahwar (Zero)

Namespace AlphaOS

    Public Class Kernel
        Inherits Cosmos.System.Kernel

        '   A user account class
        Public Class User

            Public Name As String
            Public Password As String

        End Class
        Public User1 As User

        '   I made this method to parse input for commands and handle them.
        Sub GetCommand()

            Console.Write(User1.Name & " : (directory unknown)>>>")
            Dim Command As String = Console.ReadLine()
            If Command = "dir" Then
                Dir()
            ElseIf Command = "help" Then
                Console.WriteLine("Possible commands:" & vbCrLf & "help: Shows list of commands" & vbCrLf & "dir: displays the files in the current directory")
            Else
                Console.WriteLine("""" & Command & """ is not a valid command or program. ")
            End If

        End Sub

        '   Called when the 'dir' command is entered into the console.
        Sub Dir()



        End Sub

        '   Called when the 'open' command is entered into the console.
        Sub Open()



        End Sub

        Protected Overrides Sub BeforeRun()

            Console.WriteLine("AlphaOS build 1001 boot success. Welcome.")
            Console.WriteLine("By Alpha Pixel Software, 2017. Made with COSMOS." & vbCrLf)

        End Sub

        Protected Overrides Sub Run()

            Dim StillRunning As Boolean = True
            Dim UserAccountNotCreated As Boolean = True
            If UserAccountNotCreated Then

                User1.Name = Console.ReadLine
                User1.Password = Console.ReadLine
                UserAccountNotCreated = False

            End If
            Dim NoUserLoggedIn As Boolean = False
            If NoUserLoggedIn Then
GetUserName:
                Console.Write("Please enter your User Name: ")
                Dim EnteredUserName As String = Console.ReadLine
                If EnteredUserName = User1.Name Then
GetPassword:
                    Console.Write("Please enter your password: ")
                    Dim EnteredPassword As String = Console.ReadLine()
                    If EnteredPassword = User1.Password Then

                        Console.WriteLine("Welcome " & User1.Name & "!")
                        NoUserLoggedIn = False

                    Else

                        Console.WriteLine("The password you entered is incorrect. Please try again.")
                        GoTo GetPassword

                    End If

                Else

                    Console.WriteLine("The User Name you entered does not exist.")
                    GoTo GetUserName

                End If

            End If

GetCommand:
            GetCommand()
            If StillRunning Then
                GoTo GetCommand
            End If

            '   Infinite loop, so system stays alive
            While True
            End While

        End Sub

    End Class

End Namespace
