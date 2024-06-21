Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class NewSubmissionForm
    Private stopwatch As Stopwatch = New Stopwatch()
    Private client As HttpClient = New HttpClient()

    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStartPause.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
            .FullName = txtName.Text,
            .EmailAddress = txtEmail.Text,
            .PhoneNo = txtPhone.Text,
            .GitHub = txtGithub.Text,
            .Stopwatch = stopwatch.Elapsed
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful!")
        Else
            MessageBox.Show("Failed to submit.")
        End If
    End Sub

    Private Sub NewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up keyboard shortcut for Ctrl+S
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf NewSubmissionForm_KeyDown
    End Sub

    Private Sub NewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
