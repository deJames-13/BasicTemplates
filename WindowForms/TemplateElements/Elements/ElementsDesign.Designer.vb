<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ElementsDesign
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ElementsDesign))
        Me.PageContainer = New System.Windows.Forms.Panel()
        Me.itemWrapper = New System.Windows.Forms.Panel()
        Me.itemBox = New System.Windows.Forms.Panel()
        Me.btnWrapper = New System.Windows.Forms.Panel()
        Me.quantPanel = New System.Windows.Forms.Panel()
        Me.itemQuant = New System.Windows.Forms.Label()
        Me.btnAddQuant = New System.Windows.Forms.Button()
        Me.btnSubQuant = New System.Windows.Forms.Button()
        Me.addToCart = New System.Windows.Forms.Button()
        Me.infoPanel = New System.Windows.Forms.Panel()
        Me.itemLoc = New System.Windows.Forms.Label()
        Me.itemName = New System.Windows.Forms.Label()
        Me.itemPrice = New System.Windows.Forms.Label()
        Me.imgBox = New System.Windows.Forms.PictureBox()
        Me.PageContainer.SuspendLayout()
        Me.itemWrapper.SuspendLayout()
        Me.itemBox.SuspendLayout()
        Me.btnWrapper.SuspendLayout()
        Me.quantPanel.SuspendLayout()
        Me.infoPanel.SuspendLayout()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PageContainer
        '
        Me.PageContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PageContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageContainer.Controls.Add(Me.itemWrapper)
        Me.PageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageContainer.Location = New System.Drawing.Point(5, 5)
        Me.PageContainer.Margin = New System.Windows.Forms.Padding(9)
        Me.PageContainer.Name = "PageContainer"
        Me.PageContainer.Padding = New System.Windows.Forms.Padding(4)
        Me.PageContainer.Size = New System.Drawing.Size(990, 778)
        Me.PageContainer.TabIndex = 8
        '
        'itemWrapper
        '
        Me.itemWrapper.Controls.Add(Me.itemBox)
        Me.itemWrapper.Location = New System.Drawing.Point(8, 8)
        Me.itemWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.itemWrapper.Name = "itemWrapper"
        Me.itemWrapper.Padding = New System.Windows.Forms.Padding(35, 35, 0, 0)
        Me.itemWrapper.Size = New System.Drawing.Size(235, 235)
        Me.itemWrapper.TabIndex = 2
        '
        'itemBox
        '
        Me.itemBox.BackColor = System.Drawing.Color.Transparent
        Me.itemBox.BackgroundImage = CType(resources.GetObject("itemBox.BackgroundImage"), System.Drawing.Image)
        Me.itemBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.itemBox.Controls.Add(Me.btnWrapper)
        Me.itemBox.Controls.Add(Me.infoPanel)
        Me.itemBox.Controls.Add(Me.imgBox)
        Me.itemBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemBox.Location = New System.Drawing.Point(35, 35)
        Me.itemBox.Margin = New System.Windows.Forms.Padding(0)
        Me.itemBox.Name = "itemBox"
        Me.itemBox.Padding = New System.Windows.Forms.Padding(10, 15, 10, 15)
        Me.itemBox.Size = New System.Drawing.Size(200, 200)
        Me.itemBox.TabIndex = 4
        '
        'btnWrapper
        '
        Me.btnWrapper.Controls.Add(Me.quantPanel)
        Me.btnWrapper.Controls.Add(Me.addToCart)
        Me.btnWrapper.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnWrapper.Location = New System.Drawing.Point(130, 115)
        Me.btnWrapper.Name = "btnWrapper"
        Me.btnWrapper.Size = New System.Drawing.Size(60, 70)
        Me.btnWrapper.TabIndex = 5
        '
        'quantPanel
        '
        Me.quantPanel.Controls.Add(Me.itemQuant)
        Me.quantPanel.Controls.Add(Me.btnAddQuant)
        Me.quantPanel.Controls.Add(Me.btnSubQuant)
        Me.quantPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.quantPanel.Location = New System.Drawing.Point(0, 0)
        Me.quantPanel.Name = "quantPanel"
        Me.quantPanel.Padding = New System.Windows.Forms.Padding(1, 22, 1, 3)
        Me.quantPanel.Size = New System.Drawing.Size(60, 40)
        Me.quantPanel.TabIndex = 3
        '
        'itemQuant
        '
        Me.itemQuant.BackColor = System.Drawing.Color.Transparent
        Me.itemQuant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemQuant.Font = New System.Drawing.Font("Lexend Medium", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemQuant.Location = New System.Drawing.Point(11, 22)
        Me.itemQuant.Name = "itemQuant"
        Me.itemQuant.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.itemQuant.Size = New System.Drawing.Size(38, 15)
        Me.itemQuant.TabIndex = 6
        Me.itemQuant.Text = "1"
        Me.itemQuant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddQuant
        '
        Me.btnAddQuant.BackColor = System.Drawing.Color.Transparent
        Me.btnAddQuant.BackgroundImage = CType(resources.GetObject("btnAddQuant.BackgroundImage"), System.Drawing.Image)
        Me.btnAddQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddQuant.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddQuant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAddQuant.FlatAppearance.BorderSize = 0
        Me.btnAddQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddQuant.Location = New System.Drawing.Point(49, 22)
        Me.btnAddQuant.Name = "btnAddQuant"
        Me.btnAddQuant.Size = New System.Drawing.Size(10, 15)
        Me.btnAddQuant.TabIndex = 5
        Me.btnAddQuant.UseVisualStyleBackColor = False
        '
        'btnSubQuant
        '
        Me.btnSubQuant.BackColor = System.Drawing.Color.Transparent
        Me.btnSubQuant.BackgroundImage = CType(resources.GetObject("btnSubQuant.BackgroundImage"), System.Drawing.Image)
        Me.btnSubQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSubQuant.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSubQuant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSubQuant.FlatAppearance.BorderSize = 0
        Me.btnSubQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubQuant.Location = New System.Drawing.Point(1, 22)
        Me.btnSubQuant.Name = "btnSubQuant"
        Me.btnSubQuant.Size = New System.Drawing.Size(10, 15)
        Me.btnSubQuant.TabIndex = 4
        Me.btnSubQuant.UseVisualStyleBackColor = False
        '
        'addToCart
        '
        Me.addToCart.BackgroundImage = CType(resources.GetObject("addToCart.BackgroundImage"), System.Drawing.Image)
        Me.addToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addToCart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.addToCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addToCart.Location = New System.Drawing.Point(0, 40)
        Me.addToCart.Name = "addToCart"
        Me.addToCart.Size = New System.Drawing.Size(60, 30)
        Me.addToCart.TabIndex = 2
        Me.addToCart.UseVisualStyleBackColor = True
        '
        'infoPanel
        '
        Me.infoPanel.Controls.Add(Me.itemLoc)
        Me.infoPanel.Controls.Add(Me.itemName)
        Me.infoPanel.Controls.Add(Me.itemPrice)
        Me.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infoPanel.Location = New System.Drawing.Point(10, 115)
        Me.infoPanel.Name = "infoPanel"
        Me.infoPanel.Padding = New System.Windows.Forms.Padding(2, 5, 2, 2)
        Me.infoPanel.Size = New System.Drawing.Size(180, 70)
        Me.infoPanel.TabIndex = 4
        '
        'itemLoc
        '
        Me.itemLoc.AutoSize = True
        Me.itemLoc.BackColor = System.Drawing.Color.Transparent
        Me.itemLoc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.itemLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemLoc.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemLoc.Location = New System.Drawing.Point(2, 55)
        Me.itemLoc.Name = "itemLoc"
        Me.itemLoc.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.itemLoc.Size = New System.Drawing.Size(92, 13)
        Me.itemLoc.TabIndex = 4
        Me.itemLoc.Text = "Alabama, USA"
        Me.itemLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'itemName
        '
        Me.itemName.AutoSize = True
        Me.itemName.BackColor = System.Drawing.Color.Transparent
        Me.itemName.Dock = System.Windows.Forms.DockStyle.Top
        Me.itemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemName.Location = New System.Drawing.Point(2, 30)
        Me.itemName.Name = "itemName"
        Me.itemName.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.itemName.Size = New System.Drawing.Size(62, 14)
        Me.itemName.TabIndex = 3
        Me.itemName.Text = "Earpods"
        Me.itemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'itemPrice
        '
        Me.itemPrice.AutoSize = True
        Me.itemPrice.BackColor = System.Drawing.Color.Transparent
        Me.itemPrice.Dock = System.Windows.Forms.DockStyle.Top
        Me.itemPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemPrice.Font = New System.Drawing.Font("Lexend Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemPrice.Location = New System.Drawing.Point(2, 5)
        Me.itemPrice.Name = "itemPrice"
        Me.itemPrice.Size = New System.Drawing.Size(58, 25)
        Me.itemPrice.TabIndex = 2
        Me.itemPrice.Text = "$6969"
        Me.itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgBox
        '
        Me.imgBox.BackgroundImage = CType(resources.GetObject("imgBox.BackgroundImage"), System.Drawing.Image)
        Me.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.imgBox.Location = New System.Drawing.Point(10, 15)
        Me.imgBox.Name = "imgBox"
        Me.imgBox.Size = New System.Drawing.Size(180, 100)
        Me.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBox.TabIndex = 3
        Me.imgBox.TabStop = False
        '
        'ElementsDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.PageContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ElementsDesign"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "ElementsDesign"
        Me.PageContainer.ResumeLayout(False)
        Me.itemWrapper.ResumeLayout(False)
        Me.itemBox.ResumeLayout(False)
        Me.btnWrapper.ResumeLayout(False)
        Me.quantPanel.ResumeLayout(False)
        Me.infoPanel.ResumeLayout(False)
        Me.infoPanel.PerformLayout()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub



    Friend WithEvents PageContainer As Panel
    Friend WithEvents itemWrapper As Panel
    Friend WithEvents itemBox As Panel
    Friend WithEvents btnWrapper As Panel
    Friend WithEvents quantPanel As Panel
    Friend WithEvents itemQuant As Label
    Friend WithEvents btnAddQuant As Button
    Friend WithEvents btnSubQuant As Button
    Friend WithEvents addToCart As Button
    Friend WithEvents infoPanel As Panel
    Friend WithEvents itemLoc As Label
    Friend WithEvents itemName As Label
    Friend WithEvents itemPrice As Label
    Friend WithEvents imgBox As PictureBox
End Class
