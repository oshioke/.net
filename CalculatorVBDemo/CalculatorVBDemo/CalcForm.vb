Public Class CalcForm

    Private Sub CalcForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isDotExistBool = False

    End Sub


    Private isDotExistBool As Boolean

    'remove zero at the start of number
    Public Sub RemoveZero(ByVal number As Integer)
        If CalcTextBox.Text = "0" Then
            CalcTextBox.Text = number

        Else
            CalcTextBox.Text &= number
        End If

    End Sub



    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles ZeroButton.Click
        RemoveZero(0)
    End Sub

    Private Sub OneButton_Click(sender As Object, e As EventArgs) Handles OneButton.Click
        RemoveZero(1)
    End Sub

    Private Sub TwoButton_Click(sender As Object, e As EventArgs) Handles TwoButton.Click
        RemoveZero(2)
    End Sub

    Private Sub ThreeButton_Click(sender As Object, e As EventArgs) Handles ThreeButton.Click
        RemoveZero(3)
    End Sub

    Private Sub FourButton_Click(sender As Object, e As EventArgs) Handles FourButton.Click
        RemoveZero(4)
    End Sub

    Private Sub FiveButton_Click(sender As Object, e As EventArgs) Handles FiveButton.Click
        RemoveZero(5)
    End Sub

    Private Sub SixButton_Click(sender As Object, e As EventArgs) Handles SixButton.Click
        RemoveZero(6)
    End Sub

    Private Sub SevenButton_Click(sender As Object, e As EventArgs) Handles SevenButton.Click
        RemoveZero(7)
    End Sub

    Private Sub EightButton_Click(sender As Object, e As EventArgs) Handles EightButton.Click
        RemoveZero(8)
    End Sub

    Private Sub NineButton_Click(sender As Object, e As EventArgs) Handles NineButton.Click
        RemoveZero(9)
    End Sub

    Private Sub DotButton_Click(sender As Object, e As EventArgs) Handles DotButton.Click
        If isDotExistBool = False Then
            CalcTextBox.Text &= "."
            isDotExistBool = True

        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        CalcTextBox.Text = ""
        CalcTextBox.Text = 0
    End Sub


End Class
