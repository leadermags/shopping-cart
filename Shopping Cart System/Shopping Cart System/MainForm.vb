' Maggie Lin
' This program simulates a shopping cart for different types of books. Users can 
' select audio books or print books, and a form will pop up depending on whether
' they want a print book or audio book. Users can add to or remove from product list.
' This program also includes a module so all the forms can interact with product list.

Public Class MainForm

    ' Sub procedure to remove item from list and recalculate costs
    Public Sub removeProduct()

        lblMessage.Text = ""

        ' If there is nothing on list or nothing selected, print message
        If lstProducts.Items.Count = 0 Or lstProducts.SelectedIndex = -1 Then

            ' If nothing is selected, display message
            lblMessage.Text = "Nothing selected."

        Else

            ' Matches each selected item to book title then recalculate
            If lstProducts.SelectedItem.ToString() = g_strALearnCalculusInOneDay Then
                g_decSubtotal -= g_decALearnCalculusInOneDay
                calculate()
                displayResults()
            ElseIf lstProducts.SelectedItem.ToString() = g_strARelaxationTechniques Then
                g_decSubtotal -= g_decARelaxationTechniques
                calculate()
                displayResults()
            ElseIf lstProducts.SelectedItem.ToString() = g_strATheHistoryOfScotland Then
                g_decSubtotal -= g_decATheHistoryOfScotland
                calculate()
                displayResults()
            ElseIf lstProducts.SelectedItem.ToString() = g_strATheScienceOfBodyLanguage Then
                g_decSubtotal -= g_decATheScienceOfBodyLanguage
                calculate()
                displayResults()
            ElseIf lstProducts.SelectedItem.ToString() = g_strPFeelTheStress Then
                g_decSubtotal -= g_decPFeelTheStress
                calculate()
                displayResults()
            ElseIf lstProducts.SelectedItem.ToString() = g_strPIDidItYourWay Then
                g_decSubtotal -= g_decPIDidItYourWay
                calculate()
                displayResults()
            ElseIf lstProducts.SelectedItem.ToString() = g_strPLearnCalculusInOneDay Then
                g_decSubtotal -= g_decPLearnCalculusInOneDay
                calculate()
                displayResults()
            ElseIf lstProducts.SelectedItem.ToString() = g_strPTheHistoryOfScotland Then
                g_decSubtotal -= g_decPTheHistoryOfScotland
                calculate()
                displayResults()
            End If

            ' Remove from list
            lstProducts.Items.RemoveAt(lstProducts.SelectedIndex())

        End If

    End Sub

    ' Sub procedure to reset results by clearing
    Public Sub clearResults()

        ' Reverts calculations back
        g_decSubtotal = 0
        decTax = 0
        g_decTotal = 0

        ' Set labels to empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblShipping.Text = String.Empty
        lblTotal.Text = String.Empty
        lblMessage.Text = String.Empty

        ' Clear items in list
        lstProducts.Items.Clear()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close() ' Closes the Shopping Cart system Main Form

    End Sub

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click

        ' Opens Print Books form
        Dim frmPrintBooks As New PrintBooksForm
        frmPrintBooks.ShowDialog()

    End Sub

    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click

        ' Opens Audio Books form
        Dim frmAudioBooks As New AudioBooksForm
        frmAudioBooks.ShowDialog()

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

        clearResults() ' Calls procedure to reset form

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        removeProduct() ' Calls procedure to remove product

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        AboutForm.ShowDialog() ' Opens About page

    End Sub
End Class
