Public Class frmPrincipal
    Private Sub TiposDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeUsuariosToolStripMenuItem.Click
        Dim frm As New frmTiposUsuario
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "data source = .\SQLEXPRESS; initial catalog = Restaurante; user id = sa; password = 123"
    End Sub

    Private Sub UnidadesDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesDeMedidaToolStripMenuItem.Click
        Dim frm As New frmUnidadesMedida
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim frm As New frmUsuarios
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim frm As New frmCategorias
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class