Public Class Form1

    Private TimerTS As TimeSpan

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        TimerTS = New TimeSpan(0)
        MyTimer.Enabled = False
        MyTimer.Interval = 1000

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        If Not MyTimer.Enabled Then

            ' Obteniendo tiempo de tarea
            Dim Horas As Integer = CInt(txtHoras.Text)
            Dim Minutos As Integer = CInt(txtMinutos.Text)
            Dim Segundos As Integer = CInt(txtSegundos.Text)

            ' Creando objeto TimeSpan
            TimerTS = New TimeSpan(Horas, Minutos, Segundos)

            ' Iniciando MyTimer
            MyTimer.Start()

            ' Cambiando etiqueta de boton Iniciar
            btnIniciar.Text = "Detener"

        Else
            MyTimer.Stop()
            txtHoras.Text = "00"
            txtMinutos.Text = "00"
            txtSegundos.Text = "00"
            btnIniciar.Text = "Iniciar"
        End If

    End Sub

    Private Sub MyTimer_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick

        If TimerTS.Ticks > 0 Then
            TimerTS = TimerTS.Subtract(New TimeSpan((10000000)))
            txtHoras.Text = TimerTS.Hours.ToString("00")
            txtMinutos.Text = TimerTS.Minutes.ToString("00")
            txtSegundos.Text = TimerTS.Seconds.ToString("00")
        Else
            MyTimer.Stop()
            txtHoras.Text = "00"
            txtMinutos.Text = "00"
            txtSegundos.Text = "00"
            btnIniciar.Text = "Iniciar"
            MsgBox("¡Tiempo de tarea agotado!")
        End If

    End Sub
End Class
