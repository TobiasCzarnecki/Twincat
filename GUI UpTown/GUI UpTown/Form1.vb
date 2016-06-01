
Public Class Form1

    ' Public Shared Function Math.Log10(d As Double) As Double
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As MsgBoxResult = MsgBox("Wollen Sie das Programm wirklich beenden?", MsgBoxStyle.YesNo, "Beenden")
        If result <> MsgBoxResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Try
            Me.Label_VF_out = SetLabel(Me.Anzeige_VF_out_Druck.Wert, Me.Anzeige_VF_out_Enthalpie.Wert, Me.Label_VF_out)
        Catch ex As Exception
        End Try

    End Sub



    Private Function SetLabel(ByVal Druck As Decimal, Enthalpie As Decimal, ByVal MyLabel As Label)
        Dim p As New System.Drawing.Point
     
        p.X = 264 + (Enthalpie - 140) / (500 - 140) * (1362 - 264)


        If 0.5 < Druck And Druck < 1 Then
            p.Y = CInt(735 - Math.Log10(Druck) / (Math.Log10(1) - Math.Log10(0.5)) * (735 - 633))
        End If
        If 1 < Druck And Druck < 10 Then
            p.Y = 650 - Math.Log10(Druck) / (Math.Log10(10) - Math.Log10(1)) * (650 - 314)
        End If
        If 10 < Druck And Druck < 20 Then
            p.Y = 307 - Math.Log10(Druck) / (Math.Log10(20) - Math.Log10(10)) * (307 - 205)
        End If

        MyLabel.Location = p

        Return MyLabel
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Timer1.Start()

    End Sub

    Protected Overridable Sub Paint(e As PaintEventArgs)
        ' Call the base class
        MyBase.OnPaint(e)

        ' Do your painting
        e.Graphics.DrawLine(Pens.Azure, 10, 10, 20, 20)
    End Sub
End Class
