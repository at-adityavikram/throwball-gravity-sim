Public Class Form1
    Dim Down As Boolean = False
    Dim Xi As Double, yi As Double
    Dim DeltaTConst As Double = 0.01
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Visible = False
        CalculateMotion()
    End Sub

    Private Sub CalculateMotion()
        VV.Visible = False
        VL.Visible = False
        PictureBox1.Visible = False
        Down = False
        Dim velocity As Double = Val(V.Text)
        Dim g As Double = Val(AccG.Text)
        Dim theta As Double = Val(Th.Text)
        Dim h As Double = Panel2.Height - Panel3.Location.Y
        Dim FractionalTime As Double = 0
        Dim DeltaX As Double, DeltaY As Double
        Dim dist As Double = 0
        Do While Panel3.Location.Y <= Panel2.Height - (Panel3.Height + 1) And DeltaY >= 0
            If theta = 0 Then
                DeltaX = velocity * FractionalTime
                DeltaY = 0.5 * g * (FractionalTime ^ 2)
            Else
                DeltaX = (velocity * Math.Cos(theta) * FractionalTime)
                DeltaY = Math.Abs((FractionalTime * velocity * Math.Sin(theta)) - (0.5 * g * (FractionalTime) ^ 2))
            End If
            Try
                Panel3.Location = New Point(Math.Round(DeltaX), (Panel2.Height - h) + Math.Round(DeltaY))
                ListBox1.Items.Add(FractionalTime.ToString)
                ListBox2.Items.Add(DeltaX.ToString)
                ListBox3.Items.Add(DeltaY.ToString)
            Catch ex As Exception
            End Try
            FractionalTime += DeltaTConst
            L1.Text = "X : " & Panel3.Location.X & " Y : " & ((Panel2.Height - Panel3.Location.Y) - Panel3.Height)
        Loop
        dist = Math.Sqrt((Panel3.Location.X - Xi) ^ 2 + (Panel3.Location.Y - yi) ^ 2)
    End Sub

    Private Sub ResetMotion()
        Panel3.Location = New Point(Panel2.Location.X, Panel2.Height - Panel3.Height)
        V.Text = 50
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        If Panel2.Location.X > 2 Then
            VL.Visible = False
            VV.Visible = False
        End If
        L1.Text = "X : " & Panel3.Location.X & " Y : " & ((Panel2.Height - Panel3.Location.Y) - Panel3.Height)
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If PictureBox1.Visible = False Then
            ResetMotion()
        End If
        Down = True
        Panel3.Location = New Point(Panel3.Location.X, e.Y)

        VV.Visible = True
        VL.Visible = True
        L1.Text = "X : " & Panel3.Location.X & " Y : " & ((Panel2.Height - Panel3.Location.Y) - Panel3.Height)
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If Down = True And e.Y < Panel2.Height Then
            VV.Visible = True
            VL.Visible = True
            Panel3.Location = New Point(Panel3.Location.X, e.Y)
            V.Text = e.X / 10
            VL.Text = e.X / 10 & " Unit Distance / Unit Time"
            VV.Location = New Point(Panel3.Location.X, Panel3.Location.Y + Panel3.Height / 2)
            VV.Width = e.X
            VL.Location = New Point(VV.Location.X + Panel3.Width, VV.Location.Y - VL.Height)
            L1.Text = "X : " & Panel3.Location.X & " Y : " & ((Panel2.Height - Panel3.Location.Y) - Panel3.Height)
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        Xi = 0
        yi = Panel3.Location.Y
        CalculateMotion()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ResetMotion()
        PictureBox1.Visible = True
        L1.Text = "X : " & Panel3.Location.X & " Y : " & ((Panel2.Height - Panel3.Location.Y) - Panel3.Height)
    End Sub

    Private Sub V_TextChanged(sender As Object, e As EventArgs) Handles V.TextChanged

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VL.Visible = False
        VV.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel4.Visible = False
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Select Case TrackBar1.Value
            Case 0
                DeltaTConst = 0.00001
            Case 1
                DeltaTConst = 0.0001
            Case 2
                DeltaTConst = 0.01
            Case 3
                DeltaTConst = 0.05
            Case 4
                DeltaTConst = 0.1
        End Select
    End Sub

    Private Sub Tools_Paint(sender As Object, e As PaintEventArgs) Handles Tools.Paint

    End Sub

    Private Sub XYcoord_Click(sender As Object, e As EventArgs) Handles XYcoord.Click
        Panel4.Visible = True
    End Sub
End Class
