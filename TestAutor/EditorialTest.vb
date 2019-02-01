Imports Final2018
Module EditorialTest
    Sub main()
        Try
            Dim autor1 As New Autor(34367714, "sebastian")
            Dim editor1 As New Editor(34367714, "Jose")
            Dim borrador1 As New Borrador("El Libro de la selva", 5000)
            Dim libro1 As New Libro("ASD1234", "El Libro de la selva", 5000)

            Material.PorcentajeEditorPorBorrador = 50
            Material.PorcentajeEditorPorLibro = 30


            Console.WriteLine("Get Autor DNI")
            Console.WriteLine(Editorial.GetAutor(34367714))

            Console.WriteLine("Get autor por nombre")
            For Each persona In Editorial.GetAllMateriales("pepe")
                Console.WriteLine(persona)
            Next
            For Each empleado In Editorial.GetAllEmpleados
                Console.WriteLine(empleado.ToString)
            Next

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try

    End Sub

End Module
