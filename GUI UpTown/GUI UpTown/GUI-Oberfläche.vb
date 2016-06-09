
Public Class Form1
    Private Zeit As Integer
    ' Public Shared Function Math.Log10(d As Double) As Double
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As MsgBoxResult = MsgBox("Wollen Sie das Programm wirklich beenden?", MsgBoxStyle.YesNo, "Beenden")
        If result <> MsgBoxResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Verflüssiger Einganspunkt wird errechnet
        Try
            Me.Label_VF_in = SetLabel(Me.Anzeige_VF_in_Enthalpie.Wert, Me.Anzeige_VF_in_Druck.Wert, Me.Label_VF_in)
        Catch ex As Exception
            Me.Label_VF_in = SetLabel(0, 0, Me.Label_VF_in)
        End Try

        'Verflüssiger Ausgangspunkt wird errechnet
        Try
            Me.Label_VF_out = SetLabel(Me.Anzeige_VF_out_Enthalpie.Wert, Me.Anzeige_VF_out_Druck.Wert, Me.Label_VF_out)
        Catch ex As Exception
            Me.Label_VF_out = SetLabel(0, 0, Me.Label_VF_out)
        End Try

        'Verdampfer Eingangspunkt wird errechnet
        Try
            Me.Label_VD_in = SetLabel(Me.Anzeige_VD_in_Enthalpie.Wert, Me.Anzeige_VD_in_Druck.Wert, Me.Label_VD_in)
        Catch ex As Exception
            Me.Label_VD_in = SetLabel(0, 0, Me.Label_VD_in)
        End Try

        'Verdampfer Ausgangspunkt wird errechnet
        Try
            Me.Label_VD_out = SetLabel(Me.Anzeige_VD_out_Enthalpie.Wert, Me.Anzeige_VD_out_Druck.Wert, Me.Label_VD_out)
        Catch ex As Exception
            Me.Label_VD_out = SetLabel(0, 0, Me.Label_VD_out)
        End Try

        'Kompressor Eingangspunkt wird errechnet
        Try
            Me.Label_KP_in = SetLabel(Me.Anzeige_KP_in_Enthalpie.Wert, Me.Anzeige_KP_in_Druck.Wert, Me.Label_KP_in)
        Catch ex As Exception
            Me.Label_KP_in = SetLabel(0, 0, Me.Label_KP_in)
        End Try

        'Kompressor Ausgangspunkt wird errechnet
        Try
            Me.Label_KP_out = SetLabel(Me.Anzeige_KP_out_Enthalpie.Wert, Me.Anzeige_KP_out_Druck.Wert, Me.Label_KP_out)
        Catch ex As Exception
            Me.Label_KP_out = SetLabel(0, 0, Me.Label_KP_out)
        End Try

        'ExpansionsVentil Eingangspunkt wird errechnet
        Try
            Me.Label_EV_in = SetLabel(Me.Anzeige_EV_in_Enthalpie.Wert, Me.Anzeige_EV_in_Druck.Wert, Me.Label_EV_in)
        Catch ex As Exception
            Me.Label_EV_in = SetLabel(0, 0, Me.Label_EV_in)
        End Try
    End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    'Dim Farbe As New Color(Color.Transparent)

    'Dim myPen As New Pen(Color.Magenta)
    '   myPen.StartCap = Drawing2D.LineCap.DiamondAnchor
    '  myPen.EndCap = Drawing2D.LineCap.ArrowAnchor
    ' myPen.Width = 2
    '    Me.PictureBox2.CreateGraphics.DrawLine(myPen, Me.Label_KP_in.Location.X, Me.Label_KP_in.Location.Y, Me.Label_KP_out.Location.X, Me.Label_KP_out.Location.Y)
    '   Me.PictureBox2.CreateGraphics.DrawLine(myPen, Me.Label_KP_out.Location.X, Me.Label_KP_out.Location.Y, Me.Label_VF_in.Location.X, Me.Label_VF_in.Location.Y)
    '  Me.PictureBox2.CreateGraphics.DrawLine(myPen, Me.Label_VF_in.Location.X, Me.Label_VF_in.Location.Y, Me.Label_VF_out.Location.X, Me.Label_VF_out.Location.Y)
    ' Me.PictureBox2.CreateGraphics.DrawLine(myPen, Me.Label_VF_out.Location.X, Me.Label_VF_out.Location.Y, Me.Label_EV_in.Location.X, Me.Label_EV_in.Location.Y)
    '   Me.PictureBox2.CreateGraphics.DrawLine(myPen, Me.Label_EV_in.Location.X, Me.Label_EV_in.Location.Y, Me.Label_VD_in.Location.X, Me.Label_VD_in.Location.Y)
    '  Me.PictureBox2.CreateGraphics.DrawLine(myPen, Me.Label_VD_in.Location.X, Me.Label_VD_in.Location.Y, Me.Label_VD_out.Location.X, Me.Label_VD_out.Location.Y)
    ' Me.PictureBox2.CreateGraphics.DrawLine(myPen, Me.Label_VD_out.Location.X, Me.Label_VD_out.Location.Y, Me.Label_KP_in.Location.X, Me.Label_KP_in.Location.Y)

    '    PictureBox2.Graphics.Clear()



    'End Sub


    Private Function SetLabel(ByVal Enthalpie As Decimal, Druck As Decimal, ByVal MyLabel As Label)
        Dim p As New System.Drawing.Point

        p.X = nullpunkt.Location.X + (Enthalpie - 140) / (500 - 140) * (h_high.Location.X - nullpunkt.Location.X)



        If 0.5 < Druck And Druck < 1 Then
            p.Y = nullpunkt.Location.Y - Math.Log10(Druck) / (Math.Log10(1) - Math.Log10(0.5)) * (nullpunkt.Location.Y - p_1bar.Location.Y)
        ElseIf 1 < Druck And Druck < 10 Then
            p.Y = p_1bar.Location.Y - Math.Log10(Druck) / (Math.Log10(10) - Math.Log10(1)) * (p_1bar.Location.Y - p_10bar.Location.Y)
        ElseIf 10 < Druck And Druck < 20 Then
            p.Y = p_10bar.Location.Y - Math.Log10(Druck) / (Math.Log10(20) - Math.Log10(10)) * (p_10bar.Location.Y - p_20bar.Location.Y)
        Else
            p.Y = nullpunkt.Location.Y
        End If

        MyLabel.Location = p

        Return MyLabel
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Timer1.Start()
        Me.Timer2.Start()
    End Sub

    Private Sub CheckboxEingabe_Kuhlen_Wert_Changed(sender As Object, e As EventArgs) Handles CheckboxEingabe_Kuhlen.Wert_Changed, GroupBox2.EnabledChanged
        GroupBox2.Enabled = CheckboxEingabe_Kuhlen.Wert
        'TabControl3.Enabled = CheckboxEingabe_Kuhlen.Wert
    End Sub
    Private Sub CheckboxEingabe_Abtauen_Wert_Changed(sender As Object, e As EventArgs) Handles CheckboxEingabe_Kuhlen.Wert_Changed, GroupBox3.EnabledChanged, CheckboxEingabe_Abtauen.Wert_Changed
        GroupBox3.Enabled = CheckboxEingabe_Abtauen.Wert
    End Sub
    Private Sub CheckboxEingabe9_Wert_Changed(sender As Object, e As EventArgs) Handles CheckboxEingabe9.Wert_Changed, DropdownEingabe1.EnabledChanged, GroupBox4.EnabledChanged
        SollWertEingabe3.Enabled = CheckboxEingabe9.Wert
        Label3.Enabled = CheckboxEingabe9.Wert
    End Sub
 
    'Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
    '    Zeit = Zeit + 1
    '    Button1.Text = Zeit
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If Timer3.Enabled = True Then
            Timer3.Stop()

        Else
            Zeit = 0
            Timer3.Interval = 1000
            Timer3.Start()

        End If
    End Sub

End Class
