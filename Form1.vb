Imports System.Text

Public Class Form1

    Dim arr_profile(3, 0) As String

    Dim int_row As Integer

    Dim str_name As String
    Dim str_age As String
    Dim str_occupation As String

    Dim int_age As Integer

    Private Sub btn_saveData_Click(sender As Object, e As EventArgs) Handles btn_saveData.Click

        str_name = txtb_name.Text
        str_age = txtb_age.Text
        str_occupation = txtb_occupation.Text

        Dim bool_inputsCheck As Boolean

        'Dim str_output As New StringBuilder()
        Dim str_output As String

        If String.IsNullOrEmpty(str_name) Or String.IsNullOrWhiteSpace(str_name) Or
           String.IsNullOrEmpty(str_age) Or String.IsNullOrWhiteSpace(str_age) Or
           String.IsNullOrEmpty(str_occupation) Or String.IsNullOrWhiteSpace(str_occupation) Then
            MessageBox.Show("Please Complete the Form.")
        ElseIf Not IsNumeric(str_age) Then
            MessageBox.Show("Please Input a Valid Number")
        ElseIf IsNumeric(str_age) Then
            int_age = str_age
            If int_age > 0 Then
                bool_inputsCheck = True
            Else
                MessageBox.Show("Please Input a VALID AGE")
            End If
        Else
            bool_inputsCheck = True
        End If


        If bool_inputsCheck = True Then

            If int_row = 0 Then
                int_row += 1
                ReDim arr_profile(2, int_row)
            Else
                int_row += 1
                ReDim Preserve arr_profile(2, int_row)
            End If

            arr_profile(0, int_row - 1) = str_name
            arr_profile(1, int_row - 1) = str_age
            arr_profile(2, int_row - 1) = str_occupation

            txtb_name.Clear()
            txtb_age.Clear()
            txtb_occupation.Clear()

            MessageBox.Show(int_row & " Data Saved! ")

            For i = 0 To int_row - 1 Step 1

                For j = 0 To 2 Step 1
                    'str_output.Append(arr_profile(j, i) & vbNewLine)
                    str_output = str_output & arr_profile(j, i) & vbNewLine
                Next

                'MessageBox.Show(str_output.ToString)
                MessageBox.Show(str_output)
                str_output = ""
            Next
        End If
    End Sub
End Class
