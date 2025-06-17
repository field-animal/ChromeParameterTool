<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        isPROD = New CheckBox()
        isKiosk = New CheckBox()
        Panel1 = New Panel()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(78, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(690, 150)
        Button1.TabIndex = 0
        Button1.Text = "세소정 실행"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' isPROD
        ' 
        isPROD.Checked = True
        isPROD.CheckState = CheckState.Checked
        isPROD.FlatStyle = FlatStyle.System
        isPROD.Font = New Font("맑은 고딕", 12F)
        isPROD.Location = New Point(186, 291)
        isPROD.Name = "isPROD"
        isPROD.Size = New Size(474, 44)
        isPROD.TabIndex = 1
        isPROD.Text = "상용 키오스를 실행합니다."
        isPROD.UseVisualStyleBackColor = True
        ' 
        ' isKiosk
        ' 
        isKiosk.Checked = True
        isKiosk.CheckState = CheckState.Checked
        isKiosk.FlatStyle = FlatStyle.System
        isKiosk.Font = New Font("맑은 고딕", 12F)
        isKiosk.Location = New Point(186, 379)
        isKiosk.Name = "isKiosk"
        isKiosk.Size = New Size(474, 44)
        isKiosk.TabIndex = 2
        isKiosk.Text = "전체화면(키오스크 모드) 실행합니다."
        isKiosk.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Location = New Point(186, 503)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(457, 485)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(189, 475)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 25)
        Label1.TabIndex = 4
        Label1.Text = "카카오톡 계좌 후원"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(843, 1024)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(isKiosk)
        Controls.Add(isPROD)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "세소정 런쳐"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents isPROD As CheckBox
    Friend WithEvents isKiosk As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label

End Class
