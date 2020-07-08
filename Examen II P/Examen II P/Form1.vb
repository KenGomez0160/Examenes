Public Class Form1
    Dim conexion As Conexion = New Conexion()
    Dim tablita As New DataTable
    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            tablita = conexion.consultarVenta()
            If tablita.Rows.Count <> 0 Then
                DgvVentas.DataSource = tablita
            Else
                DgvVentas.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.abrirConexion()
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        Dim idVentas, idCliente, IdProducto, precio, cantidad As Int16
        Dim fecha As Date

        idVentas = TxtIdVenta.Text
        fecha = TxtFecha.Text
        precio = TxtPrecio.Text
        cantidad = TxtCantidad.Text
        idCliente = TxtIdClinte.Text
        IdProducto = TxtIdProducto.Text



        Try
            If conexion.AgregarVenta(idVentas, fecha, precio, cantidad, idCliente, IdProducto) Then
                MsgBox("Ingresado correctamente")
            Else
                MsgBox("error")
            End If
        Catch ex As Exception
            MsgBox("error al ejecutar")
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim idVentas, idCliente, IdProducto, precio, cantidad As Int16
        Dim fecha As Date
        idVentas = TxtIdVenta.Text
        fecha = TxtFecha.Text
        precio = TxtPrecio.Text
        cantidad = TxtCantidad.Text
        idCliente = TxtIdClinte.Text
        IdProducto = TxtIdProducto.Text


        Try
            If conexion.ActualizarVenta(idVentas, fecha, precio, cantidad, idCliente, IdProducto) Then
                MsgBox("Actualizado correctamente")
            Else
                MsgBox("error")
            End If
        Catch ex As Exception
            MsgBox("error al ejecutar")
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim idVenta As String
        idVenta = TxtIdVenta.Text

        Try
            If conexion.EliminarVenta(idVenta) Then
                MsgBox("Eliminado")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVentas.CellContentClick
        TxtIdVenta.Text = DgvVentas.CurrentRow.Cells(0).Value.ToString
        TxtFecha.Text = DgvVentas.CurrentRow.Cells(1).Value.ToString
        TxtPrecio.Text = DgvVentas.CurrentRow.Cells(2).Value.ToString
        TxtCantidad.Text = DgvVentas.CurrentRow.Cells(3).Value.ToString
        TxtIdClinte.Text = DgvVentas.CurrentRow.Cells(4).Value.ToString
        TxtIdProducto.Text = DgvVentas.CurrentRow.Cells(5).Value.ToString
    End Sub
End Class
