Public Class TheFace

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles searchNameBtn.Click
        SearchFor()
    End Sub

    Private Sub viewDetailsBtn0_Click(sender As Object, e As EventArgs) Handles viewDetailsBtn0.Click
        ViewDetails(0)
    End Sub

    Private Sub viewDetailsBtn1_Click(sender As Object, e As EventArgs) Handles viewDetailsBtn1.Click
        ViewDetails(1)
    End Sub

    Private Sub ViewDetailsBtn2_Click(sender As Object, e As EventArgs) Handles ViewDetailsBtn2.Click
        ViewDetails(2)
    End Sub

    Private Sub phoneSearchBtn_Click(sender As Object, e As EventArgs) Handles phoneSearchBtn.Click
        SearchPhone(phoneSearchTxt.Text)
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles saveSettingsBtn.Click
        ' Save api keys to settings
        My.Settings.findPerson = findPersonTxt.Text
        My.Settings.reversePhone = reversePhoneTxt.Text
        My.Settings.Save()
    End Sub

    Private Sub TheFace_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Load api keys from settings
        findPersonTxt.Text = My.Settings.findPerson
        reversePhoneTxt.Text = My.Settings.reversePhone
    End Sub
End Class
