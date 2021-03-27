' Sorting Names:
' Purpose: This is an application to sort names in ascending or descending order.
'
'
' Program Description:
'           The program reads the data from text file locate in bin which has all the names saved in it;
'           Depending on the button we click i.e. Ascending or descending,
'           Ascending will arrange the list in an ascending order,
'           Descending will arrange the list in descending order,
'           Program also have an Exit button, which will exit the program.
'
'
' Naming convention For some Variables:
'           filename: Variable to store the file Name,
'           line: Variable to store each line in the text file,
'           no_of_line: Variable to count number of lines.
'
'-------------------------------------------------------------------------

Public Class Form1

    Dim filename As String
    Dim line(100) As String
    Dim no_of_line As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Storing file name.
        filename = "Names.txt"

    End Sub

    ' Describing the Button click method in a single private sub to make program look more professional and to make it more efficient. In this, we define all the buttons in one sub instead of multiple private subs.
    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles Finish.Click, Read_n_Text.Click, Ascending_Order.Click, Descending_Order.Click

        'Defining button as Button equal to CType.
        Dim button As Button = CType(sender, Button)

        ' Using If Conditions for buttons.
        If button.Name = "Finish" Then
            End
        End If

        ' Button Read n Text for reading the text file
        '       Counts the number of line,
        '       Print the text in list box,
        '       Stores the text in array (call 'line') line by line.
        If button.Name = "Read_n_Text" Then

            Dim fileHandle As System.IO.StreamReader

            'Variable to save the read line temperorily.
            Dim lineoftext As String

            Dim n As Int16
            fileHandle = My.Computer.FileSystem.OpenTextFileReader(filename)

            ' Assigning -1 to end_of_file(EOF)
            Dim EOF As Int16 = -1

            Do While (fileHandle.Peek <> EOF)

                lineoftext = fileHandle.ReadLine
                File.Items.Add(lineoftext)

                'Storing the text data in a array string.
                line(no_of_line) = lineoftext

                'counting number of lines.
                no_of_line += 1

            Loop
            n = no_of_line
            n = n - 9

        End If

        ' Button Ascending to arrange the data in Ascending order
        '       Sorts the array in ascending order,
        '       Prints the sorted array in a list box.
        If button.Name = "Ascending_Order" Then

            ' To clear the list box.
            Sorted.Items.Clear()

            ' Swap the line while arranging.
            Dim temp As String

            Dim flag As Boolean = True

            'while loop runs till the array 'line' is arranged
            Do While (flag)
                flag = False
                For i = 0 To no_of_line - 2
                    If line(i) >= line(i + 1) Then
                        'Swaping.
                        temp = line(i)
                        line(i) = line(i + 1)
                        line(i + 1) = temp
                        flag = True
                    End If
                Next i

            Loop

            'For loop to print the arranged elements in the list box.
            For k As Integer = 0 To no_of_line - 1
                Sorted.Items.Add(line(k))
            Next

        End If

        ' Button Descending to arrange the data in Descending order 
        '       Sorts the array in Descending order,
        '       Prints the sorted array in a list box.
        If button.Name = "Descending_Order" Then
            ' To clear the list box.
            Sorted.Items.Clear()

            ' Swap the line while arranging.
            Dim temp As String

            Dim flag As Boolean = True

            'while loop runs till the array 'line' is arranged.
            Do While (flag)
                flag = False

                'For loop.
                For i = 0 To no_of_line - 2

                    'If loop to check the order.
                    If line(i) <= line(i + 1) Then

                        'Swaping.
                        temp = line(i)
                        line(i) = line(i + 1)
                        line(i + 1) = temp
                        flag = True
                    End If
                Next i
            Loop

            'For loop to print the arranged elements in the list box.
            For k As Integer = 0 To no_of_line - 1
                Sorted.Items.Add(line(k))
            Next

        End If

    End Sub

End Class