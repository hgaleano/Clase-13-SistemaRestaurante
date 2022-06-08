Public Class frmCategoria
    Dim id As Integer
    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If vAccion = EnumAccion.accAgregar Then
            txtDescripcion.Select()
        ElseIf vAccion = EnumAccion.accModificar Then
            id = dvwGenerico(Me.BindingContext(dvwGenerico).Position)("CategoriaID")

            Dim tabla As New DataTable("Categoria")
            tabla = generar_datatabla("Select * from Categoria where CategoriaID =" & id)

            If tabla.Rows.Count > 0 Then
                txtDescripcion.Text = tabla.Rows(0).Item("Descripcion")

                If tabla.Rows(0).Item("Activo") = "S" Then
                    rdbSi.Checked = True
                Else
                    rdbNo.Checked = True
                End If
            End If
        End If
    End Sub

    Public Overrides Sub Aceptar()
        Try
            Dim Estado As String

            If rdbSi.Checked = True Then
                Estado = "S"
            Else
                Estado = "N"
            End If

            If vAccion = EnumAccion.accAgregar Then
                EjecutarSQL("Insert Categoria values(@1,@2)", txtDescripcion.Text, Estado)
            ElseIf vAccion = EnumAccion.accModificar Then
                EjecutarSQL("update Categoria set Descripcion=@1,Activo=@2 where CategoriaID=@3", txtDescripcion.Text, Estado, id)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Overrides Function ValidarDatos() As Boolean
        If txtDescripcion.Text = "" Then
            MsgBox("Debe ingresar la descripción")
            txtDescripcion.Focus()
            Return False
        End If

        If rdbSi.Checked = False And rdbNo.Checked = False Then
            MsgBox("Debe seleccionar el estado de la categoria")
            Return False
        End If

        Return True
    End Function
End Class
