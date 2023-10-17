<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_b = New System.Windows.Forms.TextBox()
        Me.txt_c = New System.Windows.Forms.TextBox()
        Me.resoudre = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_delta = New System.Windows.Forms.Label()
        Me.lbl_pas = New System.Windows.Forms.Label()
        Me.lbl_soldelta = New System.Windows.Forms.Label()
        Me.lbl_x1 = New System.Windows.Forms.Label()
        Me.lbl_x2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "coff a"
        '
        'txt_a
        '
        Me.txt_a.Location = New System.Drawing.Point(174, 50)
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(100, 22)
        Me.txt_a.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "coff b"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(609, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "coff c"
        '
        'txt_b
        '
        Me.txt_b.Location = New System.Drawing.Point(448, 50)
        Me.txt_b.Name = "txt_b"
        Me.txt_b.Size = New System.Drawing.Size(100, 22)
        Me.txt_b.TabIndex = 4
        '
        'txt_c
        '
        Me.txt_c.Location = New System.Drawing.Point(679, 50)
        Me.txt_c.Name = "txt_c"
        Me.txt_c.Size = New System.Drawing.Size(100, 22)
        Me.txt_c.TabIndex = 5
        '
        'resoudre
        '
        Me.resoudre.Location = New System.Drawing.Point(322, 111)
        Me.resoudre.Name = "resoudre"
        Me.resoudre.Size = New System.Drawing.Size(236, 38)
        Me.resoudre.TabIndex = 6
        Me.resoudre.Text = "resoudre"
        Me.resoudre.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "delta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(171, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "cas1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(170, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "cas2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(171, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "cas3"
        '
        'lbl_delta
        '
        Me.lbl_delta.AutoSize = True
        Me.lbl_delta.Location = New System.Drawing.Point(228, 231)
        Me.lbl_delta.Name = "lbl_delta"
        Me.lbl_delta.Size = New System.Drawing.Size(0, 16)
        Me.lbl_delta.TabIndex = 16
        '
        'lbl_pas
        '
        Me.lbl_pas.AutoSize = True
        Me.lbl_pas.Location = New System.Drawing.Point(228, 340)
        Me.lbl_pas.Name = "lbl_pas"
        Me.lbl_pas.Size = New System.Drawing.Size(0, 16)
        Me.lbl_pas.TabIndex = 17
        '
        'lbl_soldelta
        '
        Me.lbl_soldelta.AutoSize = True
        Me.lbl_soldelta.Location = New System.Drawing.Point(228, 374)
        Me.lbl_soldelta.Name = "lbl_soldelta"
        Me.lbl_soldelta.Size = New System.Drawing.Size(0, 16)
        Me.lbl_soldelta.TabIndex = 18
        '
        'lbl_x1
        '
        Me.lbl_x1.AutoSize = True
        Me.lbl_x1.Location = New System.Drawing.Point(228, 413)
        Me.lbl_x1.Name = "lbl_x1"
        Me.lbl_x1.Size = New System.Drawing.Size(0, 16)
        Me.lbl_x1.TabIndex = 19
        '
        'lbl_x2
        '
        Me.lbl_x2.AutoSize = True
        Me.lbl_x2.Location = New System.Drawing.Point(389, 413)
        Me.lbl_x2.Name = "lbl_x2"
        Me.lbl_x2.Size = New System.Drawing.Size(0, 16)
        Me.lbl_x2.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_x2)
        Me.Controls.Add(Me.lbl_x1)
        Me.Controls.Add(Me.lbl_soldelta)
        Me.Controls.Add(Me.lbl_pas)
        Me.Controls.Add(Me.lbl_delta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.resoudre)
        Me.Controls.Add(Me.txt_c)
        Me.Controls.Add(Me.txt_b)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_a)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "frn_equation.vb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_a As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_b As TextBox
    Friend WithEvents txt_c As TextBox
    Friend WithEvents resoudre As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_delta As Label
    Friend WithEvents lbl_pas As Label
    Friend WithEvents lbl_soldelta As Label
    Friend WithEvents lbl_x1 As Label
    Friend WithEvents lbl_x2 As Label
End Class
