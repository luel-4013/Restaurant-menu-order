<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Breakfast
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Breakfast))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOrderBreakfast = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxBreakfast = New System.Windows.Forms.GroupBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bcbTest = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.cbOmlete = New System.Windows.Forms.CheckBox()
        Me.cbEggWthMeat = New System.Windows.Forms.CheckBox()
        Me.cbScrmEgg = New System.Windows.Forms.CheckBox()
        Me.cbEggSand = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBoxBreakfast.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.btnOrderBreakfast)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 315)
        Me.Panel1.TabIndex = 0
        '
        'btnOrderBreakfast
        '
        Me.btnOrderBreakfast.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderBreakfast.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderBreakfast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrderBreakfast.BorderRadius = 0
        Me.btnOrderBreakfast.ButtonText = "Order"
        Me.btnOrderBreakfast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrderBreakfast.DisabledColor = System.Drawing.Color.Gray
        Me.btnOrderBreakfast.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOrderBreakfast.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOrderBreakfast.Iconimage = CType(resources.GetObject("btnOrderBreakfast.Iconimage"), System.Drawing.Image)
        Me.btnOrderBreakfast.Iconimage_right = Nothing
        Me.btnOrderBreakfast.Iconimage_right_Selected = Nothing
        Me.btnOrderBreakfast.Iconimage_Selected = Nothing
        Me.btnOrderBreakfast.IconMarginLeft = 0
        Me.btnOrderBreakfast.IconMarginRight = 0
        Me.btnOrderBreakfast.IconRightVisible = True
        Me.btnOrderBreakfast.IconRightZoom = 0.0R
        Me.btnOrderBreakfast.IconVisible = True
        Me.btnOrderBreakfast.IconZoom = 90.0R
        Me.btnOrderBreakfast.IsTab = False
        Me.btnOrderBreakfast.Location = New System.Drawing.Point(0, 267)
        Me.btnOrderBreakfast.Name = "btnOrderBreakfast"
        Me.btnOrderBreakfast.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderBreakfast.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnOrderBreakfast.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOrderBreakfast.selected = False
        Me.btnOrderBreakfast.Size = New System.Drawing.Size(145, 48)
        Me.btnOrderBreakfast.TabIndex = 6
        Me.btnOrderBreakfast.Text = "Order"
        Me.btnOrderBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrderBreakfast.Textcolor = System.Drawing.Color.White
        Me.btnOrderBreakfast.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(145, 65)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Breaskfast"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Olive
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(145, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(428, 65)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu"
        '
        'GroupBoxBreakfast
        '
        Me.GroupBoxBreakfast.Controls.Add(Me.BunifuCustomLabel1)
        Me.GroupBoxBreakfast.Controls.Add(Me.bcbTest)
        Me.GroupBoxBreakfast.Controls.Add(Me.cbOmlete)
        Me.GroupBoxBreakfast.Controls.Add(Me.cbEggWthMeat)
        Me.GroupBoxBreakfast.Controls.Add(Me.cbScrmEgg)
        Me.GroupBoxBreakfast.Controls.Add(Me.cbEggSand)
        Me.GroupBoxBreakfast.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBoxBreakfast.Location = New System.Drawing.Point(145, 65)
        Me.GroupBoxBreakfast.Name = "GroupBoxBreakfast"
        Me.GroupBoxBreakfast.Size = New System.Drawing.Size(200, 250)
        Me.GroupBoxBreakfast.TabIndex = 3
        Me.GroupBoxBreakfast.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(41, 113)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(79, 13)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Test Checkbox"
        '
        'bcbTest
        '
        Me.bcbTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.bcbTest.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.bcbTest.Checked = False
        Me.bcbTest.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bcbTest.ForeColor = System.Drawing.Color.White
        Me.bcbTest.Location = New System.Drawing.Point(22, 113)
        Me.bcbTest.Name = "bcbTest"
        Me.bcbTest.Size = New System.Drawing.Size(20, 20)
        Me.bcbTest.TabIndex = 1
        '
        'cbOmlete
        '
        Me.cbOmlete.AutoSize = True
        Me.cbOmlete.Location = New System.Drawing.Point(22, 89)
        Me.cbOmlete.Name = "cbOmlete"
        Me.cbOmlete.Size = New System.Drawing.Size(59, 17)
        Me.cbOmlete.TabIndex = 0
        Me.cbOmlete.Text = "Omelet"
        Me.cbOmlete.UseVisualStyleBackColor = True
        '
        'cbEggWthMeat
        '
        Me.cbEggWthMeat.AutoSize = True
        Me.cbEggWthMeat.Location = New System.Drawing.Point(22, 66)
        Me.cbEggWthMeat.Name = "cbEggWthMeat"
        Me.cbEggWthMeat.Size = New System.Drawing.Size(97, 17)
        Me.cbEggWthMeat.TabIndex = 0
        Me.cbEggWthMeat.Text = "Egg With Meat"
        Me.cbEggWthMeat.UseVisualStyleBackColor = True
        '
        'cbScrmEgg
        '
        Me.cbScrmEgg.AutoSize = True
        Me.cbScrmEgg.Location = New System.Drawing.Point(22, 43)
        Me.cbScrmEgg.Name = "cbScrmEgg"
        Me.cbScrmEgg.Size = New System.Drawing.Size(98, 17)
        Me.cbScrmEgg.TabIndex = 0
        Me.cbScrmEgg.Text = "Scrambled Egg"
        Me.cbScrmEgg.UseVisualStyleBackColor = True
        '
        'cbEggSand
        '
        Me.cbEggSand.AutoSize = True
        Me.cbEggSand.Location = New System.Drawing.Point(22, 20)
        Me.cbEggSand.Name = "cbEggSand"
        Me.cbEggSand.Size = New System.Drawing.Size(98, 17)
        Me.cbEggSand.TabIndex = 0
        Me.cbEggSand.Text = "Egg Sandwitch"
        Me.cbEggSand.UseVisualStyleBackColor = True
        '
        'Breakfast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(573, 315)
        Me.Controls.Add(Me.GroupBoxBreakfast)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Breakfast"
        Me.Text = "Breakfast"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBoxBreakfast.ResumeLayout(False)
        Me.GroupBoxBreakfast.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxBreakfast As System.Windows.Forms.GroupBox
    Friend WithEvents cbEggWthMeat As System.Windows.Forms.CheckBox
    Friend WithEvents cbScrmEgg As System.Windows.Forms.CheckBox
    Friend WithEvents cbEggSand As System.Windows.Forms.CheckBox
    Friend WithEvents btnOrderBreakfast As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cbOmlete As System.Windows.Forms.CheckBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bcbTest As Bunifu.Framework.UI.BunifuCheckbox
End Class
