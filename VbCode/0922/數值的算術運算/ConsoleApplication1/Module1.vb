Module Module1

    Sub Main()

        Dim X, Y As Single
        Console.WriteLine("===數值的算術運算===")
        Console.Write("數值X=")
        X = Console.ReadLine
        Console.Write("數值Y=")
        Y = Console.ReadLine
        Console.WriteLine(X & "^" & Y & "=" & X ^ Y)
        Console.WriteLine(X & "*" & Y & "=" & X * Y)
        Console.WriteLine(X & "/" & Y & "=" & X / Y)


        Console.WriteLine(X & "\" & Y & "=" & X \ Y)
        Console.WriteLine(X & "mod" & Y & "=" & X Mod Y)
        Console.WriteLine(X & "+" & Y & "=" & X + Y)
        Console.WriteLine(X & "-" & Y & "=" & X - Y)
        Y = Console.ReadLine

    End Sub

End Module
