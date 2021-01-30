<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ip = New System.Windows.Forms.TextBox()
        Me.wallet = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.algo = New System.Windows.Forms.ComboBox()
        Me.port = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BGPUMining = New System.Windows.Forms.Button()
        Me.BCPUMining = New System.Windows.Forms.Button()
        Me.x = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Algo : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Stratum IP : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Wallet Address : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password : "
        '
        'ip
        '
        Me.ip.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ip.Location = New System.Drawing.Point(176, 87)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(191, 28)
        Me.ip.TabIndex = 4
        '
        'wallet
        '
        Me.wallet.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.wallet.Location = New System.Drawing.Point(176, 121)
        Me.wallet.Name = "wallet"
        Me.wallet.Size = New System.Drawing.Size(191, 28)
        Me.wallet.TabIndex = 5
        '
        'pass
        '
        Me.pass.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pass.Location = New System.Drawing.Point(176, 155)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(191, 28)
        Me.pass.TabIndex = 6
        '
        'algo
        '
        Me.algo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.algo.FormattingEnabled = True
        Me.algo.Items.AddRange(New Object() {"scrypt", "sha256", "quark", "x13", "x11"})
        Me.algo.Location = New System.Drawing.Point(176, 51)
        Me.algo.Name = "algo"
        Me.algo.Size = New System.Drawing.Size(121, 30)
        Me.algo.TabIndex = 7
        Me.algo.Text = "scrypt"
        '
        'port
        '
        Me.port.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.port.Location = New System.Drawing.Point(434, 87)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(84, 28)
        Me.port.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(373, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PORT"
        '
        'BGPUMining
        '
        Me.BGPUMining.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BGPUMining.BackColor = System.Drawing.SystemColors.Desktop
        Me.BGPUMining.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BGPUMining.ForeColor = System.Drawing.Color.White
        Me.BGPUMining.Location = New System.Drawing.Point(176, 189)
        Me.BGPUMining.Name = "BGPUMining"
        Me.BGPUMining.Size = New System.Drawing.Size(191, 38)
        Me.BGPUMining.TabIndex = 10
        Me.BGPUMining.Text = "Nvdia GPU-Mining"
        Me.BGPUMining.UseVisualStyleBackColor = False
        '
        'BCPUMining
        '
        Me.BCPUMining.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BCPUMining.BackColor = System.Drawing.SystemColors.Desktop
        Me.BCPUMining.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCPUMining.ForeColor = System.Drawing.Color.White
        Me.BCPUMining.Location = New System.Drawing.Point(176, 233)
        Me.BCPUMining.Name = "BCPUMining"
        Me.BCPUMining.Size = New System.Drawing.Size(191, 38)
        Me.BCPUMining.TabIndex = 11
        Me.BCPUMining.Text = "CPU-Mining"
        Me.BCPUMining.UseVisualStyleBackColor = False
        '
        'x
        '
        Me.x.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.x.FormattingEnabled = True
        Me.x.Items.AddRange(New Object() {"x64", "x32"})
        Me.x.Location = New System.Drawing.Point(12, 12)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(60, 30)
        Me.x.TabIndex = 12
        Me.x.Text = "x64"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(541, 288)
        Me.Controls.Add(Me.x)
        Me.Controls.Add(Me.BCPUMining)
        Me.Controls.Add(Me.BGPUMining)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.algo)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.wallet)
        Me.Controls.Add(Me.ip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1024 Miner 1.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ip As System.Windows.Forms.TextBox
    Friend WithEvents wallet As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents algo As System.Windows.Forms.ComboBox
    Friend WithEvents port As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BGPUMining As System.Windows.Forms.Button
    Friend WithEvents BCPUMining As System.Windows.Forms.Button
    Friend WithEvents x As System.Windows.Forms.ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
