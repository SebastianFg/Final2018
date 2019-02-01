Imports Final2018
Module EditorTest
    Sub main()
        Try
            'ok'
            Dim editor1 As New Editor(34367714, "jose Juancho")

            Console.WriteLine(editor1.toString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()

        End Try
        Try
            'fallo
            Dim editor2 As New Editor(34367714, "jo")

            Console.WriteLine(editor2.toString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()

        End Try
    End Sub

End Module
