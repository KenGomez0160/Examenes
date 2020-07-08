Imports System.Data.SqlClient
Public Class Conexion


    Public conexion As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Tienda;Integrated Security=True")

    Public Sub abrirConexion()
        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("No se pudo Conectar: " + ex.ToString)
            End
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function consultar()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarCliente", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            conexion.Close()

        End Try
    End Function

    Public Function Agregar(idCliente As Int16, nombre As String, apelllido As String, direccion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("agregarCliente", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@apellido", apelllido)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function Actualizar(idCliente As Int16, nombre As String, apellido As String, direccion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ActualizarCliente", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@apellido", apellido)
            cmd.Parameters.AddWithValue("@direccion", direccion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function Eliminar(nombre As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarCliente", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", nombre)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function




    Public Function consultarProducto()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            conexion.Close()

        End Try
    End Function

    Public Function AgregarProducto(idProducto As Int16, producto As String, descripcion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("agregarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
            cmd.Parameters.AddWithValue("@nombreProducto", producto)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function ActualizarProducto(idProducto As Int16, producto As String, descripcion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ActualizarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
            cmd.Parameters.AddWithValue("@nombreProducto", producto)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function EliminarProducto(producto As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idProducto", producto)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function





    Public Function consultarVenta()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarVenta", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            conexion.Close()

        End Try
    End Function

    Public Function AgregarVenta(idVenta As Int16, fecha As Date, precio As Int16, Cantidad As Int16, idCliente As Int16, idProducto As Int16) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("AgregarVenta", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idVenta", idCliente)
            cmd.Parameters.AddWithValue("@fechaVenta", fecha)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@cantidad ", Cantidad)
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@idProducto ", idProducto)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function ActualizarVenta(idVenta As Int16, fecha As Date, precio As Int16, Cantidad As Int16, idCliente As Int16, idProducto As Int16) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ActualizarVenta", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idVenta", idCliente)
            cmd.Parameters.AddWithValue("@fechaVenta", fecha)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@cantidad ", Cantidad)
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@idProducto ", idProducto)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function EliminarVenta(idVenta As Int16) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarVenta", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idVenta", idVenta)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

End Class

