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
        btnGreeting = New Button()
        Label1 = New Label()
        txtCountry = New TextBox()
        SuspendLayout()
        ' 
        ' btnGreeting
        ' 
        btnGreeting.Location = New Point(229, 300)
        btnGreeting.Name = "btnGreeting"
        btnGreeting.Size = New Size(112, 34)
        btnGreeting.TabIndex = 0
        btnGreeting.Text = "Greeting"
        btnGreeting.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(174, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 25)
        Label1.TabIndex = 1
        Label1.Text = "Name of Country"
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(395, 157)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(150, 31)
        txtCountry.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtCountry)
        Controls.Add(Label1)
        Controls.Add(btnGreeting)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGreeting As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCountry As TextBox
End Class
