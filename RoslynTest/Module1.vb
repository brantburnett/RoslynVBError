Module Module1

    Sub Main()
        Try
            Dim temp = ClassWithStaticField.Dictionary

            Console.WriteLine(temp("String1"))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadLine()
    End Sub

End Module
