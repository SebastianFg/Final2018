Imports Final2018
Module AutorTest
    Sub Main()
        Try
            ''correcto
            Dim autor1 As New Autor(34367714, "Jose")

            Console.WriteLine(autor1.ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
        Try
            'error
            Dim autor2 As New Autor(34367714, "os")

            Console.WriteLine(autor2.ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try

    End Sub

End Module
