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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMoverArchivos = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTiempodeCorte = New System.Windows.Forms.Label()
        Me.txtTiempodeCorte = New System.Windows.Forms.TextBox()
        Me.chkMoverTodosArchivos = New System.Windows.Forms.CheckBox()
        Me.lblCarpetasCreadas = New System.Windows.Forms.Label()
        Me.txtNumOrden = New System.Windows.Forms.TextBox()
        Me.lblArchivosMovidos = New System.Windows.Forms.Label()
        Me.txtPrefijo = New System.Windows.Forms.TextBox()
        Me.txtCarpetaDestino = New System.Windows.Forms.TextBox()
        Me.txtCarpetaOrigen = New System.Windows.Forms.TextBox()
        Me.fbdSeleccionarCarpeta = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSelCarpetaOrigen = New System.Windows.Forms.Button()
        Me.btnSelCarpetaDestino = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Carpeta de Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Carpeta de Destino"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Prefijo de la Carpeta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "v0.0.1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Archivos movidos:"
        '
        'btnMoverArchivos
        '
        Me.btnMoverArchivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoverArchivos.Location = New System.Drawing.Point(11, 92)
        Me.btnMoverArchivos.Name = "btnMoverArchivos"
        Me.btnMoverArchivos.Size = New System.Drawing.Size(341, 112)
        Me.btnMoverArchivos.TabIndex = 6
        Me.btnMoverArchivos.Text = "Mover Archivos"
        Me.btnMoverArchivos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nº de Orden"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(171, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Carpetas creadas:"
        '
        'lblTiempodeCorte
        '
        Me.lblTiempodeCorte.AutoSize = True
        Me.lblTiempodeCorte.Enabled = False
        Me.lblTiempodeCorte.Location = New System.Drawing.Point(184, 92)
        Me.lblTiempodeCorte.Name = "lblTiempodeCorte"
        Me.lblTiempodeCorte.Size = New System.Drawing.Size(113, 13)
        Me.lblTiempodeCorte.TabIndex = 15
        Me.lblTiempodeCorte.Text = "Tiempo de corte (seg.)"
        Me.lblTiempodeCorte.Visible = False
        '
        'txtTiempodeCorte
        '
        Me.txtTiempodeCorte.Enabled = False
        Me.txtTiempodeCorte.Location = New System.Drawing.Point(308, 89)
        Me.txtTiempodeCorte.Name = "txtTiempodeCorte"
        Me.txtTiempodeCorte.Size = New System.Drawing.Size(42, 20)
        Me.txtTiempodeCorte.TabIndex = 14
        Me.txtTiempodeCorte.Visible = False
        '
        'chkMoverTodosArchivos
        '
        Me.chkMoverTodosArchivos.AutoSize = True
        Me.chkMoverTodosArchivos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMoverTodosArchivos.Enabled = False
        Me.chkMoverTodosArchivos.Location = New System.Drawing.Point(7, 92)
        Me.chkMoverTodosArchivos.Name = "chkMoverTodosArchivos"
        Me.chkMoverTodosArchivos.Size = New System.Drawing.Size(145, 17)
        Me.chkMoverTodosArchivos.TabIndex = 16
        Me.chkMoverTodosArchivos.Text = "Mover todos los Archivos"
        Me.chkMoverTodosArchivos.UseVisualStyleBackColor = True
        Me.chkMoverTodosArchivos.Visible = False
        '
        'lblCarpetasCreadas
        '
        Me.lblCarpetasCreadas.AutoSize = True
        Me.lblCarpetasCreadas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Ubicador.My.MySettings.Default, "CarpetasCreadas", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblCarpetasCreadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarpetasCreadas.Location = New System.Drawing.Point(288, 214)
        Me.lblCarpetasCreadas.Name = "lblCarpetasCreadas"
        Me.lblCarpetasCreadas.Size = New System.Drawing.Size(19, 20)
        Me.lblCarpetasCreadas.TabIndex = 13
        Me.lblCarpetasCreadas.Text = Global.Ubicador.My.MySettings.Default.CarpetasCreadas
        '
        'txtNumOrden
        '
        Me.txtNumOrden.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Ubicador.My.MySettings.Default, "NumOrden", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNumOrden.Location = New System.Drawing.Point(302, 63)
        Me.txtNumOrden.Name = "txtNumOrden"
        Me.txtNumOrden.Size = New System.Drawing.Size(48, 20)
        Me.txtNumOrden.TabIndex = 5
        Me.txtNumOrden.Text = Global.Ubicador.My.MySettings.Default.NumOrden
        Me.txtNumOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblArchivosMovidos
        '
        Me.lblArchivosMovidos.AutoSize = True
        Me.lblArchivosMovidos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Ubicador.My.MySettings.Default, "ArchivosMovidos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblArchivosMovidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArchivosMovidos.Location = New System.Drawing.Point(127, 214)
        Me.lblArchivosMovidos.Name = "lblArchivosMovidos"
        Me.lblArchivosMovidos.Size = New System.Drawing.Size(19, 20)
        Me.lblArchivosMovidos.TabIndex = 8
        Me.lblArchivosMovidos.Text = Global.Ubicador.My.MySettings.Default.ArchivosMovidos
        '
        'txtPrefijo
        '
        Me.txtPrefijo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Ubicador.My.MySettings.Default, "Prefijo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPrefijo.Location = New System.Drawing.Point(118, 63)
        Me.txtPrefijo.Name = "txtPrefijo"
        Me.txtPrefijo.Size = New System.Drawing.Size(97, 20)
        Me.txtPrefijo.TabIndex = 4
        Me.txtPrefijo.Text = Global.Ubicador.My.MySettings.Default.Prefijo
        '
        'txtCarpetaDestino
        '
        Me.txtCarpetaDestino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Ubicador.My.MySettings.Default, "CarpetaDestino", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtCarpetaDestino.Location = New System.Drawing.Point(118, 37)
        Me.txtCarpetaDestino.Name = "txtCarpetaDestino"
        Me.txtCarpetaDestino.Size = New System.Drawing.Size(206, 20)
        Me.txtCarpetaDestino.TabIndex = 2
        Me.txtCarpetaDestino.Text = Global.Ubicador.My.MySettings.Default.CarpetaDestino
        '
        'txtCarpetaOrigen
        '
        Me.txtCarpetaOrigen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Ubicador.My.MySettings.Default, "CarpetaOrigen", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtCarpetaOrigen.Location = New System.Drawing.Point(118, 11)
        Me.txtCarpetaOrigen.Name = "txtCarpetaOrigen"
        Me.txtCarpetaOrigen.Size = New System.Drawing.Size(206, 20)
        Me.txtCarpetaOrigen.TabIndex = 0
        Me.txtCarpetaOrigen.Text = Global.Ubicador.My.MySettings.Default.CarpetaOrigen
        '
        'btnSelCarpetaOrigen
        '
        Me.btnSelCarpetaOrigen.Location = New System.Drawing.Point(327, 11)
        Me.btnSelCarpetaOrigen.Name = "btnSelCarpetaOrigen"
        Me.btnSelCarpetaOrigen.Size = New System.Drawing.Size(24, 20)
        Me.btnSelCarpetaOrigen.TabIndex = 1
        Me.btnSelCarpetaOrigen.Text = "..."
        Me.btnSelCarpetaOrigen.UseVisualStyleBackColor = True
        '
        'btnSelCarpetaDestino
        '
        Me.btnSelCarpetaDestino.Location = New System.Drawing.Point(326, 37)
        Me.btnSelCarpetaDestino.Name = "btnSelCarpetaDestino"
        Me.btnSelCarpetaDestino.Size = New System.Drawing.Size(24, 20)
        Me.btnSelCarpetaDestino.TabIndex = 3
        Me.btnSelCarpetaDestino.Text = "..."
        Me.btnSelCarpetaDestino.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnMoverArchivos
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 239)
        Me.Controls.Add(Me.btnSelCarpetaDestino)
        Me.Controls.Add(Me.btnSelCarpetaOrigen)
        Me.Controls.Add(Me.chkMoverTodosArchivos)
        Me.Controls.Add(Me.lblTiempodeCorte)
        Me.Controls.Add(Me.txtTiempodeCorte)
        Me.Controls.Add(Me.lblCarpetasCreadas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNumOrden)
        Me.Controls.Add(Me.btnMoverArchivos)
        Me.Controls.Add(Me.lblArchivosMovidos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrefijo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCarpetaDestino)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCarpetaOrigen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ubicador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCarpetaOrigen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCarpetaDestino As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrefijo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblArchivosMovidos As Label
    Friend WithEvents btnMoverArchivos As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNumOrden As TextBox
    Friend WithEvents lblCarpetasCreadas As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTiempodeCorte As Label
    Friend WithEvents txtTiempodeCorte As TextBox
    Friend WithEvents chkMoverTodosArchivos As CheckBox
    Friend WithEvents fbdSeleccionarCarpeta As FolderBrowserDialog
    Friend WithEvents btnSelCarpetaOrigen As Button
    Friend WithEvents btnSelCarpetaDestino As Button
End Class
