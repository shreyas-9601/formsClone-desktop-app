Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        DisplaySubmission()
    End Sub

    Private Sub LoadSubmissions()
        ' TODO: Load submissions from backend
        submissions = New List(Of Submission) From {
            New Submission With {.FullName = "John Doe", .EmailAddress = "john.doe@example.com", .PhoneNo = "1234567890", .GitHub = "https://github.com/johndoe", .Stopwatch = TimeSpan.FromMinutes(5)},
            New Submission With {.FullName = "Jane Smith", .EmailAddress = "jane.smith@example.com", .PhoneNo = "0987654321", .GitHub = "https://github.com/janesmith", .Stopwatch = TimeSpan.FromMinutes(10)}
        }
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            txtName.Text = submission.FullName
            txtEmail.Text = submission.EmailAddress
            txtPhone.Text = submission.PhoneNo
            txtGitHub.Text = submission.GitHub
            txtStopwatch.Text = submission.Stopwatch.ToString()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub
End Class