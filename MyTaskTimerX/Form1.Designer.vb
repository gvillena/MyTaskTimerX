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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTarea = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.txtMinutos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSegundos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "mis tareas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(18, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "tengo que"
        '
        'txtTarea
        '
        Me.txtTarea.Font = New System.Drawing.Font("Segoe UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarea.Location = New System.Drawing.Point(19, 131)
        Me.txtTarea.Name = "txtTarea"
        Me.txtTarea.Size = New System.Drawing.Size(320, 36)
        Me.txtTarea.TabIndex = 2
        Me.txtTarea.Text = "estudiar para el parcial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(18, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "esto me tomará"
        '
        'txtHoras
        '
        Me.txtHoras.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoras.Location = New System.Drawing.Point(73, 235)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(45, 39)
        Me.txtHoras.TabIndex = 2
        Me.txtHoras.Text = "00"
        Me.txtHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMinutos
        '
        Me.txtMinutos.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinutos.Location = New System.Drawing.Point(150, 235)
        Me.txtMinutos.Name = "txtMinutos"
        Me.txtMinutos.Size = New System.Drawing.Size(45, 39)
        Me.txtMinutos.TabIndex = 2
        Me.txtMinutos.Text = "00"
        Me.txtMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        '
        'txtSegundos
        '
        Me.txtSegundos.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundos.Location = New System.Drawing.Point(227, 235)
        Me.txtSegundos.Name = "txtSegundos"
        Me.txtSegundos.Size = New System.Drawing.Size(45, 39)
        Me.txtSegundos.TabIndex = 2
        Me.txtSegundos.Text = "00"
        Me.txtSegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(201, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 32)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(80, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "hrs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(155, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "min"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(233, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "seg"
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnIniciar.FlatAppearance.BorderSize = 0
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.Color.White
        Me.btnIniciar.Location = New System.Drawing.Point(-5, 329)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(360, 40)
        Me.btnIniciar.TabIndex = 4
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'MyTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(356, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSegundos)
        Me.Controls.Add(Me.txtMinutos)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.txtTarea)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTarea As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents txtMinutos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSegundos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents MyTimer As Timer
End Class
