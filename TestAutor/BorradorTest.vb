Imports Final2018
Module BorradorTest
    Sub main()
        Try
            'ok'
            Dim autor1 As New Autor(34367714, "josee")

            Dim borrador1 As New Borrador("el libro de la selva", 5000)
            Material.PorcentajeEditorPorBorrador = 50
            Console.WriteLine(borrador1.MontoContrato)

            Console.WriteLine(borrador1.toString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
        Try
            'no'
            Dim borrador1 As New Borrador("el", 5000)
            Console.WriteLine(borrador1.toString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub
End Module
