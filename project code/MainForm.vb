
'Project Name:          VB Final Project "Monster Adventures"
'Project Purpose:       Play to be a monster and explore the world
'Created/revised by:    Kamaljot Singh on May 22, 2016

Option Explicit On
Option Strict On
Option Infer Off
Public Class MainForm



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Makes title transparent to the background Picture
        LBtitle.Parent = pbstartbackground
        PBintromonsterfly.Parent = pbstartbackground
        PBintroskull.Parent = pbstartbackground
        PBintroMonster.Parent = pbstartbackground
        'enables timer 1 to start fade in anaimation during load
        Timer1.Enabled = True
        Timer2.Enabled = True

        'play  background music
        My.Computer.Audio.Play(My.Resources.TombRaider, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub Btnquit_Click(sender As Object, e As EventArgs) Handles Btnquit.Click

        Me.Close()


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.1 'increment opacity by 0.1

        If Me.Opacity >= 1 Then
            Timer1.Enabled = False 'diables timer
            Me.Opacity = 1

        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LBtitle.Text = "Monster Adventures"
        LBtitle.Visible = Not (LBtitle.Visible)
    End Sub

    Private Sub Btnstart_Click(sender As Object, e As EventArgs) Handles Btnstart.Click
        Me.Hide()
        CharacterSel.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Phantum.Show()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.TwlightZone, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Lava2.Show()
    End Sub
End Class
