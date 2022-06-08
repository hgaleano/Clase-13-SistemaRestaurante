<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategorias
    Inherits SistemaRestaurante.frmGrillaGenerica

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
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.colCategoriaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxFiltros.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(385, 43)
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCategoriaID, Me.colDescripcion, Me.ColActivo})
        Me.dgvLista.Location = New System.Drawing.Point(12, 185)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.RowHeadersWidth = 51
        Me.dgvLista.RowTemplate.Height = 24
        Me.dgvLista.Size = New System.Drawing.Size(765, 245)
        Me.dgvLista.TabIndex = 4
        '
        'colCategoriaID
        '
        Me.colCategoriaID.DataPropertyName = "CategoriaID"
        Me.colCategoriaID.HeaderText = "Cód. Categoria"
        Me.colCategoriaID.MinimumWidth = 6
        Me.colCategoriaID.Name = "colCategoriaID"
        Me.colCategoriaID.ReadOnly = True
        Me.colCategoriaID.Width = 125
        '
        'colDescripcion
        '
        Me.colDescripcion.DataPropertyName = "Descripcion"
        Me.colDescripcion.HeaderText = "Descripción"
        Me.colDescripcion.MinimumWidth = 6
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        Me.colDescripcion.Width = 125
        '
        'ColActivo
        '
        Me.ColActivo.DataPropertyName = "Activo"
        Me.ColActivo.HeaderText = "Esta Activo?"
        Me.ColActivo.MinimumWidth = 6
        Me.ColActivo.Name = "ColActivo"
        Me.ColActivo.ReadOnly = True
        Me.ColActivo.Width = 125
        '
        'frmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(800, 523)
        Me.Controls.Add(Me.dgvLista)
        Me.Name = "frmCategorias"
        Me.Controls.SetChildIndex(Me.gbxFiltros, 0)
        Me.Controls.SetChildIndex(Me.dgvLista, 0)
        Me.gbxFiltros.ResumeLayout(False)
        Me.gbxFiltros.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLista As DataGridView
    Friend WithEvents colCategoriaID As DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColActivo As DataGridViewTextBoxColumn
End Class
