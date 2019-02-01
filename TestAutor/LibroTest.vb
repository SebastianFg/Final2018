Imports Final2018
Module LibroTest
    Sub main()
        Try
            Dim libro1 As New Libro("ASD1234", "El Libro de la selva", 5000)
            Console.WriteLine(libro1.toString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally

            Console.ReadKey()
        End Try

    End Sub
End Module
