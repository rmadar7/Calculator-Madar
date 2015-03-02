' Programmed By: Ryan Madar
' Project:       Calculator
' Date:          1/28/2013

Public Class Form1

    Private Sub modButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modButton.Click
        answerLabel.Text = Integer.Parse(num1TextBox.Text) Mod Integer.Parse(num2TextBox.Text)
    End Sub

    Private Sub additionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles additionButton.Click
        answerLabel.Text = Integer.Parse(num1TextBox.Text) + Integer.Parse(num2TextBox.Text)
    End Sub

    Private Sub integerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles integerButton.Click
        answerLabel.Text = Integer.Parse(num1TextBox.Text) \ Integer.Parse(num2TextBox.Text)
    End Sub

    Private Sub multiButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiButton.Click
        answerLabel.Text = Integer.Parse(num1TextBox.Text) * Integer.Parse(num2TextBox.Text)
    End Sub

    Private Sub subtractbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtractbutton.Click
        answerLabel.Text = Integer.Parse(num1TextBox.Text) - Integer.Parse(num2TextBox.Text)
    End Sub

    Private Sub divisionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divisionButton.Click
        answerLabel.Text = Integer.Parse(num1TextBox.Text) / Integer.Parse(num2TextBox.Text)
    End Sub
End Class
