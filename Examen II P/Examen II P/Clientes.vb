Public Class Clientes

    Dim conexion As Conexion = New Conexion()
    Dim tablita As New DataTable

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.abrirConexion()

    End Sub

    Private Sub BtnConsultar_Click_1(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            tablita = conexion.consultar()
            If tablita.Rows.Count <> 0 Then
                DgvClientes.DataSource = tablita
            Else
                DgvClientes.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub BtnActualizar_Click_1(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim idCliente As Int16
        Dim nombre, apellido, direccion As String
        idCliente = TxtIdCliente.Text
        nombre = TxtNombre.Text
        apellido = TxtApellido.Text
        direccion = TxtDireccion.Text


        Try
            If conexion.Actualizar(idCliente, nombre, apellido, direccion) Then
                MsgBox("Actualizado correctamente")
            Else
                MsgBox("error")
            End If
        Catch ex As Exception
            MsgBox("error al ejecutar")
        End Try
    End Sub

    Private Sub BtnAgregar_Click_1(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim idCliente As Int16
        Dim nombre, apellido, direccion As String
        idCliente = TxtIdCliente.Text
        nombre = TxtNombre.Text
        apellido = TxtApellido.Text
        direccion = TxtDireccion.Text


        Try
            If conexion.Agregar(idCliente, nombre, apellido, direccion) Then
                MsgBox("Ingresado correctamente")
            Else
                MsgBox("error")
            End If
        Catch ex As Exception
            MsgBox("error al ejecutar")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim nombre As String
        nombre = TxtNombre.Text

        Try
            If conexion.Eliminar(nombre) Then
                MsgBox("Eliminado")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellContentClick
        TxtIdCliente.Text = DgvClientes.CurrentRow.Cells(0).Value.ToString
        TxtNombre.Text = DgvClientes.CurrentRow.Cells(1).Value.ToString
        TxtApellido.Text = DgvClientes.CurrentRow.Cells(2).Value.ToString
        TxtDireccion.Text = DgvClientes.CurrentRow.Cells(3).Value.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Productos.Show()
        Me.Hide()

    End Sub
End Class
