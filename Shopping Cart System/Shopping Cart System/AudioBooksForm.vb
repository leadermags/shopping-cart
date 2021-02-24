' Maggie Lin
' Pop up form from MainForm. Contains audio book products that users can add to
' their cart/list.

Public Class AudioBooksForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() ' Closes Audio Books form
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click

        ' Clears error message on Main Form
        MainForm.lblMessage.Text = ""

        ' Select case to add into Main Form's product list then calculate 
        ' and display results
        Select Case lstAudio.SelectedIndex
            Case 0
                MainForm.lstProducts.Items.Add(g_strALearnCalculusInOneDay)
                g_decSubtotal += g_decALearnCalculusInOneDay
                calculate()
                displayResults()
            Case 1
                MainForm.lstProducts.Items.Add(g_strARelaxationTechniques)
                g_decSubtotal += g_decARelaxationTechniques
                calculate()
                displayResults()
            Case 2
                MainForm.lstProducts.Items.Add(g_strATheHistoryOfScotland)
                g_decSubtotal += g_decATheHistoryOfScotland
                calculate()
                displayResults()
            Case 3
                MainForm.lstProducts.Items.Add(g_strATheScienceOfBodyLanguage)
                g_decSubtotal += g_decATheScienceOfBodyLanguage
                calculate()
                displayResults()
        End Select

    End Sub
End Class