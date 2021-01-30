Imports System.IO
Imports System.Net
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices


Public Class Form1
    Dim appPath As String = Application.StartupPath()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'update file
        BackgroundWorker1.RunWorkerAsync()

        algo.Text = My.Settings.algo
        ip.Text = My.Settings.serverip
        port.Text = My.Settings.port
        wallet.Text = My.Settings.wallet
        pass.Text = My.Settings.pass
        x.Text = My.Settings.x



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BGPUMining.Click
        If (x.Text = "x32") Then
            File.WriteAllText("GPU-miner.bat", New String(Conversions.ToCharArrayRankOne(String.Concat(New String() {"ccminer-x32 -a " + algo.Text + " -o stratum+tcp://" + ip.Text + ":" + port.Text + " -u " + wallet.Text + " -p c=" + pass.Text}))).ToString)
            Process.Start("GPU-miner.bat")
        Else
            File.WriteAllText("GPU-miner.bat", New String(Conversions.ToCharArrayRankOne(String.Concat(New String() {"ccminer-x64 -a " + algo.Text + " -o stratum+tcp://" + ip.Text + ":" + port.Text + " -u " + wallet.Text + " -p c=" + pass.Text}))).ToString)
            Process.Start("GPU-miner.bat")
        End If

        'บันทึกการตั้งค่า
        My.Settings.algo = algo.Text
        My.Settings.serverip = ip.Text
        My.Settings.port = port.Text
        My.Settings.wallet = wallet.Text
        My.Settings.pass = pass.Text
        My.Settings.x = x.Text
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BCPUMining.Click
        File.WriteAllText("CPU-miner.bat", New String(Conversions.ToCharArrayRankOne(String.Concat(New String() {"minerd -a " + algo.Text + " -o stratum+tcp://" + ip.Text + ":" + port.Text + " -u " + wallet.Text + " -p c=" + pass.Text}))).ToString)
        Process.Start("CPU-miner.bat")

        'บันทึกการตั้งค่า
        My.Settings.algo = algo.Text
        My.Settings.serverip = ip.Text
        My.Settings.port = port.Text
        My.Settings.wallet = wallet.Text
        My.Settings.pass = pass.Text
        My.Settings.x = x.Text
        My.Settings.Save()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'paste file
        Try
            IO.File.WriteAllBytes(appPath & "\ccminer-x32.exe", My.Resources.ccminer_x32)
            IO.File.WriteAllBytes(appPath & "\ccminer-x64.exe", My.Resources.ccminer_x64)
            IO.File.WriteAllBytes(appPath & "\libcurl-4.dll", My.Resources.libcurl_4)
            IO.File.WriteAllBytes(appPath & "\libwinpthread-1.dll", My.Resources.libwinpthread_1)
            IO.File.WriteAllBytes(appPath & "\minerd.exe", My.Resources.minerd)
            IO.File.WriteAllBytes(appPath & "\msvcr120.dll", My.Resources.msvcr120)
            IO.File.WriteAllBytes(appPath & "\zlib1.dll", My.Resources.zlib1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted1(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        textstatus.Text = "Ready !!"
        textstatus.ForeColor = Color.DarkGreen
        BGPUMining.Enabled = True
        BCPUMining.Enabled = True
    End Sub
End Class
