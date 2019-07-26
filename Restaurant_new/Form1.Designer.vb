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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBreakfast = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDinner = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLunch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelCatagory = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.BunifuGauge1 = New Bunifu.Framework.UI.BunifuGauge()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBreakfast)
        Me.Panel1.Controls.Add(Me.btnDinner)
        Me.Panel1.Controls.Add(Me.btnLunch)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 323)
        Me.Panel1.TabIndex = 0
        '
        'btnBreakfast
        '
        Me.btnBreakfast.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnBreakfast.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnBreakfast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBreakfast.BorderRadius = 0
        Me.btnBreakfast.ButtonText = "Breakefast"
        Me.btnBreakfast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBreakfast.DisabledColor = System.Drawing.Color.Gray
        Me.btnBreakfast.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBreakfast.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBreakfast.Iconimage = CType(resources.GetObject("btnBreakfast.Iconimage"), System.Drawing.Image)
        Me.btnBreakfast.Iconimage_right = Nothing
        Me.btnBreakfast.Iconimage_right_Selected = Nothing
        Me.btnBreakfast.Iconimage_Selected = Nothing
        Me.btnBreakfast.IconMarginLeft = 0
        Me.btnBreakfast.IconMarginRight = 0
        Me.btnBreakfast.IconRightVisible = True
        Me.btnBreakfast.IconRightZoom = 0.0R
        Me.btnBreakfast.IconVisible = True
        Me.btnBreakfast.IconZoom = 90.0R
        Me.btnBreakfast.IsTab = False
        Me.btnBreakfast.Location = New System.Drawing.Point(0, 142)
        Me.btnBreakfast.Name = "btnBreakfast"
        Me.btnBreakfast.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnBreakfast.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnBreakfast.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBreakfast.selected = False
        Me.btnBreakfast.Size = New System.Drawing.Size(160, 48)
        Me.btnBreakfast.TabIndex = 5
        Me.btnBreakfast.Text = "Breakefast"
        Me.btnBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBreakfast.Textcolor = System.Drawing.Color.White
        Me.btnBreakfast.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDinner
        '
        Me.btnDinner.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDinner.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDinner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDinner.BorderRadius = 0
        Me.btnDinner.ButtonText = "Dinner"
        Me.btnDinner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDinner.DisabledColor = System.Drawing.Color.Gray
        Me.btnDinner.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDinner.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDinner.Iconimage = CType(resources.GetObject("btnDinner.Iconimage"), System.Drawing.Image)
        Me.btnDinner.Iconimage_right = Nothing
        Me.btnDinner.Iconimage_right_Selected = Nothing
        Me.btnDinner.Iconimage_Selected = Nothing
        Me.btnDinner.IconMarginLeft = 0
        Me.btnDinner.IconMarginRight = 0
        Me.btnDinner.IconRightVisible = True
        Me.btnDinner.IconRightZoom = 0.0R
        Me.btnDinner.IconVisible = True
        Me.btnDinner.IconZoom = 90.0R
        Me.btnDinner.IsTab = False
        Me.btnDinner.Location = New System.Drawing.Point(0, 94)
        Me.btnDinner.Name = "btnDinner"
        Me.btnDinner.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDinner.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnDinner.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDinner.selected = False
        Me.btnDinner.Size = New System.Drawing.Size(160, 48)
        Me.btnDinner.TabIndex = 4
        Me.btnDinner.Text = "Dinner"
        Me.btnDinner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDinner.Textcolor = System.Drawing.Color.White
        Me.btnDinner.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnLunch
        '
        Me.btnLunch.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnLunch.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnLunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLunch.BorderRadius = 0
        Me.btnLunch.ButtonText = "Lunch"
        Me.btnLunch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLunch.DisabledColor = System.Drawing.Color.Gray
        Me.btnLunch.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLunch.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLunch.Iconimage = CType(resources.GetObject("btnLunch.Iconimage"), System.Drawing.Image)
        Me.btnLunch.Iconimage_right = Nothing
        Me.btnLunch.Iconimage_right_Selected = Nothing
        Me.btnLunch.Iconimage_Selected = Nothing
        Me.btnLunch.IconMarginLeft = 0
        Me.btnLunch.IconMarginRight = 0
        Me.btnLunch.IconRightVisible = True
        Me.btnLunch.IconRightZoom = 0.0R
        Me.btnLunch.IconVisible = True
        Me.btnLunch.IconZoom = 90.0R
        Me.btnLunch.IsTab = False
        Me.btnLunch.Location = New System.Drawing.Point(0, 46)
        Me.btnLunch.Name = "btnLunch"
        Me.btnLunch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnLunch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnLunch.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLunch.selected = False
        Me.btnLunch.Size = New System.Drawing.Size(160, 48)
        Me.btnLunch.TabIndex = 3
        Me.btnLunch.Text = "Lunch"
        Me.btnLunch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLunch.Textcolor = System.Drawing.Color.White
        Me.btnLunch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Controls.Add(Me.LabelCatagory)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 46)
        Me.Panel2.TabIndex = 1
        '
        'LabelCatagory
        '
        Me.LabelCatagory.AutoEllipsis = True
        Me.LabelCatagory.BackColor = System.Drawing.Color.SaddleBrown
        Me.LabelCatagory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCatagory.Location = New System.Drawing.Point(22, 11)
        Me.LabelCatagory.Name = "LabelCatagory"
        Me.LabelCatagory.Size = New System.Drawing.Size(135, 24)
        Me.LabelCatagory.TabIndex = 1
        Me.LabelCatagory.Text = "Select Catagory"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Olive
        Me.Panel3.Controls.Add(Me.lblMax)
        Me.Panel3.Controls.Add(Me.lblMin)
        Me.Panel3.Controls.Add(Me.lblExit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(160, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(516, 46)
        Me.Panel3.TabIndex = 2
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMax.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.Location = New System.Drawing.Point(452, 0)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(25, 25)
        Me.lblMax.TabIndex = 5
        Me.lblMax.Text = "+"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(477, 0)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(20, 25)
        Me.lblMin.TabIndex = 4
        Me.lblMin.Text = "-"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(497, 0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(19, 18)
        Me.lblExit.TabIndex = 3
        Me.lblExit.Text = "X"
        '
        'BunifuGauge1
        '
        Me.BunifuGauge1.BackgroundImage = CType(resources.GetObject("BunifuGauge1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGauge1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuGauge1.Location = New System.Drawing.Point(329, 153)
        Me.BunifuGauge1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuGauge1.Name = "BunifuGauge1"
        Me.BunifuGauge1.ProgressBgColor = System.Drawing.Color.Gray
        Me.BunifuGauge1.ProgressColor1 = System.Drawing.Color.SeaGreen
        Me.BunifuGauge1.ProgressColor2 = System.Drawing.Color.Tomato
        Me.BunifuGauge1.Size = New System.Drawing.Size(174, 117)
        Me.BunifuGauge1.Suffix = ""
        Me.BunifuGauge1.TabIndex = 3
        Me.BunifuGauge1.Thickness = 30
        Me.BunifuGauge1.Value = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 323)
        Me.Controls.Add(Me.BunifuGauge1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelCatagory As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents btnLunch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDinner As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuGauge1 As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents btnBreakfast As Bunifu.Framework.UI.BunifuFlatButton

End Class
