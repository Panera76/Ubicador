Imports System
Imports System.IO
Imports System.Collections
Imports System.Configuration

Public Class Form1
    Private Sub btnMoverArchivos_Click(sender As Object, e As EventArgs) Handles btnMoverArchivos.Click
        Dim NuevaCarpeta As String
        Dim frmt As String = "0000"
        Dim NumOrden As Int16

        NumOrden = CInt(txtNumOrden.Text)

        NuevaCarpeta = txtCarpetaDestino.Text + "\" + txtPrefijo.Text + NumOrden.ToString(frmt) + "\"
        If Directory.Exists(NuevaCarpeta) Then
            MsgBox("Ya existe la carpeta " & NuevaCarpeta)
        ElseIf System.IO.Directory.GetFiles(txtCarpetaOrigen.text).Length = 0 Then
            MsgBox("La carpeta de origen está vacía")
        Else
            My.Computer.FileSystem.CreateDirectory(NuevaCarpeta)
            Dim NumArchivo As Int16 = 1
            For Each ArchivoEncontrado As String In My.Computer.FileSystem.GetFiles(txtCarpetaOrigen.Text + "\")
                My.Computer.FileSystem.MoveFile(ArchivoEncontrado, NuevaCarpeta + NumArchivo.ToString(frmt) + Path.GetExtension(ArchivoEncontrado))
                NumArchivo = NumArchivo + 1
                lblArchivosMovidos.Text = lblArchivosMovidos.Text + 1
            Next
            txtNumOrden.Text = NumOrden + 1
            lblCarpetasCreadas.Text = lblCarpetasCreadas.Text + 1
        End If
    End Sub

    Private Sub lblArchivosMovidos_DoubleClick(sender As Object, e As EventArgs) Handles lblArchivosMovidos.DoubleClick
        lblArchivosMovidos.Text = "0"
    End Sub

    Private Sub lblCarpetasCreadas_DoubleClick(sender As Object, e As EventArgs) Handles lblCarpetasCreadas.DoubleClick
        lblCarpetasCreadas.Text = "0"
    End Sub

    Private Sub btnSelCarpetaOrigen_Click(sender As Object, e As EventArgs) Handles btnSelCarpetaOrigen.Click
        If fbdSeleccionarCarpeta.ShowDialog() = DialogResult.OK Then
            txtCarpetaOrigen.Text = fbdSeleccionarCarpeta.SelectedPath
        End If
    End Sub

    Private Sub btnSelCarpetaDestino_Click(sender As Object, e As EventArgs) Handles btnSelCarpetaDestino.Click
        If fbdSeleccionarCarpeta.ShowDialog() = DialogResult.OK Then
            txtCarpetaDestino.Text = fbdSeleccionarCarpeta.SelectedPath
        End If
    End Sub
End Class