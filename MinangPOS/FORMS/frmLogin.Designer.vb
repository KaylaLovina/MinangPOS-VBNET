<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1 = New Panel()
        Label1 = New Label()
        Button2 = New Button()
        Panel2 = New Panel()
        Button3 = New Button()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(108), CByte(38), CByte(38))
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(-4, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(792, 191)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Imprint MT Shadow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(279, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 43)
        Label1.TabIndex = 2
        Label1.Text = "MinangPOS"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(108), CByte(38), CByte(38))
        Button2.FlatStyle = FlatStyle.System
        Button2.Font = New Font("Stencil", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(233, 133)
        Button2.Name = "Button2"
        Button2.Size = New Size(165, 48)
        Button2.TabIndex = 1
        Button2.Text = "OWNER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 184)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(784, 277)
        Panel2.TabIndex = 1
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(108), CByte(38), CByte(38))
        Button3.FlatStyle = FlatStyle.System
        Button3.Font = New Font("Stencil", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(404, 133)
        Button3.Name = "Button3"
        Button3.Size = New Size(165, 48)
        Button3.TabIndex = 3
        Button3.Text = "KASIR"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 461)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmLogin"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button

End Class
