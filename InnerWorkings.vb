Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Module InnerWorkings
    ' Request
    ' https://proapi.whitepages.com/3.0/person?name=Giaan+Qiuntero&address.city=Lynden&address.state_code=WA&api_key=KEYVAL
    ' FN, LN, CITY, STATE, KEY

    ' Set our variables for search
    Dim searchKey As String = My.Settings.findPerson
    Dim phoneKey As String = My.Settings.reversePhone
    Dim request As HttpWebRequest
    Dim response As HttpWebResponse = Nothing
    Dim reader As StreamReader
    Dim rawJson As String

    ' Structure our json response
    Public Class PhoneIntel
        Public Property id As String
        Public Property phone_number As String
        Public Property is_valid As Boolean
        Public Property country_calling_code As String
        Public Property line_type As String
        Public Property carrier As String
        Public Property is_prepaid As Object
        Public Property is_commercial As String
        Public Property belongs_to As BelongsTo()
        Public Property current_addresses As CurrentAddress()
        Public Property historical_addresses As HistoricalAddress()
        Public Property associated_people As AssociatedPeople()
        Public Property alternate_phones As String()
        Public Property error3 As Object
        Public Property warnings As Object()
    End Class

    Public Class BelongsTo
        Public Property id As String
        Public Property name As String
        Public Property firstname As String
        Public Property middlename As String
        Public Property lastname As String
        Public Property age_range As String
        Public Property gender As String
        Public Property type As String
        Public Property link_to_phone_start_date As String
    End Class

    Public Class LatLong
        Public Property latitude As Double
        Public Property longitude As Double
        Public Property accuracy As String
    End Class

    Public Class FoundAtAddress
        Public Property id As String
        Public Property location_type As String
        Public Property street_line_1 As String
        Public Property street_line_2 As Object
        Public Property city As String
        Public Property postal_code As String
        Public Property zip4 As String
        Public Property state_code As String
        Public Property country_code As String
        Public Property lat_long As LatLong
        Public Property is_active As String
        Public Property delivery_point As String
        Public Property link_to_person_start_date As String
        Public Property link_to_person_end_date As String
    End Class

    Public Class CurrentAddress
        Public Property id As String
        Public Property location_type As String
        Public Property street_line_1 As String
        Public Property street_line_2 As Object
        Public Property city As String
        Public Property postal_code As String
        Public Property zip4 As String
        Public Property state_code As String
        Public Property country_code As String
        Public Property lat_long As LatLong
        Public Property is_active As String
        Public Property delivery_point As String
        Public Property link_to_person_start_date As String
    End Class

    Public Class HistoricalAddress
        Public Property id As String
        Public Property location_type As String
        Public Property street_line_1 As String
        Public Property street_line_2 As Object
        Public Property city As String
        Public Property postal_code As String
        Public Property zip4 As String
        Public Property state_code As String
        Public Property country_code As String
        Public Property lat_long As LatLong
        Public Property is_active As String
        Public Property delivery_point As String
        Public Property link_to_person_start_date As String
        Public Property link_to_person_end_date As String
    End Class

    Public Class Phone
        Public Property id As String
        Public Property phone_number As String
        Public Property line_type As String
    End Class

    Public Class AssociatedPeople
        Public Property id As String
        Public Property name As String
        Public Property firstname As String
        Public Property middlename As String
        Public Property lastname As String
        Public Property relation As String
    End Class

    Public Class Person
        Public Property id As String
        Public Property name As String
        Public Property firstname As String
        Public Property middlename As String
        Public Property lastname As String
        Public Property alternate_names As Object()
        Public Property age_range As String
        Public Property gender As String
        Public Property found_at_address As FoundAtAddress
        Public Property current_addresses As CurrentAddress()
        Public Property historical_addresses As HistoricalAddress()
        Public Property phones As Phone()
        Public Property associated_people As AssociatedPeople()
    End Class

    Public Class wpJson
        Public Property count_person As Integer
        Public Property person As Person()
        Public Property warnings As String()
        Public Property error1 As Object
    End Class

    ' Visible switch
    Public Sub VisibleSwitch(ByVal num As String)
        If num >= 3 Then
            ' Show the group boxes
            TheFace.resultsBox0.Visible = True
            TheFace.resultsBox1.Visible = True
            TheFace.resultsBox2.Visible = True
            ' Show the labels
            TheFace.resultName0.Visible = True
            TheFace.resultName1.Visible = True
            TheFace.resultName2.Visible = True
            TheFace.resultAge0.Visible = True
            TheFace.resultAge1.Visible = True
            TheFace.resultAge2.Visible = True
            TheFace.resultGender0.Visible = True
            TheFace.resultGender1.Visible = True
            TheFace.resultGender2.Visible = True
            TheFace.resultCity0.Visible = True
            TheFace.resultCity1.Visible = True
            TheFace.resultCity2.Visible = True
            ' Show picture box
            TheFace.resultPb0.Visible = True
            TheFace.resultPb1.Visible = True
            TheFace.resultPb2.Visible = True
            ' Show buttons
            TheFace.viewDetailsBtn0.Visible = True
            TheFace.viewDetailsBtn1.Visible = True
            TheFace.ViewDetailsBtn2.Visible = True
        ElseIf num = 2 Then
            ' Show the group boxes
            TheFace.resultsBox0.Visible = True
            TheFace.resultsBox1.Visible = True
            TheFace.resultsBox2.Visible = False
            ' Show the labels
            TheFace.resultName0.Visible = True
            TheFace.resultName1.Visible = True
            TheFace.resultName2.Visible = False
            TheFace.resultAge0.Visible = True
            TheFace.resultAge1.Visible = True
            TheFace.resultAge2.Visible = False
            TheFace.resultGender0.Visible = True
            TheFace.resultGender1.Visible = True
            TheFace.resultGender2.Visible = False
            TheFace.resultCity0.Visible = True
            TheFace.resultCity1.Visible = True
            TheFace.resultCity2.Visible = False
            ' Show picture box
            TheFace.resultPb0.Visible = True
            TheFace.resultPb1.Visible = True
            TheFace.resultPb2.Visible = False
            ' Show buttons
            TheFace.viewDetailsBtn0.Visible = True
            TheFace.viewDetailsBtn1.Visible = True
            TheFace.ViewDetailsBtn2.Visible = False
        ElseIf num = 1 Then
            ' Show the group boxes
            TheFace.resultsBox0.Visible = True
            TheFace.resultsBox1.Visible = False
            TheFace.resultsBox2.Visible = False
            ' Show the labels
            TheFace.resultName0.Visible = True
            TheFace.resultName1.Visible = False
            TheFace.resultName2.Visible = False
            TheFace.resultAge0.Visible = True
            TheFace.resultAge1.Visible = False
            TheFace.resultAge2.Visible = False
            TheFace.resultGender0.Visible = True
            TheFace.resultGender1.Visible = False
            TheFace.resultGender2.Visible = False
            TheFace.resultCity0.Visible = True
            TheFace.resultCity1.Visible = False
            TheFace.resultCity2.Visible = False
            ' Show picture box
            TheFace.resultPb0.Visible = True
            TheFace.resultPb1.Visible = False
            TheFace.resultPb2.Visible = False
            ' Show buttons
            TheFace.viewDetailsBtn0.Visible = True
            TheFace.viewDetailsBtn1.Visible = False
            TheFace.ViewDetailsBtn2.Visible = False
        ElseIf num = 0 Then
            ' Show the group boxes
            TheFace.resultsBox0.Visible = False
            TheFace.resultsBox1.Visible = False
            TheFace.resultsBox2.Visible = False
            ' Show the labels
            TheFace.resultName0.Visible = False
            TheFace.resultName1.Visible = False
            TheFace.resultName2.Visible = False
            TheFace.resultAge0.Visible = False
            TheFace.resultAge1.Visible = False
            TheFace.resultAge2.Visible = False
            TheFace.resultGender0.Visible = False
            TheFace.resultGender1.Visible = False
            TheFace.resultGender2.Visible = False
            TheFace.resultCity0.Visible = False
            TheFace.resultCity1.Visible = False
            TheFace.resultCity2.Visible = False
            ' Show picture box
            TheFace.resultPb0.Visible = False
            TheFace.resultPb1.Visible = False
            TheFace.resultPb2.Visible = False
            ' Show buttons
            TheFace.viewDetailsBtn0.Visible = False
            TheFace.viewDetailsBtn1.Visible = False
            TheFace.ViewDetailsBtn2.Visible = False
        End If
    End Sub

    ' Search by name
    Public Sub SearchFor()
        ' Check to see if they changed the values before we search
        TheFace.Text = "Checking search values..."
        If TheFace.fnTxt.Text <> "First Name" And TheFace.lnTxt.Text <> "Last Name" Then
            ' Search for values
            Dim dynamicURL As String

            ' Check to see if we are using city & state
            If TheFace.Label3.Text <> "City" And TheFace.stateTxt.Text <> "State" Then
                ' Check the city with state then run response through Json parser
                dynamicURL = "https://proapi.whitepages.com/3.0/person?name=" & TheFace.fnTxt.Text & "+" & TheFace.lnTxt.Text & "&address.city=" & TheFace.cityTxt.Text & "&address.state_code=" & TheFace.stateTxt.Text & "&api_key=" & searchKey
                JsonParse(dynamicURL)
                TheFace.Text = "Json Parsed..."

                ' Declare Json Root and deserialize
                Dim infoPull As New wpJson
                infoPull = JsonConvert.DeserializeObject(Of wpJson)(rawJson)
                TheFace.Text = "Json Deserialized..."

                ' Count the results and update the user
                Dim personcount As String = infoPull.count_person.ToString
                TheFace.statusTxt.Text = personcount & " result(s) found."

                ' Set components to visible or not visible
                VisibleSwitch(personcount)
                TheFace.Text = "Results found..."

                ' Control search variable 
                Dim matches() As Control

                Try
                    ' Logic checks and search for control to update, then update the text
                    TheFace.Text = "Updating labels..."
                    If personcount >= 3 Then ' 3 or more results
                        For i As Integer = 0 To 2 ' index starts at 0, we pull the first 3 results
                            matches = TheFace.Controls.Find("resultName" & i, True) ' Loops controls named `resultName#` where # is variable
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel) ' Update the results
                                fl.Text = "Name: " & infoPull.person(i).name
                            End If
                            ' Repeat this process
                            matches = TheFace.Controls.Find("resultAge" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Age Range: " & infoPull.person(i).age_range
                            End If

                            matches = TheFace.Controls.Find("resultGender" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Gender: " & infoPull.person(i).gender
                            End If

                            matches = TheFace.Controls.Find("resultCity" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "City: " & infoPull.person(i).found_at_address.city
                            End If
                        Next
                    ElseIf personcount = 2 Then
                        For i As Integer = 0 To 1
                            matches = TheFace.Controls.Find("resultName" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Name: " & infoPull.person(i).name
                            End If

                            matches = TheFace.Controls.Find("resultAge" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Age Range: " & infoPull.person(i).age_range
                            End If

                            matches = TheFace.Controls.Find("resultGender" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Gender: " & infoPull.person(i).gender
                            End If

                            matches = TheFace.Controls.Find("resultCity" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "City: " & infoPull.person(i).found_at_address.city
                            End If
                        Next
                    ElseIf personcount = 1 Then
                        TheFace.resultName0.Text = "Name: " & infoPull.person(0).name
                        TheFace.resultAge0.Text = "Age Range: " & infoPull.person(0).age_range
                        TheFace.resultGender0.Text = "Gender: " & infoPull.person(0).gender
                        TheFace.resultCity0.Text = "City: " & infoPull.person(0).found_at_address.city
                    End If
                Catch ex As Exception
                    TheFace.Text = "Error: " & ex.ToString
                End Try
            ElseIf TheFace.Label3.Text = "City" And TheFace.stateTxt.Text <> "State" Then ' Repeat of above
                ' Dont include city
                dynamicURL = "https://proapi.whitepages.com/3.0/person?name=" & TheFace.fnTxt.Text & "+" & TheFace.lnTxt.Text & "&address.state_code=" & TheFace.stateTxt.Text & "&api_key=" & searchKey
                JsonParse(dynamicURL)
                TheFace.Text = "Json Parsed..."

                Dim infoPull As New wpJson
                infoPull = JsonConvert.DeserializeObject(Of wpJson)(rawJson)
                TheFace.Text = "Json Deserialized..."

                Dim personcount As String = infoPull.count_person.ToString
                TheFace.statusTxt.Text = personcount & " result(s) found."

                VisibleSwitch(personcount)
                TheFace.Text = "Results found..."

                Dim matches() As Control
                Try
                    TheFace.Text = "Updating labels..."
                    If personcount >= 3 Then
                        For i As Integer = 0 To 2
                            matches = TheFace.Controls.Find("resultName" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Name: " & infoPull.person(i).name
                            End If

                            matches = TheFace.Controls.Find("resultAge" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Age Range: " & infoPull.person(i).age_range
                            End If

                            matches = TheFace.Controls.Find("resultGender" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Gender: " & infoPull.person(i).gender
                            End If

                            matches = TheFace.Controls.Find("resultCity" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "City: " & infoPull.person(i).found_at_address.city
                            End If
                        Next
                    ElseIf personcount = 2 Then
                        For i As Integer = 0 To 1
                            matches = TheFace.Controls.Find("resultName" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Name: " & infoPull.person(i).name
                            End If

                            matches = TheFace.Controls.Find("resultAge" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Age Range: " & infoPull.person(i).age_range
                            End If

                            matches = TheFace.Controls.Find("resultGender" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Gender: " & infoPull.person(i).gender
                            End If

                            matches = TheFace.Controls.Find("resultCity" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "City: " & infoPull.person(i).found_at_address.city
                            End If
                        Next
                    ElseIf personcount = 1 Then
                        TheFace.resultName0.Text = "Name: " & infoPull.person(0).name
                        TheFace.resultAge0.Text = "Age Range: " & infoPull.person(0).age_range
                        TheFace.resultGender0.Text = "Gender: " & infoPull.person(0).gender
                        TheFace.resultCity0.Text = "City: " & infoPull.person(0).found_at_address.city
                    End If
                Catch ex As Exception
                    TheFace.Text = "Error: " & ex.ToString
                End Try
            ElseIf TheFace.Label3.Text = "City" And TheFace.stateTxt.Text = "State" Then ' Repeat of above
                ' Dont include city or state
                dynamicURL = "https://proapi.whitepages.com/3.0/person?name=" & TheFace.fnTxt.Text & "+" & TheFace.lnTxt.Text & "&api_key=" & searchKey
                JsonParse(dynamicURL)
                TheFace.Text = "Json Parsed..."

                Dim infoPull As New wpJson
                infoPull = JsonConvert.DeserializeObject(Of wpJson)(rawJson)
                TheFace.Text = "Json Deserialized..."

                Dim personcount As String = infoPull.count_person.ToString
                TheFace.statusTxt.Text = personcount & " result(s) found."

                VisibleSwitch(personcount)
                TheFace.Text = "Results found..."

                Dim matches() As Control
                Try
                    TheFace.Text = "Updating labels..."
                    If personcount >= 3 Then
                        For i As Integer = 0 To 2
                            matches = TheFace.Controls.Find("resultName" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Name: " & infoPull.person(i).name
                            End If

                            matches = TheFace.Controls.Find("resultAge" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Age Range: " & infoPull.person(i).age_range
                            End If

                            matches = TheFace.Controls.Find("resultGender" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Gender: " & infoPull.person(i).gender
                            End If

                            matches = TheFace.Controls.Find("resultCity" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "City: " & infoPull.person(i).found_at_address.city
                            End If
                        Next
                    ElseIf personcount = 2 Then
                        For i As Integer = 0 To 1
                            matches = TheFace.Controls.Find("resultName" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Name: " & infoPull.person(i).name
                            End If

                            matches = TheFace.Controls.Find("resultAge" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Age Range: " & infoPull.person(i).age_range
                            End If

                            matches = TheFace.Controls.Find("resultGender" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "Gender: " & infoPull.person(i).gender
                            End If

                            matches = TheFace.Controls.Find("resultCity" & i, True)
                            If matches.Length > 0 AndAlso TypeOf matches(0) Is FlatLabel Then
                                Dim fl As FlatLabel = DirectCast(matches(0), FlatLabel)
                                fl.Text = "City: " & infoPull.person(i).found_at_address.city
                            End If
                        Next
                    ElseIf personcount = 1 Then
                        TheFace.resultName0.Text = "Name: " & infoPull.person(0).name
                        TheFace.resultAge0.Text = "Age Range: " & infoPull.person(0).age_range
                        TheFace.resultGender0.Text = "Gender: " & infoPull.person(0).gender
                        TheFace.resultCity0.Text = "City: " & infoPull.person(0).found_at_address.city
                    End If
                Catch ex As Exception
                    TheFace.Text = "Error: " & ex.ToString
                End Try
            End If
        Else
            ' Show error message
            TheFace.statusTxt.Text = "Error: Please enter a valid first and last name."
        End If
    End Sub

    ' Json parser
    Public Sub JsonParse(ByVal url As String)
        ' Take request url then take the response and save it to our global variable
        request = DirectCast(WebRequest.Create(url), HttpWebRequest)
        response = DirectCast(request.GetResponse(), HttpWebResponse)
        reader = New StreamReader(response.GetResponseStream())
        rawJson = reader.ReadToEnd

        ' Close the reader
        reader.Close()
    End Sub

    ' Detail loader
    Public Sub ViewDetails(ByVal num As String)
        ' Declare root of Json and deserialize
        Dim infoPull As New wpJson
        infoPull = JsonConvert.DeserializeObject(Of wpJson)(rawJson)

        ' Navigate the browser in the details tab
        TheFace.geoLocate.Navigate("https://www.bing.com/maps?q=" & infoPull.person(num).found_at_address.lat_long.latitude & "," & infoPull.person(num).found_at_address.lat_long.longitude)
        TheFace.FlatTabControl1.SelectedIndex = 2 ' Set the tab to `Details`
        ' Update the user on progress
        TheFace.stateTxt.Text = "Loading info for " & infoPull.person(num).name
        TheFace.detailsNameTxt.Text = infoPull.person(num).name
        TheFace.detailsAddressTxt.Text = infoPull.person(num).found_at_address.street_line_1 & " " & infoPull.person(num).found_at_address.city & ", " & infoPull.person(num).found_at_address.state_code & " " & infoPull.person(num).found_at_address.postal_code & "-" & infoPull.person(num).found_at_address.zip4
        ' Logic check
        If (Not (infoPull.person(num).phones.Length = 0)) Then
            TheFace.phonesComboBox.Clear() ' Clear the combo box
            TheFace.detailsPhonesTxt.Text = infoPull.person(num).phones.Count & " Phone numbers found"
            ' Loop through and add the phone numbers
            For i As Integer = 0 To infoPull.person(num).phones.Count - 1
                TheFace.phonesComboBox.AddItem(infoPull.person(num).phones(i).phone_number & " - " & infoPull.person(num).phones(i).line_type)
                TheFace.phonesComboBox.Visible = True
            Next
        Else
            ' No phones found, clear the list and update user
            TheFace.detailsPhonesTxt.Text = "0 Phone numbers found"
            TheFace.phonesComboBox.Visible = False
        End If
    End Sub

    ' Search by phone
    Public Sub SearchPhone(ByVal phonenum As String)
        ' Wrap everything in a try statement just incase
        Try
            ' Check to see if they changed the values before we search
            If phonenum <> Nothing Then
                ' Set url and parse the Json results
                Dim dynamicURL As String = "https://proapi.whitepages.com/3.0/phone?phone=" & phonenum & "&api_key=" & phoneKey
                JsonParse(dynamicURL)
                TheFace.Text = "Json Parsed..."

                ' Declare our variable for the root of the Json
                Dim infoPull As New PhoneIntel
                ' Deserialize Json
                infoPull = JsonConvert.DeserializeObject(Of PhoneIntel)(rawJson)
                TheFace.Text = "Json Deserialized..."

                ' Check to see if submission was valid
                If infoPull.id IsNot Nothing Then
                    ' Logic check
                    If infoPull.is_valid = "false" Then
                        TheFace.statusTxt.Text = infoPull.warnings.ToString ' Show warning
                    Else ' Result was valid
                        TheFace.Text = "Valid response found..."
                        TheFace.statusTxt.Text = "Info Pulled for Phone #: " & phonenum
                        TheFace.phoneName1.Text = "Name: " & infoPull.belongs_to(0).name
                        TheFace.phoneAge1.Text = "Age Range: " & infoPull.belongs_to(0).age_range
                        TheFace.phoneGender1.Text = "Gender: " & infoPull.belongs_to(0).gender
                        TheFace.phoneCity1.Text = "City: " & infoPull.current_addresses(0).city
                        TheFace.phoneAddress1.Text = infoPull.current_addresses(0).street_line_1
                        TheFace.phoneLineType.Text = "Type: " & infoPull.line_type
                        TheFace.phoneCarrier.Text = "Carrier: " & infoPull.carrier
                        ' Logic check since is_commercial is boolean
                        If infoPull.is_commercial = True Then
                            TheFace.phoneComm.Text = "Is Commercial?: True"
                        Else
                            TheFace.phoneComm.Text = "Is Commercial?: False"
                        End If
                        ' Logic check and loading alternate phones
                        If infoPull.alternate_phones.Length <> 0 Then
                            TheFace.phonesComboBox.Clear() ' Reset the alt phones
                            Dim cnt As Integer = infoPull.alternate_phones.Length ' Count the results
                            For i = 0 To cnt ' Loop through the results and add them to the combo box
                                TheFace.altPhonesCB.Items.Add(infoPull.alternate_phones(i))
                            Next
                        End If
                        TheFace.Text = "Finished loading..."
                        ' Navigate the webbrowser to show lat and long
                        TheFace.geoLocate2.Navigate("https://www.bing.com/maps?q=" & infoPull.current_addresses(0).lat_long.latitude & "," & infoPull.current_addresses(0).lat_long.longitude)
                    End If
                Else
                    TheFace.statusTxt.Text = "Error: " & infoPull.warnings(0)
                End If
            End If
        Catch ex As Exception
            TheFace.Text = "Error: " & ex.ToString
        End Try
    End Sub
End Module
