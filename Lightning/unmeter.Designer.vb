<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class unmeter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.txtunits = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnmanual = New System.Windows.Forms.Button()
        Me.btnvisa = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtamt = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.calc = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 60)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "WELCOME UNMETERED CLIENT  ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(300, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(628, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "FILL IN THE FOLLOING FORM TO CALCULATE YOUR BILL ."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(359, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Customer name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(324, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Customer Area Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(341, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 22)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Units Consumed"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(637, 158)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(154, 33)
        Me.txtname.TabIndex = 27
        '
        'txtarea
        '
        Me.txtarea.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarea.Location = New System.Drawing.Point(637, 211)
        Me.txtarea.Multiline = True
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(154, 33)
        Me.txtarea.TabIndex = 28
        '
        'txtunits
        '
        Me.txtunits.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunits.Location = New System.Drawing.Point(637, 256)
        Me.txtunits.Multiline = True
        Me.txtunits.Name = "txtunits"
        Me.txtunits.Size = New System.Drawing.Size(154, 33)
        Me.txtunits.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnmanual)
        Me.GroupBox1.Controls.Add(Me.btnvisa)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(345, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 187)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLICK ON THE MODE OF PAYMENT YOU WISH TO USE TO CALCULATE YOUR BILL:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(35, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(434, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "N.B There Is A 5% DISCOUNT For Using A Visa Card."
        '
        'btnmanual
        '
        Me.btnmanual.BackColor = System.Drawing.Color.Orchid
        Me.btnmanual.Font = New System.Drawing.Font("Modern No. 20", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmanual.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnmanual.Location = New System.Drawing.Point(272, 54)
        Me.btnmanual.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmanual.Name = "btnmanual"
        Me.btnmanual.Size = New System.Drawing.Size(153, 46)
        Me.btnmanual.TabIndex = 2
        Me.btnmanual.Text = "MANUALLY ."
        Me.btnmanual.UseVisualStyleBackColor = False
        '
        'btnvisa
        '
        Me.btnvisa.BackColor = System.Drawing.Color.Orchid
        Me.btnvisa.Font = New System.Drawing.Font("Modern No. 20", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvisa.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnvisa.Location = New System.Drawing.Point(39, 54)
        Me.btnvisa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnvisa.Name = "btnvisa"
        Me.btnvisa.Size = New System.Drawing.Size(153, 46)
        Me.btnvisa.TabIndex = 1
        Me.btnvisa.Text = "VISA CARD ."
        Me.btnvisa.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(472, 514)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 30)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Bill This Month :-"
        '
        'txtamt
        '
        Me.txtamt.Font = New System.Drawing.Font("Modern No. 20", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.ForeColor = System.Drawing.Color.Red
        Me.txtamt.Location = New System.Drawing.Point(444, 547)
        Me.txtamt.Multiline = True
        Me.txtamt.Name = "txtamt"
        Me.txtamt.ReadOnly = True
        Me.txtamt.Size = New System.Drawing.Size(292, 53)
        Me.txtamt.TabIndex = 32
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Orchid
        Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.Location = New System.Drawing.Point(28, 645)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(168, 43)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "EXIT SYSTEM."
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Orchid
        Me.btnback.Font = New System.Drawing.Font("Modern No. 20", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnback.Location = New System.Drawing.Point(252, 645)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(134, 43)
        Me.btnback.TabIndex = 34
        Me.btnback.Text = "GO BACK."
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(575, 645)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(398, 21)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Click ""PRINT RECIEPT "" To Print The Reciept ."
        '
        'calc
        '
        Me.calc.BackColor = System.Drawing.Color.Chocolate
        Me.calc.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc.Location = New System.Drawing.Point(1001, 636)
        Me.calc.Margin = New System.Windows.Forms.Padding(4)
        Me.calc.Name = "calc"
        Me.calc.Size = New System.Drawing.Size(207, 52)
        Me.calc.TabIndex = 36
        Me.calc.Text = "PRINT RECIEPT ."
        Me.calc.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(337, 701)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(527, 21)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Kisumu water company , determined to bring   quality in evry drop."
        '
        'unmeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1221, 731)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.calc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtamt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtunits)
        Me.Controls.Add(Me.txtarea)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "unmeter"
        Me.Text = "unmeter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents txtunits As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnmanual As System.Windows.Forms.Button
    Friend WithEvents btnvisa As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents calc As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
