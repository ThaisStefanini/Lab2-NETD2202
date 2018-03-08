Option Strict On
''' Name:   Lab2SemesterAverage
''' Author: Thais Stefanini
''' Date:   16 Feb 2018
''' Description:
'''         A form that shows the letter for each grade inputed. 
'''         After inputing 6 grades, this form calculate the average grade 
'''         for semester and shows the average letter too.
'''References used: 
'''         https://msdn.microsoft.com/en-us/library/system.windows.forms.control.getnextcontrol(v=vs.110).aspx
'''         http://www.dreamincode.net/forums/topic/194533-getting-the-value-of-all-textbox-in-an-array/
Public Class frmSemesterAverage
    ''' <summary>
    ''' End the application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Close()
    End Sub

    ''' <summary>
    ''' Clear the screen.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        ' Call a subroutine to clear all controls 
        ' It also enables the Calculate button and the textboxes
        ClearScreen()
    End Sub

    ''' <summary>
    ''' Reset all labels and textboxes in the screen.
    ''' </summary>
    Private Sub ClearScreen()
        ' Clear the textboxes
        tbCourse1.Text = String.Empty
        tbCourse2.Text = String.Empty
        tbCourse3.Text = String.Empty
        tbCourse4.Text = String.Empty
        tbCourse5.Text = String.Empty
        tbCourse6.Text = String.Empty

        ' Enable the textboxes
        tbCourse1.ReadOnly = False
        tbCourse2.ReadOnly = False
        tbCourse3.ReadOnly = False
        tbCourse4.ReadOnly = False
        tbCourse5.ReadOnly = False
        tbCourse6.ReadOnly = False

        ' Clear the labels for Letters
        lbCourse1Letter.Text = String.Empty
        lbCourse2Letter.Text = String.Empty
        lbCourse3Letter.Text = String.Empty
        lbCourse4Letter.Text = String.Empty
        lbCourse5Letter.Text = String.Empty
        lbCourse6Letter.Text = String.Empty

        ' Clear the Semester Average results
        lbSemesterAverage.Text = String.Empty
        lbSemesterLetter.Text = String.Empty

        ' Set focus on the first course textbox
        tbCourse1.Focus()

        ' Clear the message box
        lbMessage.Text = String.Empty

        ' Enable the Calculate button
        btCalculate.Enabled = True

    End Sub

    ''' <summary>
    ''' All textboxes will be checked by this event.
    ''' Here the user input will be validate, if valid
    ''' the letter will be determined and displayed in the label next to it
    ''' If not valid a error message will be displayed in the Message Label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbCourse_Leave(sender As Object, e As EventArgs) Handles tbCourse1.Leave, tbCourse6.Leave, tbCourse5.Leave, tbCourse4.Leave, tbCourse3.Leave, tbCourse2.Leave
        Dim inputGrade As String = String.Empty
        Dim isValid As Boolean = False
        Dim errorMessage As String = String.Empty
        Dim inputGradeDouble As Double = 0.0
        Dim letterGrade As String = String.Empty

        ' Clear the Message label, so a odd message is not displayed
        lbMessage.Text = String.Empty

        inputGrade = CType(sender, TextBox).Text

        ' Call Subroutine to validate user input
        ValidateGrade(inputGrade, errorMessage, isValid)

        If isValid Then
            ' if it is Valid, then the user input is a number and can be moved to a double variable
            inputGradeDouble = Convert.ToDouble(inputGrade)

            ' Call a subroutine to determine the letter for this Course
            DetermineLetterGrade(inputGradeDouble, letterGrade)

            ' Output the letter in the next control (Tab order)
            GetNextControl(CType(sender, TextBox), True).Text = letterGrade

        Else
            ' Display error message
            lbMessage.Text = "Please ensure that what you input" + errorMessage

            ' Keep the focus In this control, And select its text
            ' Unless the first course is blank, than move the focus to the first Textbox
            ' This is necessary because of the Reset Button
            If tbCourse1.Text Is String.Empty Then
                tbCourse1.Focus()
            Else
                CType(sender, TextBox).Focus()
                CType(sender, TextBox).SelectionStart = 0
                CType(sender, TextBox).SelectionLength = CType(sender, TextBox).Text.Length
            End If
        End If


    End Sub

    ''' <summary>
    ''' The Subroutine validate the user input
    ''' It also format part of the error message, with the correct range.
    ''' </summary>
    ''' <param name="inputGrade"></param>
    ''' <param name="errorMessage"></param>
    ''' <param name="isValid"></param>
    Private Sub ValidateGrade(inputGrade As String, ByRef errorMessage As String, ByRef isValid As Boolean)
        ' Create constants for the range
        Const MINIMUM = 0.0
        Const MAXIMUM = 100

        ' Create a variable to hold the value as a double
        Dim inputGradeDouble As Double = 0.0

        ' Ensure that "isValid" is False
        isValid = False

        ' First check if it is empty
        ' Then check if it is numeric
        ' And then check if it is in the range
        If inputGrade IsNot String.Empty AndAlso
            Double.TryParse(inputGrade, inputGradeDouble) AndAlso
            inputGradeDouble >= MINIMUM And inputGradeDouble <= MAXIMUM Then

            isValid = True
        Else
            errorMessage = " is a number between " + MINIMUM.ToString("n0") + " and " + MAXIMUM.ToString("n0") + "!"
        End If

    End Sub
    ''' <summary>
    ''' This subroutine only determine the letter for the grade
    ''' </summary>
    ''' <param name="Grade"></param>
    ''' <param name="letterGrade"></param>
    Private Sub DetermineLetterGrade(grade As Double, ByRef letterGrade As String)
        ' This constants are the lower limit for this letter, letter F is for zero
        Const LETTER_A_PLUS = 90.0
        Const LETTER_A = 85.0
        Const LETTER_A_MINUS = 80.0
        Const LETTER_B_PLUS = 77.0
        Const LETTER_B = 73.0
        Const LETTER_B_MINUS = 70.0
        Const LETTER_C_PLUS = 67.0
        Const LETTER_C = 63.0
        Const LETTER_C_MINUS = 60.0
        Const LETTER_D_PLUS = 57.0
        Const LETTER_D = 53.0
        Const LETTER_D_MINUS = 50.0

        ' Check from the minimum limit from the range
        If grade >= LETTER_A_PLUS Then
            letterGrade = "A+"
        ElseIf grade >= LETTER_A Then
            letterGrade = "A"
        ElseIf grade >= LETTER_A_MINUS Then
            letterGrade = "A-"
        ElseIf grade >= LETTER_B_PLUS Then
            letterGrade = "B+"
        ElseIf grade >= LETTER_B Then
            letterGrade = "B"
        ElseIf grade >= LETTER_B_MINUS Then
            letterGrade = "B-"
        ElseIf grade >= LETTER_C_PLUS Then
            letterGrade = "C+"
        ElseIf grade >= LETTER_C Then
            letterGrade = "C"
        ElseIf grade >= LETTER_C_MINUS Then
            letterGrade = "C-"
        ElseIf grade >= LETTER_D_PLUS Then
            letterGrade = "D+"
        ElseIf grade >= LETTER_D Then
            letterGrade = "D"
        ElseIf grade >= LETTER_D_MINUS Then
            letterGrade = "D-"
        Else
            letterGrade = "F"
        End If

    End Sub

    ''' <summary>
    ''' This button validate all textboxes, to be sure that all of then is valid.
    ''' Then it calculates the average of the grades, and 
    ''' display the letter of the average.
    ''' If there is an error, a message is displayed in the Message Label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click

        ' DECLARATIONS
        Const NUMBER_OF_COURSES = 6
        Const ERROR_PESSAGE_PART_1 = "Please ensure that what you input in "    ' First part of the error message

        Dim inputGrade As String = String.Empty
        Dim isValid As Boolean = False
        Dim errorMessagePart2 As String = String.Empty ' Second part of the error message
        Dim inputGradeDouble As Double = 0.0
        Dim errorMessage As String = String.Empty

        Dim inputTotal As Double = 0.0
        Dim averageGrade As Double = 0.0
        Dim averageLetter As String = String.Empty

        Dim errorMessageArray() As String
        Dim errorArrayCounter As Integer = 0


        ' PROCESS

        errorMessageArray = New String(NUMBER_OF_COURSES - 1) {}

        ' First the system check all controls and find the textboxes validating its text
        For Each controlInForm As Control In Me.Controls

            ' Validate the value only the Control is a textbox
            If TypeOf controlInForm Is TextBox Then
                inputGrade = controlInForm.Text
                ValidateGrade(inputGrade, errorMessagePart2, isValid)

                If isValid Then
                    inputTotal += Convert.ToDouble(inputGrade) ' If valid, add the value to the total
                Else
                    ' Add the message of the error in a array, so it can be displayed latter
                    errorMessageArray(errorArrayCounter) = ERROR_PESSAGE_PART_1 + GetNextControl(controlInForm, False).Text + errorMessagePart2
                    errorArrayCounter += 1
                End If

            End If
        Next

        ' If there is a error message, then display it and do not calculate the average
        If errorArrayCounter > 0 Then
            errorMessage = "ERROR(S):" + vbNewLine
            ' The message is save in the back order, so the first index has the error of the last control
            For errorCounter As Integer = (errorArrayCounter - 1) To 0 Step -1
                errorMessage += errorMessageArray(errorCounter) + vbNewLine
            Next errorCounter
            lbMessage.Text = errorMessage

        Else ' If all courses are valid, calculate the average with letter and display them
            CalculateAverage(inputTotal, averageGrade, NUMBER_OF_COURSES)
            lbSemesterAverage.Text = averageGrade.ToString("n2")

            DetermineLetterGrade(averageGrade, averageLetter)
            lbSemesterLetter.Text = averageLetter
        End If

    End Sub

    ''' <summary>
    ''' Calculates the average
    ''' </summary>
    ''' <param name="inputTotal"></param>
    ''' <param name="average"></param>
    ''' <param name="NUMBER_OF_COURSES"></param>
    Private Sub CalculateAverage(inputTotal As Double, ByRef average As Double, NUMBER_OF_COURSES As Integer)

        average = inputTotal / NUMBER_OF_COURSES

    End Sub
End Class
