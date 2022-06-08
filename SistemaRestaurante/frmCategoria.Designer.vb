<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
    Inherits SistemaRestaurante.frmDetalleGrillaGenerica

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbSi = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(117, 192)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(251, 192)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(146, 55)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(246, 22)
        Me.txtDescripcion.TabIndex = 3
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Location = New System.Drawing.Point(193, 98)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(47, 21)
        Me.rdbNo.TabIndex = 16
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "No"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbSi
        '
        Me.rdbSi.AutoSize = True
        Me.rdbSi.Location = New System.Drawing.Point(146, 98)
        Me.rdbSi.Name = "rdbSi"
        Me.rdbSi.Size = New System.Drawing.Size(41, 21)
        Me.rdbSi.TabIndex = 15
        Me.rdbSi.TabStop = True
        Me.rdbSi.Text = "Si"
        Me.rdbSi.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Esta activo?"
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(442, 269)
        Me.Controls.Add(Me.rdbNo)
        Me.Controls.Add(Me.rdbSi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCategoria"
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.rdbSi, 0)
        Me.Controls.SetChildIndex(Me.rdbNo, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents rdbNo As RadioButton
    Friend WithEvents rdbSi As RadioButton
    Friend WithEvents Label5 As Label
End Class
