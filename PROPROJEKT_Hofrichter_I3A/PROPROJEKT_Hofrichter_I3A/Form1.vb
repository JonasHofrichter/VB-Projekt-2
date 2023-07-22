Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ctrl As Control
        For Each ctrl In Me.Controls

            If (ctrl.GetType() Is GetType(CheckBox)) Then
                Dim chbx As CheckBox = CType(ctrl, CheckBox)
                chbx.Checked = False
            End If

            If (ctrl.GetType() Is GetType(RadioButton)) Then
                Dim rdb As RadioButton = CType(ctrl, RadioButton)
                rdb.Checked = False
            End If

            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.BackColor = Color.LightYellow
                txt.Clear()
            End If

        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim body As Byte
        Dim uspesnost As Byte
        Try
            If RadioButton2.Checked = True Then
                If RadioButton1.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then
                    body = body + 1
                End If
            End If

            If RadioButton7.Checked = True Then
                If RadioButton8.Checked = False And RadioButton5.Checked = False And RadioButton6.Checked = False Then
                    body = body + 1
                End If
            End If

            If RadioButton12.Checked = True Then
                If RadioButton9.Checked = False And RadioButton10.Checked = False And RadioButton11.Checked = False Then
                    body = body + 1
                End If
            End If

            If RadioButton15.Checked = True Then
                If RadioButton13.Checked = False And RadioButton14.Checked = False And RadioButton16.Checked = False Then
                    body = body + 1
                End If
            End If

            If CheckBox2.Checked = True And CheckBox3.Checked = True Then
                If CheckBox1.Checked = False And CheckBox4.Checked = False Then
                    body = body + 1
                End If
            End If

            If CheckBox7.Checked = True And CheckBox5.Checked = True Then
                If CheckBox8.Checked = False And CheckBox6.Checked = False Then
                    body = body + 1
                End If
            End If

            If CheckBox12.Checked = True And CheckBox10.Checked = True Then
                If CheckBox9.Checked = False And CheckBox11.Checked = False Then
                    body = body + 1
                End If
            End If

            If CheckBox15.Checked = True And CheckBox16.Checked = True Then
                If CheckBox13.Checked = False And CheckBox14.Checked = False Then
                    body = body + 1
                End If
            End If

            uspesnost = body * 12.5
            If uspesnost < 50 Then
                TextBox1.Text = "Počet bodů je = " & body & "/8 máte tedy " & uspesnost & "% úspěšnosti. Neprospěl jste."
            End If
            If uspesnost >= 50 And uspesnost <= 70 Then
                TextBox1.Text = "Počet bodů je = " & body & "/8 máte tedy " & uspesnost & "% úspěšnosti. Prospěl jste."
            End If
            If uspesnost > 70 Then
                TextBox1.Text = "Počet bodů je = " & body & "/8 máte tedy " & uspesnost & "% úspěšnosti. Prospěl jste výborně."
            End If
        Catch ex As FormatException
            TextBox1.Text = "Chyba datového typu!"
        Catch ex As OverflowException
            TextBox1.Text = "Chyba přetečení!"
        Catch ex As Exception
            TextBox1.Text = "Chyba!"
        End Try 'myslím si že try tu není potřeba vzhledem k tomu že nezadáváme hodnoty, ale pro jistotu ho tu mám'
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RadioButton2.BackColor = Color.LightGreen
        RadioButton7.BackColor = Color.LightGreen
        RadioButton12.BackColor = Color.LightGreen
        RadioButton15.BackColor = Color.LightGreen
        CheckBox2.BackColor = Color.LightGreen
        CheckBox3.BackColor = Color.LightGreen
        CheckBox7.BackColor = Color.LightGreen
        CheckBox5.BackColor = Color.LightGreen
        CheckBox12.BackColor = Color.LightGreen
        CheckBox10.BackColor = Color.LightGreen
        CheckBox15.BackColor = Color.LightGreen
        CheckBox16.BackColor = Color.LightGreen
        TextBox1.Text = "Byly zobrazeny správné odpovědi. Už nemůžete vyhodnotit."
        Button1.Enabled = False
    End Sub
End Class
