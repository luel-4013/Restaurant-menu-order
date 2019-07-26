<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Waiter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Waiter))
        Me.btnOrderCompleted = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtFinish = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOrderCompleted
        '
        Me.btnOrderCompleted.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderCompleted.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderCompleted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrderCompleted.BorderRadius = 0
        Me.btnOrderCompleted.ButtonText = "Check For Order"
        Me.btnOrderCompleted.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrderCompleted.DisabledColor = System.Drawing.Color.Gray
        Me.btnOrderCompleted.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOrderCompleted.Iconimage = CType(resources.GetObject("btnOrderCompleted.Iconimage"), System.Drawing.Image)
        Me.btnOrderCompleted.Iconimage_right = Nothing
        Me.btnOrderCompleted.Iconimage_right_Selected = Nothing
        Me.btnOrderCompleted.Iconimage_Selected = Nothing
        Me.btnOrderCompleted.IconMarginLeft = 0
        Me.btnOrderCompleted.IconMarginRight = 0
        Me.btnOrderCompleted.IconRightVisible = True
        Me.btnOrderCompleted.IconRightZoom = 0.0R
        Me.btnOrderCompleted.IconVisible = True
        Me.btnOrderCompleted.IconZoom = 90.0R
        Me.btnOrderCompleted.IsTab = False
        Me.btnOrderCompleted.Location = New System.Drawing.Point(51, 187)
        Me.btnOrderCompleted.Name = "btnOrderCompleted"
        Me.btnOrderCompleted.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnOrderCompleted.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnOrderCompleted.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOrderCompleted.selected = False
        Me.btnOrderCompleted.Size = New System.Drawing.Size(170, 48)
        Me.btnOrderCompleted.TabIndex = 9
        Me.btnOrderCompleted.Text = "Check For Order"
        Me.btnOrderCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrderCompleted.Textcolor = System.Drawing.Color.White
        Me.btnOrderCompleted.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtFinish
        '
        Me.txtFinish.Location = New System.Drawing.Point(27, 25)
        Me.txtFinish.Multiline = True
        Me.txtFinish.Name = "txtFinish"
        Me.txtFinish.Size = New System.Drawing.Size(246, 142)
        Me.txtFinish.TabIndex = 10
        '
        'Waiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 247)
        Me.Controls.Add(Me.txtFinish)
        Me.Controls.Add(Me.btnOrderCompleted)
        Me.Name = "Waiter"
        Me.Text = "Waiter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOrderCompleted As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtFinish As System.Windows.Forms.TextBox
End Class
