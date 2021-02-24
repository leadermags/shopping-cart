' Maggie Lin
' CITP150 - Intro to VB.NET Programming
' Assignment 7 - Programming Challenge 2
' Module for Shopping Cart System project. Holds constants and variables, and
' perform calculations.
' 8 October 2020

Module SubModule

    ' Global constants for Print Books
    Public Const g_decPIDidItYourWay As Decimal = 11.95D
    Public Const g_decPTheHistoryOfScotland As Decimal = 14.5D
    Public Const g_decPLearnCalculusInOneDay As Decimal = 29.95D
    Public Const g_decPFeelTheStress As Decimal = 18.5D
    Public Const g_strPIDidItYourWay = "I Did It Your Way (Print)"
    Public Const g_strPTheHistoryOfScotland = "The History of Scotland (Print)"
    Public Const g_strPLearnCalculusInOneDay = "Learn Calculus in One Day (Print)"
    Public Const g_strPFeelTheStress = "Feel the Stress (Print)"

    ' Global constants for Print Books
    Public Const g_decATheHistoryOfScotland As Decimal = 14.5D
    Public Const g_decALearnCalculusInOneDay As Decimal = 29.95D
    Public Const g_decATheScienceOfBodyLanguage As Decimal = 12.95D
    Public Const g_decARelaxationTechniques As Decimal = 11.5D
    Public Const g_strATheHistoryOfScotland = "The History of Scotland (Audio)"
    Public Const g_strALearnCalculusInOneDay = "Learn Calculus in One Day (Audio)"
    Public Const g_strATheScienceOfBodyLanguage = "The Science of Body Language (Audio)"
    Public Const g_strARelaxationTechniques = "Relaxation Techniques (Audio)"

    ' Global constants and variables for calculation purposes
    Public g_decSubtotal As Decimal = 0
    Public Const g_decTAX As Decimal = 0.06D
    Public decTax As Decimal
    Public Const g_decSHIPPING As Decimal = 2D
    Public g_decTotal As Decimal

    ' Sub procedure to calculate costs
    Public Sub calculate()

        decTax = g_decTAX * g_decSubtotal
        g_decTotal = g_decSubtotal + decTax + g_decSHIPPING

    End Sub

    ' Sub procedure to display costs
    Public Sub displayResults()

        ' If there is nothing in product list then labels will be empty
        If MainForm.lstProducts.Items.Count = 0 Then
            MainForm.lblShipping.Text = ""
            MainForm.lblTotal.Text = ""
        Else
            ' Otherwise display costs
            MainForm.lblSubtotal.Text = g_decSubtotal.ToString("c")
            MainForm.lblTax.Text = decTax.ToString("c")
            MainForm.lblShipping.Text = g_decSHIPPING.ToString("c")
            MainForm.lblTotal.Text = g_decTotal.ToString("c")
        End If

    End Sub

End Module
