Public Class Form1

    Dim mainNum As Double
    Dim calcuNum As Double
    Dim baseNum As Double
    Dim smallDNum As Double
    Dim bigDNum As Double
    Dim remainNum As Double
    Dim Scomp As Double
    Dim Fcomp As Double
    Dim registerNum As Double
    Dim counterComp As Double
    Dim decimalNum As Integer = 0


    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus

        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.Clear()
        End If



    End Sub



    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        If IsNumeric(TextBox3.Text) = False Then
            TextBox3.Clear()


        End If

    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text <> 10 Then
            MessageBox.Show("Function not complete")
            TextBox2.Text = 10
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        If TextBox2.Text > TextBox3.Text Then

        Else
            If TextBox1.Text <= 0 Or TextBox2.Text <= 0 Or TextBox3.Text <= 1 Then
                MessageBox.Show("does not support negative number")
            Else

                mainNum = Double.Parse(TextBox1.Text)
                baseNum = Double.Parse(TextBox3.Text)
                bigDNum = Math.Truncate(mainNum)
                smallDNum = mainNum - bigDNum

                While bigDNum >= baseNum
                    calcuNum = bigDNum \ baseNum
                    remainNum = bigDNum - (baseNum * (bigDNum \ baseNum))
                    ListBox1.Items.Add(bigDNum)
                    ListBox2.Items.Add(remainNum)
                    bigDNum = calcuNum
                End While
                remainNum = calcuNum
                calcuNum = 1
                ListBox1.Items.Add(calcuNum)
                ListBox2.Items.Add(remainNum)
            End If
            Dim reveraggcalcu(ListBox1.Items.Count - 1) As Object
            Dim reveraggremain(ListBox2.Items.Count - 1) As Object
            ListBox1.Items.CopyTo(reveraggcalcu, 0)
            Array.Reverse(reveraggcalcu)
            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(reveraggcalcu)

            ListBox2.Items.CopyTo(reveraggremain, 0)
            Array.Reverse(reveraggremain)
            ListBox2.Items.Clear()
            ListBox2.Items.AddRange(reveraggremain)

            ListBox1.Items.Add(".")
            ListBox2.Items.Add(".")
            If IsNumeric(decimalNum) = True And decimalNum > 0 Then

                While smallDNum <> 0
                    Math.Round(smallDNum, decimalNum)
                    calcuNum = smallDNum * baseNum
                    remainNum = Math.Truncate(calcuNum)
                    ListBox1.Items.Add(calcuNum)
                    ListBox2.Items.Add(remainNum)
                    smallDNum = calcuNum - remainNum

                End While
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.Text = 0

            If TextBox1.Text <= 0 Then
                TextBox1.Text = 0
            End If
        End If
    End Sub
    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        If IsNumeric(TextBox3.Text) = False Then
            TextBox3.Text = 0

            If TextBox3.Text <= 0 Then
                TextBox3.Text = 0
            End If
        End If
    End Sub

    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        If TextBox4.Text <> decimalNum.ToString Then
            TextBox4.Clear()

        End If
    End Sub

    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles TextBox4.LostFocus
        If IsNumeric(TextBox4.Text) = True Then
            decimalNum = Integer.Parse(TextBox4.Text)
        End If
    End Sub
End Class
