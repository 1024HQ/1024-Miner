Imports System.IO
Imports System.Net
Imports Microsoft.VisualBasic.CompilerServices


Public Class Form1
    Dim appPath As String = Application.StartupPath()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'update file

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

   

End Class
