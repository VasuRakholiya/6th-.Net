Module Module1

    Sub Main()


        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Console.WriteLine("enter value in a,b,c,d...")
        a = Convert.ToInt32(Console.ReadLine())
        b = Convert.ToInt32(Console.ReadLine())
        c = Convert.ToInt32(Console.ReadLine())
        d = Convert.ToInt32(Console.ReadLine())

        If a > b AndAlso a > c AndAlso a > d Then
            Console.WriteLine("{0} is larger...", a)
            If b > c AndAlso b > d AndAlso b > a Then
                Console.WriteLine("b is larger", b)
                If c > d AndAlso c > b AndAlso c > a Then
                    Console.WriteLine("c is larger", c)
                End If
            End If
        Else
            Console.WriteLine("d is larger", d)
        End If

        Console.ReadLine()
    End Sub

End Module
