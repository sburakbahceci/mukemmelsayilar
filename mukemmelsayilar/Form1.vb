Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        Try
            a = TextBox1.Text
            b = TextBox2.Text
        Catch ex As Exception
            MsgBox("Lütfen sayı giriniz ")
            Exit Sub
        End Try

        For i = a To b
            If mukemmelMi(i) = True Then
                ListBox1.Items.Add(i.ToString)
            End If
        Next
    End Sub
    Public Function mukemmelMi(ByVal sayi As Integer) As Boolean

        Dim retVal As Long
        For i = 1 To sayi / 2
            If sayi Mod i = 0 Then
                retVal += i
            End If
        Next
        If retVal = sayi Then Return True
        Return False
    End Function
End Class
