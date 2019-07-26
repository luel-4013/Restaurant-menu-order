<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lunch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lunch))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDrinks = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDessert = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnFastMealandVeg = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnOrderLunch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelLunch = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.GroupBoxFastMealandVeg = New System.Windows.Forms.GroupBox()
        Me.cbChickPiza = New System.Windows.Forms.CheckBox()
        Me.cbChickSand = New System.Windows.Forms.CheckBox()
        Me.cbChickSalad = New System.Windows.Forms.CheckBox()
        Me.cbCheeseSand = New System.Windows.Forms.CheckBox()
        Me.cbHamburger = New System.Windows.Forms.CheckBox()
        Me.cbFishSand = New System.Windows.Forms.CheckBox()
        Me.cbSalad = New System.Windows.Forms.CheckBox()
        Me.cbFries = New System.Windows.Forms.CheckBox()
        Me.GroupBoxDesserts = New System.Windows.Forms.GroupBox()
        Me.cbPanSyrp = New System.Windows.Forms.CheckBox()
        Me.cbChoMuffin = New System.Windows.Forms.CheckBox()
        Me.cbPineStick = New System.Windows.Forms.CheckBox()
        Me.cbToastedBagel = New System.Windows.Forms.CheckBox()
        Me.cbHashBrown = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBoxFastMealandVeg.SuspendLayout()
        Me.GroupBoxDesserts.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.btnDrinks)
        Me.Panel1.Controls.Add(Me.btnDessert)
        Me.Panel1.Controls.Add(Me.btnFastMealandVeg)
        Me.Panel1.Controls.Add(Me.btnOrderLunch)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(137, 295)
        Me.Panel1.TabIndex = 0
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Waiter"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0.0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 193)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(137, 27)
        Me.BunifuFlatButton2.TabIndex = 12
        Me.BunifuFlatButton2.Text = "Waiter"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Chef"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 220)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(137, 27)
        Me.BunifuFlatButton1.TabIndex = 11
        Me.BunifuFlatButton1.Text = "Chef"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnDrinks.Location = New System.Drawing.Point(0, 115)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDrinks.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnDrinks.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDrinks.selected = False
        Me.btnDrinks.Size = New System.Drawing.Size(137, 33)
        Me.btnDrinks.TabIndex = 10
        Me.btnDrinks.Text = "Drinks"
        Me.btnDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDrinks.Textcolor = System.Drawing.Color.White
        Me.btnDrinks.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDessert
        '
        Me.btnDessert.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDessert.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDessert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDessert.BorderRadius = 0
        Me.btnDessert.ButtonText = "Desserts"
        Me.btnDessert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDessert.DisabledColor = System.Drawing.Color.Gray
        Me.btnDessert.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDessert.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDessert.Iconimage = CType(resources.GetObject("btnDessert.Iconimage"), System.Drawing.Image)
        Me.btnDessert.Iconimage_right = Nothing
        Me.btnDessert.Iconimage_right_Selected = Nothing
        Me.btnDessert.Iconimage_Selected = Nothing
        Me.btnDessert.IconMarginLeft = 0
        Me.btnDessert.IconMarginRight = 0
        Me.btnDessert.IconRightVisible = True
        Me.btnDessert.IconRightZoom = 0.0R
        Me.btnDessert.IconVisible = True
        Me.btnDessert.IconZoom = 90.0R
        Me.btnDessert.IsTab = False
        Me.btnDessert.Location = New System.Drawing.Point(0, 82)
        Me.btnDessert.Name = "btnDessert"
        Me.btnDessert.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDessert.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnDessert.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDessert.selected = False
        Me.btnDessert.Size = New System.Drawing.Size(137, 33)
        Me.btnDessert.TabIndex = 9
        Me.btnDessert.Text = "Desserts"
        Me.btnDessert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDessert.Textcolor = System.Drawing.Color.White
        Me.btnDessert.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnFastMealandVeg
        '
        Me.btnFastMealandVeg.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnFastMealandVeg.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnFastMealandVeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFastMealandVeg.BorderRadius = 0
        Me.btnFastMealandVeg.ButtonText = "Fast Meal And Vegtarain"
        Me.btnFastMealandVeg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFastMealandVeg.DisabledColor = System.Drawing.Color.Gray
        Me.btnFastMealandVeg.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFastMealandVeg.Iconcolor = System.Drawing.Color.Transparent
        Me.btnFastMealandVeg.Iconimage = CType(resources.GetObject("btnFastMealandVeg.Iconimage"), System.Drawing.Image)
        Me.btnFastMealandVeg.Iconimage_right = Nothing
        Me.btnFastMealandVeg.Iconimage_right_Selected = Nothing
        Me.btnFastMealandVeg.Iconimage_Selected = Nothing
        Me.btnFastMealandVeg.IconMarginLeft = 0
        Me.btnFastMealandVeg.IconMarginRight = 0
        Me.btnFastMealandVeg.IconRightVisible = True
        Me.btnFastMealandVeg.IconRightZoom = 0.0R
        Me.btnFastMealandVeg.IconVisible = True
        Me.btnFastMealandVeg.IconZoom = 90.0R
        Me.btnFastMealandVeg.IsTab = False
        Me.btnFastMealandVeg.Location = New System.Drawing.Point(0, 49)
        Me.btnFastMealandVeg.Name = "btnFastMealandVeg"
        Me.btnFastMealandVeg.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnFastMealandVeg.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnFastMealandVeg.OnHoverTextColor = System.Drawing.Color.White
        Me.btnFastMealandVeg.selected = False
        Me.btnFastMealandVeg.Size = New System.Drawing.Size(137, 33)
        Me.btnFastMealandVeg.TabIndex = 8
        Me.btnFastMealandVeg.Text = "Fast Meal And Vegtarain"
        Me.btnFastMealandVeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFastMealandVeg.Textcolor = System.Drawing.Color.White
        Me.btnFastMealandVeg.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnOrderLunch
        '
        Me.btnOrderLunch.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderLunch.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderLunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrderLunch.BorderRadius = 0
        Me.btnOrderLunch.ButtonText = "Order"
        Me.btnOrderLunch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrderLunch.DisabledColor = System.Drawing.Color.Gray
        Me.btnOrderLunch.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOrderLunch.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOrderLunch.Iconimage = CType(resources.GetObject("btnOrderLunch.Iconimage"), System.Drawing.Image)
        Me.btnOrderLunch.Iconimage_right = Nothing
        Me.btnOrderLunch.Iconimage_right_Selected = Nothing
        Me.btnOrderLunch.Iconimage_Selected = Nothing
        Me.btnOrderLunch.IconMarginLeft = 0
        Me.btnOrderLunch.IconMarginRight = 0
        Me.btnOrderLunch.IconRightVisible = True
        Me.btnOrderLunch.IconRightZoom = 0.0R
        Me.btnOrderLunch.IconVisible = True
        Me.btnOrderLunch.IconZoom = 90.0R
        Me.btnOrderLunch.IsTab = False
        Me.btnOrderLunch.Location = New System.Drawing.Point(0, 247)
        Me.btnOrderLunch.Name = "btnOrderLunch"
        Me.btnOrderLunch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderLunch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnOrderLunch.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOrderLunch.selected = False
        Me.btnOrderLunch.Size = New System.Drawing.Size(137, 48)
        Me.btnOrderLunch.TabIndex = 7
        Me.btnOrderLunch.Text = "Order"
        Me.btnOrderLunch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrderLunch.Textcolor = System.Drawing.Color.White
        Me.btnOrderLunch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel3.Controls.Add(Me.LabelLunch)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(137, 49)
        Me.Panel3.TabIndex = 0
        '
        'LabelLunch
        '
        Me.LabelLunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLunch.Location = New System.Drawing.Point(34, 15)
        Me.LabelLunch.Name = "LabelLunch"
        Me.LabelLunch.Size = New System.Drawing.Size(100, 23)
        Me.LabelLunch.TabIndex = 0
        Me.LabelLunch.Text = "Lunch"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Olive
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblMax)
        Me.Panel2.Controls.Add(Me.lblMin)
        Me.Panel2.Controls.Add(Me.lblExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(137, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 49)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Lunch Menu"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMax.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.Location = New System.Drawing.Point(336, 0)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(25, 25)
        Me.lblMax.TabIndex = 8
        Me.lblMax.Text = "+"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(361, 0)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(20, 25)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "-"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(381, 0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(19, 18)
        Me.lblExit.TabIndex = 6
        Me.lblExit.Text = "X"
        '
        'GroupBoxFastMealandVeg
        '
        Me.GroupBoxFastMealandVeg.Controls.Add(Me.cbChickPiza)
        Me.GroupBoxFastMealandVeg.Controls.Add(Me.cbChickSand)
        Me.GroupBoxFastMealandVeg.Controls.Add(Me.cbChickSalad)
        Me.GroupBoxFastMealandVeg.Controls.Add(Me.cbCheeseSand)
        Me.GroupBoxFastMealandVeg.Controls.Add(Me.cbHamburger)
        Me.GroupBoxFastMealandVeg.Controls.Add(Me.cbFishSand)
        Me.GroupBoxFastMealandVeg.Controls.Add(Me.cbSalad)
        Me.GroupBoxFastMealandVeg.Controls.Add(Me.cbFries)
        Me.GroupBoxFastMealandVeg.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBoxFastMealandVeg.Location = New System.Drawing.Point(137, 49)
        Me.GroupBoxFastMealandVeg.Name = "GroupBoxFastMealandVeg"
        Me.GroupBoxFastMealandVeg.Size = New System.Drawing.Size(183, 246)
        Me.GroupBoxFastMealandVeg.TabIndex = 2
        Me.GroupBoxFastMealandVeg.TabStop = False
        '
        'cbChickPiza
        '
        Me.cbChickPiza.AutoSize = True
        Me.cbChickPiza.Location = New System.Drawing.Point(6, 177)
        Me.cbChickPiza.Name = "cbChickPiza"
        Me.cbChickPiza.Size = New System.Drawing.Size(93, 17)
        Me.cbChickPiza.TabIndex = 0
        Me.cbChickPiza.Text = "Chicken Pizza"
        Me.cbChickPiza.UseVisualStyleBackColor = True
        '
        'cbChickSand
        '
        Me.cbChickSand.AutoSize = True
        Me.cbChickSand.Location = New System.Drawing.Point(6, 154)
        Me.cbChickSand.Name = "cbChickSand"
        Me.cbChickSand.Size = New System.Drawing.Size(115, 17)
        Me.cbChickSand.TabIndex = 0
        Me.cbChickSand.Text = "Chicken Sandwich"
        Me.cbChickSand.UseVisualStyleBackColor = True
        '
        'cbChickSalad
        '
        Me.cbChickSalad.AutoSize = True
        Me.cbChickSalad.Location = New System.Drawing.Point(6, 88)
        Me.cbChickSalad.Name = "cbChickSalad"
        Me.cbChickSalad.Size = New System.Drawing.Size(95, 17)
        Me.cbChickSalad.TabIndex = 0
        Me.cbChickSalad.Text = "Chicken Salad"
        Me.cbChickSalad.UseVisualStyleBackColor = True
        '
        'cbCheeseSand
        '
        Me.cbCheeseSand.AutoSize = True
        Me.cbCheeseSand.Location = New System.Drawing.Point(6, 131)
        Me.cbCheeseSand.Name = "cbCheeseSand"
        Me.cbCheeseSand.Size = New System.Drawing.Size(112, 17)
        Me.cbCheeseSand.TabIndex = 0
        Me.cbCheeseSand.Text = "Cheese Sandwich"
        Me.cbCheeseSand.UseVisualStyleBackColor = True
        '
        'cbHamburger
        '
        Me.cbHamburger.AutoSize = True
        Me.cbHamburger.Location = New System.Drawing.Point(6, 65)
        Me.cbHamburger.Name = "cbHamburger"
        Me.cbHamburger.Size = New System.Drawing.Size(78, 17)
        Me.cbHamburger.TabIndex = 0
        Me.cbHamburger.Text = "Hamburger"
        Me.cbHamburger.UseVisualStyleBackColor = True
        '
        'cbFishSand
        '
        Me.cbFishSand.AutoSize = True
        Me.cbFishSand.Location = New System.Drawing.Point(6, 108)
        Me.cbFishSand.Name = "cbFishSand"
        Me.cbFishSand.Size = New System.Drawing.Size(95, 17)
        Me.cbFishSand.TabIndex = 0
        Me.cbFishSand.Text = "Fish Sandwich"
        Me.cbFishSand.UseVisualStyleBackColor = True
        '
        'cbSalad
        '
        Me.cbSalad.AutoSize = True
        Me.cbSalad.Location = New System.Drawing.Point(6, 42)
        Me.cbSalad.Name = "cbSalad"
        Me.cbSalad.Size = New System.Drawing.Size(53, 17)
        Me.cbSalad.TabIndex = 0
        Me.cbSalad.Text = "Salad"
        Me.cbSalad.UseVisualStyleBackColor = True
        '
        'cbFries
        '
        Me.cbFries.AutoSize = True
        Me.cbFries.Location = New System.Drawing.Point(6, 19)
        Me.cbFries.Name = "cbFries"
        Me.cbFries.Size = New System.Drawing.Size(48, 17)
        Me.cbFries.TabIndex = 0
        Me.cbFries.Text = "Fries"
        Me.cbFries.UseVisualStyleBackColor = True
        '
        'GroupBoxDesserts
        '
        Me.GroupBoxDesserts.Controls.Add(Me.cbPanSyrp)
        Me.GroupBoxDesserts.Controls.Add(Me.cbChoMuffin)
        Me.GroupBoxDesserts.Controls.Add(Me.cbPineStick)
        Me.GroupBoxDesserts.Controls.Add(Me.cbToastedBagel)
        Me.GroupBoxDesserts.Controls.Add(Me.cbHashBrown)
        Me.GroupBoxDesserts.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBoxDesserts.Location = New System.Drawing.Point(326, 49)
        Me.GroupBoxDesserts.Name = "GroupBoxDesserts"
        Me.GroupBoxDesserts.Size = New System.Drawing.Size(211, 246)
        Me.GroupBoxDesserts.TabIndex = 3
        Me.GroupBoxDesserts.TabStop = False
        '
        'cbPanSyrp
        '
        Me.cbPanSyrp.AutoSize = True
        Me.cbPanSyrp.Location = New System.Drawing.Point(23, 108)
        Me.cbPanSyrp.Name = "cbPanSyrp"
        Me.cbPanSyrp.Size = New System.Drawing.Size(113, 17)
        Me.cbPanSyrp.TabIndex = 0
        Me.cbPanSyrp.Text = "Pancakes  - Syrup"
        Me.cbPanSyrp.UseVisualStyleBackColor = True
        '
        'cbChoMuffin
        '
        Me.cbChoMuffin.AutoSize = True
        Me.cbChoMuffin.Location = New System.Drawing.Point(23, 85)
        Me.cbChoMuffin.Name = "cbChoMuffin"
        Me.cbChoMuffin.Size = New System.Drawing.Size(106, 17)
        Me.cbChoMuffin.TabIndex = 0
        Me.cbChoMuffin.Text = "Chocolate Muffin"
        Me.cbChoMuffin.UseVisualStyleBackColor = True
        '
        'cbPineStick
        '
        Me.cbPineStick.AutoSize = True
        Me.cbPineStick.Location = New System.Drawing.Point(23, 65)
        Me.cbPineStick.Name = "cbPineStick"
        Me.cbPineStick.Size = New System.Drawing.Size(100, 17)
        Me.cbPineStick.TabIndex = 0
        Me.cbPineStick.Text = "Pineapple Stick"
        Me.cbPineStick.UseVisualStyleBackColor = True
        '
        'cbToastedBagel
        '
        Me.cbToastedBagel.AutoSize = True
        Me.cbToastedBagel.Location = New System.Drawing.Point(23, 42)
        Me.cbToastedBagel.Name = "cbToastedBagel"
        Me.cbToastedBagel.Size = New System.Drawing.Size(95, 17)
        Me.cbToastedBagel.TabIndex = 0
        Me.cbToastedBagel.Text = "Toasted Bagel"
        Me.cbToastedBagel.UseVisualStyleBackColor = True
        '
        'cbHashBrown
        '
        Me.cbHashBrown.AutoSize = True
        Me.cbHashBrown.Location = New System.Drawing.Point(23, 19)
        Me.cbHashBrown.Name = "cbHashBrown"
        Me.cbHashBrown.Size = New System.Drawing.Size(84, 17)
        Me.cbHashBrown.TabIndex = 0
        Me.cbHashBrown.Text = "Hash Brown"
        Me.cbHashBrown.UseVisualStyleBackColor = True
        '
        'Lunch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 295)
        Me.Controls.Add(Me.GroupBoxDesserts)
        Me.Controls.Add(Me.GroupBoxFastMealandVeg)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Lunch"
        Me.Text = "Lunch"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBoxFastMealandVeg.ResumeLayout(False)
        Me.GroupBoxFastMealandVeg.PerformLayout()
        Me.GroupBoxDesserts.ResumeLayout(False)
        Me.GroupBoxDesserts.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelLunch As System.Windows.Forms.Label
    Friend WithEvents GroupBoxFastMealandVeg As System.Windows.Forms.GroupBox
    Friend WithEvents cbChickPiza As System.Windows.Forms.CheckBox
    Friend WithEvents cbChickSand As System.Windows.Forms.CheckBox
    Friend WithEvents cbChickSalad As System.Windows.Forms.CheckBox
    Friend WithEvents cbCheeseSand As System.Windows.Forms.CheckBox
    Friend WithEvents cbHamburger As System.Windows.Forms.CheckBox
    Friend WithEvents cbFishSand As System.Windows.Forms.CheckBox
    Friend WithEvents cbSalad As System.Windows.Forms.CheckBox
    Friend WithEvents cbFries As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxDesserts As System.Windows.Forms.GroupBox
    Friend WithEvents cbPanSyrp As System.Windows.Forms.CheckBox
    Friend WithEvents cbChoMuffin As System.Windows.Forms.CheckBox
    Friend WithEvents cbPineStick As System.Windows.Forms.CheckBox
    Friend WithEvents cbToastedBagel As System.Windows.Forms.CheckBox
    Friend WithEvents cbHashBrown As System.Windows.Forms.CheckBox
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOrderLunch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDrinks As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDessert As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnFastMealandVeg As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
