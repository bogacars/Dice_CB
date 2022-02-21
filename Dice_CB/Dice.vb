'Carson Bogart
'RCET 0265
'Spring 22
'Roll the dice
'



Option Explicit On
Option Strict On
Module Dice

    Sub Main()
        Dim randomNumbers(7) As Integer
        Dim temp As String
        Dim seperator As String = " |"
        Dim columnLength As Integer = 6
        Dim lineSeperator As String = "-"
        Dim hamburger As Integer = columnLength * (UBound(randomNumbers) + 1)


        'count random numbers
        For i = 1 To 10000

            randomNumbers(GetRandomInteger()) += 1
        Next

        'display random count
        'header for array
        For i = LBound(randomNumbers) To UBound(randomNumbers)
            temp = CStr(i) & seperator
            temp = temp.PadLeft(columnLength)
            Console.Write(temp)
        Next
        Console.WriteLine()
        'seperation line
        Console.WriteLine(StrDup(hamburger, lineSeperator))
        'display contents of randomNumbers() array
        For i = LBound(randomNumbers) To UBound(randomNumbers)
            temp = CStr(randomNumbers(i)) & seperator
            temp = temp.PadLeft(columnLength)
            Console.Write(temp)
        Next
        Console.WriteLine()
        'seperation line
        Console.WriteLine(StrDup(hamburger, lineSeperator))







        Console.Read()
    End Sub

    Function GetRandomInteger() As Integer
        Dim value As Integer
        Dim temp As Single
        Randomize() 'add better seed arguemnet
        temp = (Rnd() * 7) + 1
        value = CInt(System.Math.Floor(CDbl(temp)))

        'Console.WriteLine(temp)
        'Console.WriteLine(value)
        'Dim value As Integer = CInt(Int((6 * Rnd()) + 1))

        Return value
    End Function
End Module


