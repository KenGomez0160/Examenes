Public Class Productos
    Dim conexion As Conexion = New Conexion()
    Dim tablita As New DataTable

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            tablita = conexion.consultarProducto()
            If tablita.Rows.Count <> 0 Then
                DgvProductos.DataSource = tablita
            Else
                DgvProductos.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.abrirConexion()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim idProducto As Int16
        Dim producto, descripcion, direccion As String
        idProducto = TxtIdProducto.Text
        producto = TxtProducto.Text
        descripcion = TxtDescripcion.Text



        Try
            If conexion.ActualizarProducto(idProducto, producto, descripcion) Then
                MsgBox("Actualizado correctamente")
            Else
                MsgBox("error")
            End If
        Catch ex As Exception
            MsgBox("error al ejecutar")
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim idProducto As Int16
        Dim producto, descripcion, direccion As String
        idProducto = TxtIdProducto.Text
        producto = TxtProducto.Text
        descripcion = TxtDescripcion.Text


        Try
            If conexion.AgregarProducto(idProducto, producto, descripcion) Then
                MsgBox("Ingresado correctamente")
            Else
                MsgBox("error")
            End If
        Catch ex As Exception
            MsgBox("error al ejecutar")
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim idProducto As String
        idProducto = TxtIdProducto.Text

        Try
            If conexion.Eliminar(idProducto) Then
                MsgBox("Eliminado")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProductos.CellContentClick
        TxtIdProducto.Text = DgvProductos.CurrentRow.Cells(0).Value.ToString
        TxtIdProducto.Text = DgvProductos.CurrentRow.Cells(1).Value.ToString
        TxtDescripcion.Text = DgvProductos.CurrentRow.Cells(2).Value.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class