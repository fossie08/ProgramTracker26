Imports System

Module Program
    Sub Main(args As String())
        Dim d As Int16 = 1
        Dim e As Int16 = 1
        Dim string1 As String
        Dim string2 As String
        Dim alpha As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim alphabet(27) As String
        Dim alphabet1(27) As Int16
        Dim alphabet2(27) As Int16

        For Each c As Char In alpha
            alphabet(d) = c
            d = d + 1
        Next

        Console.WriteLine("Please enter a word ")
        string1 = Console.ReadLine()
        Console.WriteLine("Please enter a word ")
        string2 = Console.ReadLine()

        For Each c As Char In string1
            If c = alphabet(e) Then
                alphabet1(e) = alphabet1(e) + 1
                e = e + 1
            End If
        Next

        For c = 1 To 27
            Console.WriteLine(alphabet1(c))
        Next

    End Sub
End Module
