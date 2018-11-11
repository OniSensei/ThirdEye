Imports System.Text.RegularExpressions

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
        statusTxt.Text = "Loading API settings..."
        findPersonTxt.Text = My.Settings.findPerson
        reversePhoneTxt.Text = My.Settings.reversePhone
        FlatTextBox1.Text = "Identify, enhance, and update records from a single data attribute. Leverage over 30+ years of address history, 600M+ phone-to-person matches, 275M unique person-to-address matches, and more." & vbCrLf & vbCrLf & "A Find Person request allows you To identify a Single person And find details including demographics, location And phones associated With that person."
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        ' Load API webpage
        Process.Start("https://pro.lookup.whitepages.com/api")
        statusTxt.Text = "Opening https://pro.lookup.whitepages.com/api in the default browser."
    End Sub

    Private Sub FlatButton1_Click_2(sender As Object, e As EventArgs) Handles FlatButton1.Click
        ' Load API documentation
        Process.Start("https://pro.whitepages.com/developer/documentation/api-overview/")
        statusTxt.Text = "Opening https://pro.whitepages.com/developer/documentation/api-overview/ in the default browser."

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles phonesComboBox.SelectedIndexChanged
        Dim number As String = Regex.Replace(phonesComboBox.SelectedItem.ToString, "[^0-9]", "") ' Remove all text thats not numbers
        SearchPhone(number) ' Run reverse phone lookup for the selected number
        FlatTabControl1.SelectedIndex = 1 ' Set the tab to `Phone Search`
        phoneSearchTxt.Text = number
    End Sub
End Class
