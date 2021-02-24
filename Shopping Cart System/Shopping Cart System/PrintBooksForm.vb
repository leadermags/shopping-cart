' Maggie Lin
' CITP150 - Intro to VB.NET Programming
' Assignment 7 - Programming Challenge 2
' Pop up form from MainForm. Contains printed book products that users can add to
' their cart/list.
' 8 October 2020

Public Class PrintBooksForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() ' Closes Print Books form
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click

        ' Clears error message on Main Form
        MainForm.lblMessage.Text = ""

        ' Select case to add into Main Form's product list then calculate 
        ' and display results
        Select Case lstPrint.SelectedIndex
            Case 0
                MainForm.lstProducts.Items.Add(g_strPIDidItYourWay)
                g_decSubtotal += g_decPIDidItYourWay
                calculate()
                displayResults()
            Case 1
                MainForm.lstProducts.Items.Add(g_strPTheHistoryOfScotland)
                g_decSubtotal += g_decPTheHistoryOfScotland
                calculate()
                displayResults()
            Case 2
                MainForm.lstProducts.Items.Add(g_strPLearnCalculusInOneDay)
                g_decSubtotal += g_decPLearnCalculusInOneDay
                calculate()
                displayResults()
            Case 3
                MainForm.lstProducts.Items.Add(g_strPFeelTheStress)
                g_decSubtotal += g_decPFeelTheStress
                calculate()
                displayResults()
        End Select

    End Sub
End Class