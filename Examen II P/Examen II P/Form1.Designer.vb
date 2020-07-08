<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DgvVentas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdVenta = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtIdClinte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvVentas
        '
        Me.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentas.Location = New System.Drawing.Point(12, 191)
        Me.DgvVentas.Name = "DgvVentas"
        Me.DgvVentas.Size = New System.Drawing.Size(776, 213)
        Me.DgvVentas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IdVenta"
        '
        'TxtIdVenta
        '
        Me.TxtIdVenta.Location = New System.Drawing.Point(78, 35)
        Me.TxtIdVenta.Name = "TxtIdVenta"
        Me.TxtIdVenta.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdVenta.TabIndex = 2
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(78, 94)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha "
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(254, 94)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cantidad"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(254, 35)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrecio.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(500, 23)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(82, 35)
        Me.BtnConsultar.TabIndex = 9
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'BtnCrear
        '
        Me.BtnCrear.Location = New System.Drawing.Point(500, 86)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(82, 35)
        Me.BtnCrear.TabIndex = 10
        Me.BtnCrear.Text = "Crear"
        Me.BtnCrear.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(642, 24)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(82, 35)
        Me.BtnActualizar.TabIndex = 11
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(642, 83)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(82, 35)
        Me.BtnEliminar.TabIndex = 12
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtIdClinte
        '
        Me.TxtIdClinte.Location = New System.Drawing.Point(78, 141)
        Me.TxtIdClinte.Name = "TxtIdClinte"
        Me.TxtIdClinte.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdClinte.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "IdCliente"
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.Location = New System.Drawing.Point(265, 145)
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdProducto.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "IdProducto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 424)
        Me.Controls.Add(Me.TxtIdProducto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtIdClinte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtIdVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvVentas)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvVentas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdVenta As TextBox
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents BtnCrear As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtIdClinte As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents Label6 As Label
End Class
