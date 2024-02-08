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
        Button1 = New Button()
        first = New Label()
        Label2 = New Label()
        pogi = New TextBox()
        love = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(199, 63)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "multi"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' first
        ' 
        first.AutoSize = True
        first.Location = New Point(24, 45)
        first.Name = "first"
        first.Size = New Size(27, 15)
        first.TabIndex = 1
        first.Text = "first"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(361, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 2
        Label2.Text = "second"
        ' 
        ' pogi
        ' 
        pogi.Location = New Point(24, 63)
        pogi.Name = "pogi"
        pogi.Size = New Size(100, 23)
        pogi.TabIndex = 3
        ' 
        ' love
        ' 
        love.Location = New Point(361, 63)
        love.Name = "love"
        love.Size = New Size(100, 23)
        love.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(548, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 5
        Label3.Text = "sagot"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(love)
        Controls.Add(pogi)
        Controls.Add(Label2)
        Controls.Add(first)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents first As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pogi As TextBox
    Friend WithEvents love As TextBox
    Friend WithEvents Label3 As Label
End Class
