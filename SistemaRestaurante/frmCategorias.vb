Public Class frmCategorias
    Public Overrides Sub AsignarFormularioDetalle()
        formularioDetalle = New frmCategoria
        tituloFormularioDetalle = "Categoria"
    End Sub

    Public Overrides Sub CargarGrilla()
        Try
            nombreCampoBusqueda = "Descripcion"
            dvwGenerico.Table = generar_datatabla("Select * from Categoria order by Descripcion")
            dgvLista.DataSource = dvwGenerico
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Overrides Sub EliminarRegistro()
        Try
            Dim id As Integer
            id = dvwGenerico(Me.BindingContext(dvwGenerico).Position)("CategoriaID")
            If MsgBox("Esta seguro que desea eliminar el registro", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                EjecutarSQL("Delete from Categoria where CategoriaID=@1", id)
                CargarGrilla()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgvLista_DoubleClick(sender As Object, e As EventArgs) Handles dgvLista.DoubleClick
        DobleClick()
    End Sub

    Private Sub dgvLista_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.RowEnter
        TotalRegistro()
    End Sub

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
