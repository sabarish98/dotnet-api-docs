﻿' Visual Basic .NET Document

' Illustrate rounding error in Math.Round(Double).
Option Strict On
Module Precision1
    ' <Snippet7>
    Public Sub Example()
        Dim value As Double = 11.1

        Console.WriteLine("{0,5} {1,20:R}  {2,12} {3,15}",
                        "Value", "Full Precision", "ToEven",
                        "AwayFromZero")
        Console.WriteLine()
        For ctr As Integer = 0 To 5
            value = RoundValueAndAdd(value)
        Next
        Console.WriteLine()

        value = 11.5
        RoundValueAndAdd(value)
    End Sub

    Private Function RoundValueAndAdd(value As Double) As Double
        Console.WriteLine("{0,5:N1} {0,20:R}  {1,12} {2,15}",
                        value, Math.Round(value, MidpointRounding.ToEven),
                        Math.Round(value, MidpointRounding.AwayFromZero))
        Return value + 0.1
    End Function

    ' The example displays the following output:
    '       Value       Full Precision        ToEven    AwayFromZero
    '       
    '        11.1                 11.1            11              11
    '        11.2                 11.2            11              11
    '        11.3   11.299999999999999            11              11
    '        11.4   11.399999999999999            11              11
    '        11.5   11.499999999999998            11              11
    '        11.6   11.599999999999998            12              12
    '       
    '        11.5                 11.5            12              12
    ' </Snippet7>
End Module

