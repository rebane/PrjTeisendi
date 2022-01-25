<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeisendiAken
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTeisenda = New System.Windows.Forms.Button()
        Me.txtKilomeetrid = New System.Windows.Forms.TextBox()
        Me.txtMiilid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKell = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTeisenda
        '
        Me.btnTeisenda.Location = New System.Drawing.Point(451, 173)
        Me.btnTeisenda.Name = "btnTeisenda"
        Me.btnTeisenda.Size = New System.Drawing.Size(100, 31)
        Me.btnTeisenda.TabIndex = 0
        Me.btnTeisenda.Text = "Teisenda"
        Me.btnTeisenda.UseVisualStyleBackColor = True
        '
        'txtKilomeetrid
        '
        Me.txtKilomeetrid.Location = New System.Drawing.Point(451, 78)
        Me.txtKilomeetrid.Name = "txtKilomeetrid"
        Me.txtKilomeetrid.Size = New System.Drawing.Size(100, 26)
        Me.txtKilomeetrid.TabIndex = 1
        '
        'txtMiilid
        '
        Me.txtMiilid.Location = New System.Drawing.Point(451, 274)
        Me.txtMiilid.Name = "txtMiilid"
        Me.txtMiilid.ReadOnly = True
        Me.txtMiilid.Size = New System.Drawing.Size(100, 26)
        Me.txtMiilid.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sisesta kilomeetrid:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Miilid:"
        '
        'lblKell
        '
        Me.lblKell.AutoSize = True
        Me.lblKell.Location = New System.Drawing.Point(311, 367)
        Me.lblKell.Name = "lblKell"
        Me.lblKell.Size = New System.Drawing.Size(34, 20)
        Me.lblKell.TabIndex = 5
        Me.lblKell.Text = "Kell"
        '
        'TeisendiAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblKell)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMiilid)
        Me.Controls.Add(Me.txtKilomeetrid)
        Me.Controls.Add(Me.btnTeisenda)
        Me.Name = "TeisendiAken"
        Me.Text = "Distantsi teisendaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTeisenda As Button
    Friend WithEvents txtKilomeetrid As TextBox
    Friend WithEvents txtMiilid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblKell As Label
End Class
