<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnPrevious = New Button()
        btnNext = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        txtStopwatch = New TextBox()
        StopwatchTime = New Label()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(226, 297)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(98, 30)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(364, 297)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(98, 30)
        btnNext.TabIndex = 1
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(157, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 21)
        Label1.TabIndex = 2
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(157, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 21)
        Label2.TabIndex = 3
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(157, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 21)
        Label3.TabIndex = 4
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(157, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 21)
        Label4.TabIndex = 5
        Label4.Text = "Github"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(296, 38)
        txtName.Name = "txtName"
        txtName.Size = New Size(130, 29)
        txtName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(296, 85)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(130, 29)
        txtEmail.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(296, 140)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(130, 29)
        txtPhone.TabIndex = 8
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(296, 195)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(130, 29)
        txtGitHub.TabIndex = 9
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(296, 251)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.Size = New Size(130, 29)
        txtStopwatch.TabIndex = 10
        ' 
        ' StopwatchTime
        ' 
        StopwatchTime.AutoSize = True
        StopwatchTime.Location = New Point(158, 254)
        StopwatchTime.Name = "StopwatchTime"
        StopwatchTime.Size = New Size(82, 21)
        StopwatchTime.TabIndex = 11
        StopwatchTime.Text = "Stopwatch"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StopwatchTime)
        Controls.Add(txtStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents StopwatchTime As Label
End Class
