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
    Public Class Persona
        Private nombre As String
        Private edad As Integer
        Private altura As Double
        Private peso As Double
        Public Sub New(nombre As String, edad As Integer, altura As Double, peso As Double)
            Me.nombre = nombre
            Me.edad = edad
            Me.altura = altura
            Me.peso = peso

        End Sub
        Public Property PropNombre() As String
            Get
                Return nombre
            End Get
            Set(value As String)
                nombre = value

            End Set
        End Property
        Public Property ProEdad() As Integer
            Get
                Return edad

            End Get
            Set(value As Integer)
                edad = value

            End Set
        End Property
        Public Property ProAltura() As Double
            Get
                Return altura

            End Get
            Set(value As Double)
                altura = value

            End Set
        End Property
        Public Property ProPeso() As Double
            Get
                Return peso

            End Get
            Set(value As Double)
                peso = value

            End Set
        End Property

    End Class
    Public Class Alumno
        Inherits Persona

        Private nota As Integer

        Public Sub New(Nombre As String, edad As Integer, altura As Double, peso As Double, nota As Integer)
            MyBase.New(Nombre, edad, altura, peso)
            Me.nota = nota


        End Sub
        Public Property Pronota As Integer
            Get
                Return nota

            End Get
            Set(value As Integer)
                nota = value

            End Set
        End Property




    End Class
    Public Class Profesor
        Inherits Persona

        Private asignatura As String
        Public Sub New(nombre As String, edad As Integer, altura As Double, peso As Double, asignatura As String)
            MyBase.New(nombre, edad, altura, peso)
            Me.asignatura = asignatura

        End Sub

        Public Property ProAsignatura As String
            Get
                Return asignatura

            End Get
            Set(value As String)

                asignatura = value

            End Set
        End Property


    End Class
    Sub Main()
        ' Plantilla Ejercicio19ManualVisualBasic2019conl un menu
        ' con un marco que podras ver como se crear mas rapido lento
        ' segundo aumentes o bajes el valor del for en el metodo Temprizador
        ' progrmama viene de esta web.
        ' prorgama de clases y prpriedades en el programa
        'http://www.tutorialesprogramacionya.com/visualbasicya/detalleconcepto.php?punto=14&codigo=14&inicio=0
        ' https://www.discoduroderoer.es/herencia-en-visual-basic-net/
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
        Console.Write("2. -Codigo Clase y propiedades")
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
                verdad = ClaseyPropiedades()
            Case Else

                'Una opcion para Controlar  las ociones no aceptadas
                OpcionErronea()
        End Select
    End Sub

    Private Function ClaseyPropiedades() As Boolean
        Dim verdad As Boolean

        Do
            Try

                Borrado()
                Marco()

                Dim pro As New Profesor("Profesor", 30, 1.7, 70, "Matematicas")

                Dim alum1 As New Alumno("Alumno1", 12, 1.5, 40, 7)

                Dim alum2 As New Alumno("Alumno2", 12, 1.5, 40, 7)

                Console.SetCursorPosition(10, 7)
                Console.WriteLine("Altura del proferor: " & pro.ProAltura)

                Console.SetCursorPosition(10, 9)
                Console.WriteLine("Edad Del alumnor: " & alum1.ProEdad)
                Console.SetCursorPosition(10, 11)
                Console.WriteLine("Edad Del alumnor: " & alum2.ProEdad)
                Console.ReadKey()
                Borrado()



                verdad = True

                Ejercicio19ManualVisualBasic2019Jorge()


            Catch ex As Exception
                Console.SetCursorPosition(10, 19)
                Console.Write(ex.Message)

                verdad = False
            End Try
        Loop Until verdad = True

        Return verdad
    End Function

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
