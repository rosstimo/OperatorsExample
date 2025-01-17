'Tim Rossiter
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/rosstimo/OperatorsExample.git

Module OperatorsExample

    Sub Main()

        'sum operator
        Console.Write("5 + 3 = ") 'print a string
        Console.WriteLine(5 + 3) 'print the sum 
        Console.WriteLine()

        'difference operator
        Console.Write("5 - 3 = ") 'print a string
        Console.WriteLine(5 - 3) 'print the difference
        Console.WriteLine()

        'multiplication operator
        Console.Write("5 * 3 = ") 'print a string
        Console.WriteLine(5 * 3) 'print the product
        Console.WriteLine()

        'floating point division operator
        Console.Write("5 / 3 = ") 'print a string
        Console.WriteLine(5 / 3) 'print the floating point quotient
        Console.WriteLine()

        'integer division operator
        Console.Write("5 \ 3 = ") 'print a string
        Console.WriteLine(5 \ 3) 'print the  quotient
        Console.WriteLine()

        'modulus operator
        Console.Write("5 mod 3 = ") 'print a string
        Console.WriteLine(5 Mod 3) 'print the  remainder
        Console.WriteLine()

        'exponent operator
        Console.Write("5 ^ 3 = ") 'print a string
        Console.WriteLine(5 ^ 3) 'print exponent
        Console.WriteLine()

        'concatenation operator
        Console.WriteLine("5" & " " & "+" & " 3" & " = " & "8") 'print a string
        Console.WriteLine()
        Console.WriteLine("wake up neo..." & vbNewLine & "follow the white rabbit...")
        Console.WriteLine(StrDup(10, "*"))


    End Sub

End Module
