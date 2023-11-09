Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Button5.BackColor = Color.Blue
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.White
    End Sub

    Private Sub Button8_MouseHover(sender As Object, e As EventArgs) Handles Button8.MouseHover
        Button8.BackColor = Color.Orange
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Button8.BackColor = Color.White
    End Sub

    Private Sub Button12_MouseHover(sender As Object, e As EventArgs) Handles Button12.MouseHover
        Button12.BackColor = Color.Green
    End Sub

    Private Sub Button12_MouseLeave(sender As Object, e As EventArgs) Handles Button12.MouseLeave
        Button12.BackColor = Color.White
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim objConv As New TempConv.TempConvComp

        Dim c As Double

        c = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.cToF(c)

        Label8.Text = "Fahrenheit"

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim objConv As New TempConv.TempConvComp

        Dim c As Double

        c = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.cToR(c)

        Label8.Text = "Reamur"

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim objConv As New TempConv.TempConvComp

        Dim c As Double

        c = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.cToK(c)

        Label8.Text = "Kelvin"

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim objConv As New TempConv.TempConvComp

        Dim f As Double

        f = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.fToR(f)

        Label8.Text = "Reamur"

    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim objConv As New TempConv.TempConvComp

        Dim f As Double

        f = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.fToK(f)

        Label8.Text = "Kelvin"

    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim objConv As New TempConv.TempConvComp

        Dim f As Double

        f = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.fToC(f)

        Label8.Text = "Celcius"

    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim objConv As New TempConv.TempConvComp

        Dim k As Double

        k = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.kToC(k)

        Label8.Text = "Celcius"

    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim objConv As New TempConv.TempConvComp

        Dim k As Double

        k = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.kToF(k)

        Label8.Text = "Fahrenheit"

    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim objConv As New TempConv.TempConvComp

        Dim k As Double

        k = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.kToR(k)

        Label8.Text = "Reamur"

    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim objConv As New TempConv.TempConvComp

        Dim r As Double

        r = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.rToF(r)

        Label8.Text = "Fahrenheit"

    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        Dim objConv As New TempConv.TempConvComp

        Dim r As Double

        r = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.rToK(r)

        Label8.Text = "Kelvin"

    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Dim objConv As New TempConv.TempConvComp

        Dim r As Double

        r = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.rToC(r)

        Label8.Text = "Celcius"

    End Sub
End Class
