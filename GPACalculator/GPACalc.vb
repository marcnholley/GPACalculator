Public Class frmGPACalc
    'Marc Holley, CIS159 23925, Elliot R. Cherner, 10/12/15'
    Public floatingPoints As Double, floatingHours As Integer
    'Records class credit hours and grade'
    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        'Declaring and initializing varibles'
        Dim qualityPoints As Double
        Dim creditHours As Integer
        Dim grade As String
        'Boolean function branching statement'
        If Not DataOK() Then
            MessageBox.Show("Enter valid grade and credit hours")

        Else
            grade = cmbbxGrade.SelectedItem
            creditHours = CInt(txtbxHours.Text)
            qualityPoints = CalculatePoints(grade, creditHours)
            floatingPoints += qualityPoints
            floatingHours += creditHours
            ClearForm()
        End If
    End Sub
    'Sub that clears the form'
    Public Sub ClearForm()
        cmbbxGrade.SelectedIndex = -1
        cmbbxGrade.Text = "Select Grade"
        txtbxHours.Text = ""
    End Sub
    Function DataOK() As Boolean
        If txtbxHours.Text = "" Or (Not IsNumeric(txtbxHours.Text)) Then
            Return False
        Else
            Return True
        End If
    End Function
    'Function that processes letter grades and credit hours in to quality points'
    Public Function CalculatePoints(grade As String, creditHours As Integer)
        'Declaring and initializing varibles'
        Dim qualityPoints As Double
        'Case branching statement'
        Select Case (grade)
            Case "A"
                qualityPoints = 4.0 * creditHours
            Case "B"
                qualityPoints = 3.0 * creditHours
            Case "C"
                qualityPoints = 2.0 * creditHours
            Case "D"
                qualityPoints = 1.0 * creditHours
            Case "F"
                qualityPoints = 0.0 * creditHours
        End Select
        Return qualityPoints
    End Function
    'Sub that calculates GPA'
    Private Sub btnGPA_Click(sender As Object, e As EventArgs) Handles btnGPA.Click
        'Declaring and initializing varibles'
        Dim gpa As Double
        'If branching statement'
        If floatingHours > 0 Then
            'Calculation process'
            gpa = floatingPoints / floatingHours
            'GPA output'
            txtbxGPA.Text = FormatNumber(gpa, 2)
        Else
            MessageBox.Show("No course were entered yet")
        End If
        Exit Sub
    End Sub

End Class
