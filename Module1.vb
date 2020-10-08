Module Module1
    Public Class TablaMultiplicar
        'en esta clase crearermos un sub para recoger el valor
        ' si el valor es -1  sale del proceso


        Public Sub CargarValor()
            ' declara la valor dentro de a clase 
            Dim valor As Integer

            Do
                Console.SetCursorPosition(10, 5)
                Console.Write("Ingres un valor (-1 para salir): ")
                valor = Console.ReadLine
                If valor <> -1 Then
                    ' es distinto a -1
                    Calcular(valor)



                End If
            Loop While valor <> -1
        End Sub
        Public Sub Calcular(ByVal v As Integer)
            ' declaracion de la variable
            Dim f, Tabla As Integer
            For f = 1 To 10
                Tabla = f * v
                Console.SetCursorPosition(10, 5 + f)
                Console.WriteLine(v & " * " & f & " = " & Tabla)

            Next


        End Sub
    End Class

    Sub Main()
        ' Plantilla Ejercicio19ManualVisualBasic2019conl un menu
        ' con un marco que podras ver como se crear mas rapido lento
        ' segundo aumentes o bajes el valor del for en el metodo Temprizador' progrmama viene de esta web.

        'http://www.tutorialesprogramacionya.com/visualbasicya/detalleconcepto.php?punto=14&codigo=14&inicio=0
        Ejercicio19ManualVisualBasic2019Jorge()


    End Sub
    Sub Ejercicio19ManualVisualBasic2019Jorge()

        Marco()
        'El menu que haty aqui lo puedes modidicarr a tu gusto 
        'Conserva la numeraracion y sustitulle el resto del texto a tus necesidads
        Console.SetCursorPosition(10, 2)
        Console.Write("Ejercicio19ManualVisualBasic2019Jorge")
        Console.SetCursorPosition(5, 5)
        Console.Write("0.- Salida")
        Console.SetCursorPosition(5, 7)
        Console.Write("1.- Mutiplicacion por clase")
        Console.SetCursorPosition(5, 9)
        Console.Write("2. -Opcion 2")
        'Añadrir mas opciones segun vuestras necesidades

        Dim Opcion As Integer
        Dim verdad As Boolean
        ' el sigyiente codigo controla que se introduzca un valor correcto
        Do
            Try
                Console.SetCursorPosition(10, 15)
                Console.Write("elija opcion: ")
                Opcion = Console.ReadLine()
                Eleccion(Opcion)
                verdad = True

            Catch ex As Exception
                Console.SetCursorPosition(10, 17)
                Console.Write("valor introducido no valido")
                verdad = False

            End Try

        Loop Until verdad = True


    End Sub
    Sub Marco()
        Dim Fila As Integer
        Dim Columna As Integer

        For Columna = 0 To 80
            Console.SetCursorPosition(Columna, 0)
            Console.Write("*")
            Temporizador()
            
        Next
        For Fila = 0 To 21
            Console.SetCursorPosition(80, Fila)
            Console.Write("*")
            Temporizador()

        Next
        For Columna = 80 To 0 Step -1

            Console.SetCursorPosition(Columna, 21)
            Console.Write("*")
            Temporizador()

        Next
        For Fila = 21 To 0 Step -1
            Console.SetCursorPosition(0, Fila)
            Console.Write("*")
            Temporizador()

        Next

    End Sub
    Sub Temporizador()
        ' Este pequello codigo hace la vez de temporizador 
        Dim tempo As Double
        For tempo = 0 To 100000000

        Next
    End Sub
    Sub Eleccion(opcion)
        ' este codigo distribulle el resto de opcines de codigo
        Dim verdad As Boolean
        Dim tablamultiplicar As New TablaMultiplicar

        Select Case opcion
            Case 0
                Salida()
                Return
            Case 1
                verdad = CargaMultiplacion(verdad, tablamultiplicar)
            Case 2
                'Aqui metes nevo codigo

            Case Else

                'Una opcion para Controlar  las ociones no aceptadas
                OpcionErronea()
        End Select
    End Sub

    Private Function CargaMultiplacion(verdad As Boolean, tablamultiplicar As TablaMultiplicar) As Boolean
        Borrado()
        Marco()

        Do
            Try
                ' Si va odo bien
                tablamultiplicar.CargarValor()
                verdad = True

            Catch ex As Exception
                ' si hay algun error
                Console.SetCursorPosition(10, 7)
                Console.Write(ex.Message)
            End Try

        Loop Until verdad = True
        Console.ReadKey()
        Borrado()

        Ejercicio19ManualVisualBasic2019Jorge()

        ' Aqui meter nuevo codigo
        Return verdad
    End Function

    Private Sub OpcionErronea()
        'En  este Metodo controlamos si los numeros introduciodos no son reconocido por el select Case anterior 
        Borrado()
        Marco()


        Console.SetCursorPosition(10, 10)
        Console.Write("OPcion no reconocida")
        Console.ReadKey()
        Borrado()

        Ejercicio19ManualVisualBasic2019Jorge()
    End Sub

    Private Sub Salida()
        Borrado()
        Marco()
        Console.SetCursorPosition(10, 10)
        Console.Write("Gracias pr utilizar la aplicacon")
        Console.ReadKey()
        Borrado()
        End
    End Sub

    Sub Borrado()
        ' este cdigo hace una subifda de pantalla imitando un borrado hasta el efectvo
        Dim Borra As Integer
        For Borra = 0 To 50
            Console.WriteLine()
            Temporizador()

        Next
        Console.Clear()

    End Sub
End Module
