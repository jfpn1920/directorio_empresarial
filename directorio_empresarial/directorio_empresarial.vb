Imports System
Module directorio_empresarial
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim empresas(9) As String
        Dim representantes(9) As String
        Dim sectores(9) As String
        Dim telefonos(9) As String
        Dim correos(9) As String
        Dim direcciones(9) As String
        Dim estados(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '----------------------------------------------'
        '--|menu_principal_de_directorio_empresarial|--'
        '----------------------------------------------'
        Do
            Console.WriteLine("menu principal de directorio empresarial")
            Console.WriteLine("1) Registrar empresa")
            Console.WriteLine("2) Editar empresa")
            Console.WriteLine("3) Listar empresas")
            Console.WriteLine("4) Buscar empresa")
            Console.WriteLine("5) Eliminar empresa")
            Console.WriteLine("6) Cambiar estado")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '-----------------------'
                '--|registrar_empresa|--'
                '-----------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas empresas.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Ingrese el nombre de la empresa: ")
                        empresas(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese el representante: ")
                        representantes(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese el sector: ")
                        sectores(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese el telefono: ")
                        telefonos(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese el correo: ")
                        correos(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la direccion: ")
                        direcciones(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese el estado (Activa/Inactiva): ")
                        estados(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Empresa registrada correctamente.")
                        Console.WriteLine("ID: " & ids(cantidad - 1) & " | Empresa: " & empresas(cantidad - 1) & " | Representante: " & representantes(cantidad - 1) & " | Sector: " & sectores(cantidad - 1) & " | Telefono: " & telefonos(cantidad - 1) & " | Correo: " & correos(cantidad - 1) & " | Direccion: " & direcciones(cantidad - 1) & " | Estado: " & estados(cantidad - 1))
                    End If
                '--------------------'
                '--|editar_empresa|--'
                '--------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen empresas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Empresa: " & empresas(i) & " | Representante: " & representantes(i) & " | Sector: " & sectores(i) & " | Telefono: " & telefonos(i) & " | Correo: " & correos(i) & " | Direccion: " & direcciones(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la empresa a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 AndAlso idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre de la empresa: ")
                            empresas(posicion) = Console.ReadLine()
                            Console.Write("Nuevo representante: ")
                            representantes(posicion) = Console.ReadLine()
                            Console.Write("Nuevo sector: ")
                            sectores(posicion) = Console.ReadLine()
                            Console.Write("Nuevo telefono: ")
                            telefonos(posicion) = Console.ReadLine()
                            Console.Write("Nuevo correo: ")
                            correos(posicion) = Console.ReadLine()
                            Console.Write("Nueva direccion: ")
                            direcciones(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado (Activa/Inactiva): ")
                            estados(posicion) = Console.ReadLine()
                            Console.WriteLine("Empresa actualizada correctamente.")
                            Console.WriteLine("ID: " & ids(posicion) & " | Empresa: " & empresas(posicion) & " | Representante: " & representantes(posicion) & " | Sector: " & sectores(posicion) & " | Telefono: " & telefonos(posicion) & " | Correo: " & correos(posicion) & " | Direccion: " & direcciones(posicion) & " | Estado: " & estados(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|listar_empresas|--'
                '---------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen empresas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Empresa: " & empresas(i) & " | Representante: " & representantes(i) & " | Sector: " & sectores(i) & " | Telefono: " & telefonos(i) & " | Correo: " & correos(i) & " | Direccion: " & direcciones(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '--------------------'
                '--|buscar_empresa|--'
                '--------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen empresas registradas.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por empresa")
                        Console.WriteLine("3) Buscar por representante")
                        Console.WriteLine("4) Buscar por sector")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoBusqueda As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoBusqueda = 1 Then
                            Console.Write("Ingrese el ID de la empresa: ")
                            Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                            If idBuscar >= 1 AndAlso idBuscar <= cantidad Then
                                Dim posicion As Integer = idBuscar - 1
                                Console.WriteLine("ID: " & ids(posicion) & " | Empresa: " & empresas(posicion) & " | Representante: " & representantes(posicion) & " | Sector: " & sectores(posicion) & " | Telefono: " & telefonos(posicion) & " | Correo: " & correos(posicion) & " | Direccion: " & direcciones(posicion) & " | Estado: " & estados(posicion))
                            Else
                                Console.WriteLine("ID no encontrada.")
                            End If
                        ElseIf tipoBusqueda = 2 Then
                            Console.Write("Ingrese el nombre de la empresa: ")
                            Dim empresaBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If empresas(i).ToLower().Contains(empresaBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Empresa: " & empresas(i) & " | Representante: " & representantes(i) & " | Sector: " & sectores(i) & " | Telefono: " & telefonos(i) & " | Correo: " & correos(i) & " | Direccion: " & direcciones(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron empresas.")
                            End If
                        ElseIf tipoBusqueda = 3 Then
                            Console.Write("Ingrese el nombre del representante: ")
                            Dim representanteBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If representantes(i).ToLower().Contains(representanteBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Empresa: " & empresas(i) & " | Representante: " & representantes(i) & " | Sector: " & sectores(i) & " | Telefono: " & telefonos(i) & " | Correo: " & correos(i) & " | Direccion: " & direcciones(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron empresas.")
                            End If
                        ElseIf tipoBusqueda = 4 Then
                            Console.Write("Ingrese el sector: ")
                            Dim sectorBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If sectores(i).ToLower().Contains(sectorBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Empresa: " & empresas(i) & " | Representante: " & representantes(i) & " | Sector: " & sectores(i) & " | Telefono: " & telefonos(i) & " | Correo: " & correos(i) & " | Direccion: " & direcciones(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron empresas.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '----------------------'
                '--|eliminar_empresa|--'
                '----------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen empresas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Empresa: " & empresas(i) & " | Representante: " & representantes(i) & " | Sector: " & sectores(i) & " | Telefono: " & telefonos(i) & " | Correo: " & correos(i) & " | Direccion: " & direcciones(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la empresa a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 AndAlso idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                empresas(i) = empresas(i + 1)
                                representantes(i) = representantes(i + 1)
                                sectores(i) = sectores(i + 1)
                                telefonos(i) = telefonos(i + 1)
                                correos(i) = correos(i + 1)
                                direcciones(i) = direcciones(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            ids(cantidad) = 0
                            empresas(cantidad) = ""
                            representantes(cantidad) = ""
                            sectores(cantidad) = ""
                            telefonos(cantidad) = ""
                            correos(cantidad) = ""
                            direcciones(cantidad) = ""
                            estados(cantidad) = ""
                            For i As Integer = 0 To cantidad - 1
                                ids(i) = i + 1
                            Next
                            Console.WriteLine("Empresa eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------'
                '--|cambiar_estado|--'
                '--------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen empresas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Empresa: " & empresas(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la empresa: ")
                        Dim idEstado As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEstado >= 1 AndAlso idEstado <= cantidad Then
                            Dim posicion As Integer = idEstado - 1
                            Console.Write("Ingrese el nuevo estado (Activa/Inactiva): ")
                            Dim nuevoEstado As String = Console.ReadLine()
                            If nuevoEstado.ToLower() = "activa" OrElse nuevoEstado.ToLower() = "inactiva" Then
                                estados(posicion) = nuevoEstado
                                Console.WriteLine("Estado actualizado correctamente.")
                                Console.WriteLine("ID: " & ids(posicion) & " | Empresa: " & empresas(posicion) & " | Estado: " & estados(posicion))
                            Else
                                Console.WriteLine("El estado debe ser Activa o Inactiva.")
                            End If
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Directorio Empresarial.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module