Function FizzBuzz(ByVal number As Integer) As Integer
    For i As Integer = 0 to number
        If i Mod 15 = 0 Then
            Console.WriteLine(i + " FizzBuzz")
        ElseIf i Mod 3 = 0 Then
            Console.WriteLine(i + " Fizz")
        ElseIf i Mod 5 = 0 Then
            Console.WriteLine(i + " Buzz")
        Else
            Console.WriteLine(i)
        End If
    Next i
End Function

FizzBuzz(65)