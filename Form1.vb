Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Private Declare Function ShowWindow Lib "user32" (ByVal handle As IntPtr, ByVal nCmdShow As Integer) As Integer
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        End
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label8.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent
        Label10.BackColor = Color.Transparent
        Label1.BackColor = Color.Transparent
        Label111.BackColor = Color.Transparent
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim F9 As Boolean = GetAsyncKeyState(Keys.F9)
        Dim F10 As Boolean = GetAsyncKeyState(Keys.F10)
        Dim F11 As Boolean = GetAsyncKeyState(Keys.F11)
        Dim F12 As Boolean = GetAsyncKeyState(Keys.F12)
        If F9 = True Then
            Try
                Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("OceanProject-Win64-Shipping")
                For Each p As Process In pProcess
                    p.Kill()
                Next

                Dim dProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Kanchayudha")
                For Each d As Process In pProcess
                    d.Kill()
                Next

            Catch ex As Exception

            End Try
        ElseIf F10 = True Then
            Try
                Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("OceanProject-Win64-Shipping")
                For Each p As Process In pProcess
                    p.Kill()
                Next
                Process.Start("Kanchayudha.exe")


            Catch ex As Exception

            End Try

        ElseIf F11 = True Then
            Try
                SendKeys.Send("{%}{ENTER}")
            Catch ex As Exception

            End Try

        ElseIf F12 = True Then
            Try
                Dim localByName As Process() = Process.GetProcessesByName("OceanProject-Win64-Shipping")
                For Each p As Process In localByName
                    ShowWindow(p.MainWindowHandle, 2) ' SW_MAXIMIZE
                Next
            Catch ex As Exception

            End Try


        End If
    End Sub
    Dim pm() As Process

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label111.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\01_bear_s1.wmv", "01_bear_s1.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\02_before_jump.wmv", "02_before_jump.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\03_boss.wmv", "03_boss.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\04_coming_home_prepare.wmv", "04_coming_home_prepare.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\05_elepahant_scene_wom.wmv", "05_elepahant_scene_wom.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\06_elephant_hopon.wmv", "06_elephant_hopon.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\07_elephant_crash.wmv", "07_elephant_crash.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\08_nandi_kill_campfire.wmv", "08_nandi_kill_campfire.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\09_sink_dream 2.wmv", "09_sink_dream 2.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\11_sink_dream_goda.wmv", "11_sink_dream_goda.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\12_spy_spot.wmv", "12_spy_spot.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\cave_final.wmv", "cave_final.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\cave_final_WMV V9.wmv", "cave_final_WMV V9.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\cave_final_WMV V10.wmv", "cave_final_WMV V10.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\cave_final1.wmv", "cave_final1.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\cave_meet_deega_WMV V9.wmv", "cave_meet_deega_WMV V9.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\decide_WMV V9.wmv", "decide_WMV V9.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\FINAL33 25 frame.mp4", "FINAL33 25 frame.mp4.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\Kanchayudha RevelationNEW.wmv", "Kanchayudha RevelationNEW.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\Kanchayudha RevelationNEW_WMV V9.wmv", "Kanchayudha RevelationNEW_WMV V9.wmv.bak")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\spy_s2.wmv", "spy_s2.wmv.bak")
        Catch ex As Exception




        End Try
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\01_bear_s1.wmv.bak", "01_bear_s1.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\02_before_jump.wmv.bak", "02_before_jump.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\03_boss.wmv.bak", "03_boss.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\04_coming_home_prepare.wmv.bak", "04_coming_home_prepare.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\05_elepahant_scene_wom.wmv.bak", "05_elepahant_scene_wom.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\06_elephant_hopon.wmv.bak", "06_elephant_hopon.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\07_elephant_crash.wmv.bak", "07_elephant_crash.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\08_nandi_kill_campfire.wmv.bak", "08_nandi_kill_campfire.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\09_sink_dream 2.wmv.bak", "09_sink_dream 2.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\11_sink_dream_goda.wmv.bak", "11_sink_dream_goda.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\12_spy_spot.wmv.bak", "12_spy_spot.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\cave_final.wmv.bak", "cave_final.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\cave_final_WMV V9.wmv.bak", "cave_final_WMV V9.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\cave_final_WMV V10.wmv.bak", "cave_final_WMV V10.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\cave_final1.wmv.bak", "cave_final1.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\cave_meet_deega_WMV V9.wmv.bak", "cave_meet_deega_WMV V9.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\decide_WMV V9.wmv.bak", "decide_WMV V9.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\FINAL33 25 frame.mp4.bak", "FINAL33 25 frame.mp4")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\Kanchayudha RevelationNEW.wmv.bak", "Kanchayudha RevelationNEW.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\Kanchayudha RevelationNEW_WMV V9.wmv.bak", "Kanchayudha RevelationNEW_WMV V9.wmv")
            My.Computer.FileSystem.RenameFile("kanchayudha\Content\Movies\spy_s2.wmv.bak", "spy_s2.wmv")
        Catch ex As Exception

        End Try
    End Sub
End Class