<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrinksAndShakes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DrinksAndShakes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBeerAndWine = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnShakes = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDrinks = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnOrderDrinksAndShakes = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxShakes = New System.Windows.Forms.GroupBox()
        Me.cbChocoMilkShake = New System.Windows.Forms.CheckBox()
        Me.cbStrawShake = New System.Windows.Forms.CheckBox()
        Me.cbVanillaShake = New System.Windows.Forms.CheckBox()
        Me.cbVannillaCone = New System.Windows.Forms.CheckBox()
        Me.GroupBoxDrinks = New System.Windows.Forms.GroupBox()
        Me.cbBottelWater = New System.Windows.Forms.CheckBox()
        Me.cbOrange = New System.Windows.Forms.CheckBox()
        Me.cbCola = New System.Windows.Forms.CheckBox()
        Me.cbCoffee = New System.Windows.Forms.CheckBox()
        Me.cbTea = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBoxShakes.SuspendLayout()
        Me.GroupBoxDrinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.btnBeerAndWine)
        Me.Panel1.Controls.Add(Me.btnShakes)
        Me.Panel1.Controls.Add(Me.btnDrinks)
        Me.Panel1.Controls.Add(Me.btnOrderDrinksAndShakes)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 323)
        Me.Panel1.TabIndex = 0
        '
        'btnBeerAndWine
        '
        Me.btnBeerAndWine.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnBeerAndWine.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnBeerAndWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeerAndWine.BorderRadius = 0
        Me.btnBeerAndWine.ButtonText = "Beer And Wine"
        Me.btnBeerAndWine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBeerAndWine.DisabledColor = System.Drawing.Color.Gray
        Me.btnBeerAndWine.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBeerAndWine.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBeerAndWine.Iconimage = CType(resources.GetObject("btnBeerAndWine.Iconimage"), System.Drawing.Image)
        Me.btnBeerAndWine.Iconimage_right = Nothing
        Me.btnBeerAndWine.Iconimage_right_Selected = Nothing
        Me.btnBeerAndWine.Iconimage_Selected = Nothing
        Me.btnBeerAndWine.IconMarginLeft = 0
        Me.btnBeerAndWine.IconMarginRight = 0
        Me.btnBeerAndWine.IconRightVisible = True
        Me.btnBeerAndWine.IconRightZoom = 0.0R
        Me.btnBeerAndWine.IconVisible = True
        Me.btnBeerAndWine.IconZoom = 90.0R
        Me.btnBeerAndWine.IsTab = False
        Me.btnBeerAndWine.Location = New System.Drawing.Point(0, 134)
        Me.btnBeerAndWine.Name = "btnBeerAndWine"
        Me.btnBeerAndWine.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnBeerAndWine.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnBeerAndWine.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBeerAndWine.selected = False
        Me.btnBeerAndWine.Size = New System.Drawing.Size(178, 33)
        Me.btnBeerAndWine.TabIndex = 12
        Me.btnBeerAndWine.Text = "Beer And Wine"
        Me.btnBeerAndWine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBeerAndWine.Textcolor = System.Drawing.Color.White
        Me.btnBeerAndWine.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnShakes
        '
        Me.btnShakes.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnShakes.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnShakes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShakes.BorderRadius = 0
        Me.btnShakes.ButtonText = "Shakes"
        Me.btnShakes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShakes.DisabledColor = System.Drawing.Color.Gray
        Me.btnShakes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnShakes.Iconcolor = System.Drawing.Color.Transparent
        Me.btnShakes.Iconimage = CType(resources.GetObject("btnShakes.Iconimage"), System.Drawing.Image)
        Me.btnShakes.Iconimage_right = Nothing
        Me.btnShakes.Iconimage_right_Selected = Nothing
        Me.btnShakes.Iconimage_Selected = Nothing
        Me.btnShakes.IconMarginLeft = 0
        Me.btnShakes.IconMarginRight = 0
        Me.btnShakes.IconRightVisible = True
        Me.btnShakes.IconRightZoom = 0.0R
        Me.btnShakes.IconVisible = True
        Me.btnShakes.IconZoom = 90.0R
        Me.btnShakes.IsTab = False
        Me.btnShakes.Location = New System.Drawing.Point(0, 101)
        Me.btnShakes.Name = "btnShakes"
        Me.btnShakes.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnShakes.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnShakes.OnHoverTextColor = System.Drawing.Color.White
        Me.btnShakes.selected = False
        Me.btnShakes.Size = New System.Drawing.Size(178, 33)
        Me.btnShakes.TabIndex = 11
        Me.btnShakes.Text = "Shakes"
        Me.btnShakes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShakes.Textcolor = System.Drawing.Color.White
        Me.btnShakes.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDrinks
        '
        Me.btnDrinks.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDrinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDrinks.BorderRadius = 0
        Me.btnDrinks.ButtonText = "Drinks"
        Me.btnDrinks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDrinks.DisabledColor = System.Drawing.Color.Gray
        Me.btnDrinks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDrinks.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDrinks.Iconimage = CType(resources.GetObject("btnDrinks.Iconimage"), System.Drawing.Image)
        Me.btnDrinks.Iconimage_right = Nothing
        Me.btnDrinks.Iconimage_right_Selected = Nothing
        Me.btnDrinks.Iconimage_Selected = Nothing
        Me.btnDrinks.IconMarginLeft = 0
        Me.btnDrinks.IconMarginRight = 0
        Me.btnDrinks.IconRightVisible = True
        Me.btnDrinks.IconRightZoom = 0.0R
        Me.btnDrinks.IconVisible = True
        Me.btnDrinks.IconZoom = 90.0R
        Me.btnDrinks.IsTab = False
        Me.btnDrinks.Location = New System.Drawing.Point(0, 68)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDrinks.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnDrinks.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDrinks.selected = False
        Me.btnDrinks.Size = New System.Drawing.Size(178, 33)
        Me.btnDrinks.TabIndex = 10
        Me.btnDrinks.Text = "Drinks"
        Me.btnDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDrinks.Textcolor = System.Drawing.Color.White
        Me.btnDrinks.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnOrderDrinksAndShakes
        '
        Me.btnOrderDrinksAndShakes.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderDrinksAndShakes.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderDrinksAndShakes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrderDrinksAndShakes.BorderRadius = 0
        Me.btnOrderDrinksAndShakes.ButtonText = "Order"
        Me.btnOrderDrinksAndShakes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrderDrinksAndShakes.DisabledColor = System.Drawing.Color.Gray
        Me.btnOrderDrinksAndShakes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOrderDrinksAndShakes.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOrderDrinksAndShakes.Iconimage = CType(resources.GetObject("btnOrderDrinksAndShakes.Iconimage"), System.Drawing.Image)
        Me.btnOrderDrinksAndShakes.Iconimage_right = Nothing
        Me.btnOrderDrinksAndShakes.Iconimage_right_Selected = Nothing
        Me.btnOrderDrinksAndShakes.Iconimage_Selected = Nothing
        Me.btnOrderDrinksAndShakes.IconMarginLeft = 0
        Me.btnOrderDrinksAndShakes.IconMarginRight = 0
        Me.btnOrderDrinksAndShakes.IconRightVisible = True
        Me.btnOrderDrinksAndShakes.IconRightZoom = 0.0R
        Me.btnOrderDrinksAndShakes.IconVisible = True
        Me.btnOrderDrinksAndShakes.IconZoom = 90.0R
        Me.btnOrderDrinksAndShakes.IsTab = False
        Me.btnOrderDrinksAndShakes.Location = New System.Drawing.Point(0, 275)
        Me.btnOrderDrinksAndShakes.Name = "btnOrderDrinksAndShakes"
        Me.btnOrderDrinksAndShakes.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderDrinksAndShakes.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnOrderDrinksAndShakes.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOrderDrinksAndShakes.selected = False
        Me.btnOrderDrinksAndShakes.Size = New System.Drawing.Size(178, 48)
        Me.btnOrderDrinksAndShakes.TabIndex = 9
        Me.btnOrderDrinksAndShakes.Text = "Order"
        Me.btnOrderDrinksAndShakes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrderDrinksAndShakes.Textcolor = System.Drawing.Color.White
        Me.btnOrderDrinksAndShakes.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(178, 68)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Drinks And Shakes"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Olive
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(178, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(389, 68)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu"
        '
        'GroupBoxShakes
        '
        Me.GroupBoxShakes.Controls.Add(Me.cbChocoMilkShake)
        Me.GroupBoxShakes.Controls.Add(Me.cbStrawShake)
        Me.GroupBoxShakes.Controls.Add(Me.cbVanillaShake)
        Me.GroupBoxShakes.Controls.Add(Me.cbVannillaCone)
        Me.GroupBoxShakes.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBoxShakes.Location = New System.Drawing.Point(367, 68)
        Me.GroupBoxShakes.Name = "GroupBoxShakes"
        Me.GroupBoxShakes.Size = New System.Drawing.Size(200, 255)
        Me.GroupBoxShakes.TabIndex = 2
        Me.GroupBoxShakes.TabStop = False
        '
        'cbChocoMilkShake
        '
        Me.cbChocoMilkShake.AutoSize = True
        Me.cbChocoMilkShake.Location = New System.Drawing.Point(18, 82)
        Me.cbChocoMilkShake.Name = "cbChocoMilkShake"
        Me.cbChocoMilkShake.Size = New System.Drawing.Size(130, 17)
        Me.cbChocoMilkShake.TabIndex = 0
        Me.cbChocoMilkShake.Text = "Chocolate Milk Shake"
        Me.cbChocoMilkShake.UseVisualStyleBackColor = True
        '
        'cbStrawShake
        '
        Me.cbStrawShake.AutoSize = True
        Me.cbStrawShake.Location = New System.Drawing.Point(18, 59)
        Me.cbStrawShake.Name = "cbStrawShake"
        Me.cbStrawShake.Size = New System.Drawing.Size(110, 17)
        Me.cbStrawShake.TabIndex = 0
        Me.cbStrawShake.Text = "Strawberry Shake"
        Me.cbStrawShake.UseVisualStyleBackColor = True
        '
        'cbVanillaShake
        '
        Me.cbVanillaShake.AutoSize = True
        Me.cbVanillaShake.Location = New System.Drawing.Point(18, 37)
        Me.cbVanillaShake.Name = "cbVanillaShake"
        Me.cbVanillaShake.Size = New System.Drawing.Size(91, 17)
        Me.cbVanillaShake.TabIndex = 0
        Me.cbVanillaShake.Text = "Vanilla Shake"
        Me.cbVanillaShake.UseVisualStyleBackColor = True
        '
        'cbVannillaCone
        '
        Me.cbVannillaCone.AutoSize = True
        Me.cbVannillaCone.Location = New System.Drawing.Point(18, 13)
        Me.cbVannillaCone.Name = "cbVannillaCone"
        Me.cbVannillaCone.Size = New System.Drawing.Size(85, 17)
        Me.cbVannillaCone.TabIndex = 0
        Me.cbVannillaCone.Text = "Vanilla Cone"
        Me.cbVannillaCone.UseVisualStyleBackColor = True
        '
        'GroupBoxDrinks
        '
        Me.GroupBoxDrinks.Controls.Add(Me.cbBottelWater)
        Me.GroupBoxDrinks.Controls.Add(Me.cbOrange)
        Me.GroupBoxDrinks.Controls.Add(Me.cbCola)
        Me.GroupBoxDrinks.Controls.Add(Me.cbCoffee)
        Me.GroupBoxDrinks.Controls.Add(Me.cbTea)
        Me.GroupBoxDrinks.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBoxDrinks.Location = New System.Drawing.Point(178, 68)
        Me.GroupBoxDrinks.Name = "GroupBoxDrinks"
        Me.GroupBoxDrinks.Size = New System.Drawing.Size(192, 255)
        Me.GroupBoxDrinks.TabIndex = 3
        Me.GroupBoxDrinks.TabStop = False
        '
        'cbBottelWater
        '
        Me.cbBottelWater.AutoSize = True
        Me.cbBottelWater.Location = New System.Drawing.Point(18, 102)
        Me.cbBottelWater.Name = "cbBottelWater"
        Me.cbBottelWater.Size = New System.Drawing.Size(85, 17)
        Me.cbBottelWater.TabIndex = 0
        Me.cbBottelWater.Text = "Bottle Water"
        Me.cbBottelWater.UseVisualStyleBackColor = True
        '
        'cbOrange
        '
        Me.cbOrange.AutoSize = True
        Me.cbOrange.Location = New System.Drawing.Point(18, 82)
        Me.cbOrange.Name = "cbOrange"
        Me.cbOrange.Size = New System.Drawing.Size(61, 17)
        Me.cbOrange.TabIndex = 0
        Me.cbOrange.Text = "Orange"
        Me.cbOrange.UseVisualStyleBackColor = True
        '
        'cbCola
        '
        Me.cbCola.AutoSize = True
        Me.cbCola.Location = New System.Drawing.Point(18, 59)
        Me.cbCola.Name = "cbCola"
        Me.cbCola.Size = New System.Drawing.Size(47, 17)
        Me.cbCola.TabIndex = 0
        Me.cbCola.Text = "Cola"
        Me.cbCola.UseVisualStyleBackColor = True
        '
        'cbCoffee
        '
        Me.cbCoffee.AutoSize = True
        Me.cbCoffee.Location = New System.Drawing.Point(18, 36)
        Me.cbCoffee.Name = "cbCoffee"
        Me.cbCoffee.Size = New System.Drawing.Size(57, 17)
        Me.cbCoffee.TabIndex = 0
        Me.cbCoffee.Text = "Coffee"
        Me.cbCoffee.UseVisualStyleBackColor = True
        '
        'cbTea
        '
        Me.cbTea.AutoSize = True
        Me.cbTea.Location = New System.Drawing.Point(18, 13)
        Me.cbTea.Name = "cbTea"
        Me.cbTea.Size = New System.Drawing.Size(45, 17)
        Me.cbTea.TabIndex = 0
        Me.cbTea.Text = "Tea"
        Me.cbTea.UseVisualStyleBackColor = True
        '
        'DrinksAndShakes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 323)
        Me.Controls.Add(Me.GroupBoxShakes)
        Me.Controls.Add(Me.GroupBoxDrinks)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "DrinksAndShakes"
        Me.Text = "DrinksAndShakes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBoxShakes.ResumeLayout(False)
        Me.GroupBoxShakes.PerformLayout()
        Me.GroupBoxDrinks.ResumeLayout(False)
        Me.GroupBoxDrinks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxShakes As System.Windows.Forms.GroupBox
    Friend WithEvents cbChocoMilkShake As System.Windows.Forms.CheckBox
    Friend WithEvents cbStrawShake As System.Windows.Forms.CheckBox
    Friend WithEvents cbVanillaShake As System.Windows.Forms.CheckBox
    Friend WithEvents cbVannillaCone As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxDrinks As System.Windows.Forms.GroupBox
    Friend WithEvents cbBottelWater As System.Windows.Forms.CheckBox
    Friend WithEvents cbOrange As System.Windows.Forms.CheckBox
    Friend WithEvents cbCola As System.Windows.Forms.CheckBox
    Friend WithEvents cbCoffee As System.Windows.Forms.CheckBox
    Friend WithEvents cbTea As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOrderDrinksAndShakes As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnBeerAndWine As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnShakes As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDrinks As Bunifu.Framework.UI.BunifuFlatButton
End Class
