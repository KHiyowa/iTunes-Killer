<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(12, 47)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(183, 73)
        Me.CancelBtn.TabIndex = 0
        Me.CancelBtn.Text = "キャンセル"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "まもなくiTunesを終了します"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 900000
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 132)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelBtn)
        Me.Name = "App"
        Me.Text = "iTunes Killer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer As Timer
End Class
