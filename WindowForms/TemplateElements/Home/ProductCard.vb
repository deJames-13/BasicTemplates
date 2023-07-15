

Imports System.IO
Imports System.Windows
Imports System.Reflection
Imports System.ComponentModel.ComponentResourceManager
Public Class ProductCard


    Public itemWrapper As Panel
    Private itemBox As New Panel
    Private btnWrapper As New Panel
    Private quantPanel As New Panel
    Private itemQuant As New Label
    Private btnAddQuant As New Button
    Private btnSubQuant As New Button
    Private addToCart As New Button
    Private infoPanel As New Panel
    Private itemLoc As New Label
    Private itemName As New Label
    Private itemPrice As New Label
    Private imgBox As New PictureBox

    Private resources As ComponentModel.ComponentResourceManager


    ' constructor
    Public Sub New(ByRef parent As Control, index As Integer)
        Dim pnl As New Panel
        Dim baseForm As New Form
        Dim baseAssembly As Assembly = parent.GetType.Assembly
        Dim scroll As ScrollableControl


        baseForm = parent.FindForm()
        resources = New ComponentModel.ComponentResourceManager(ElementsDesign.GetType)


        pnl = CreateCard(index)
        parent.Controls.Add(pnl)
        'parent.Controls.SetChildIndex(pnl, 0)


        scroll = baseForm.Controls.Find("itemsContainer", True)(0)
        scroll.ScrollControlIntoView(pnl)
    End Sub



    Private Function CreateCard(index As Integer) As Panel
        itemWrapper = New Panel
        '
        'itemWrapper
        '
        '
        'itemWrapper
        '
        itemWrapper.Location = New System.Drawing.Point(45, 11)
        itemWrapper.Margin = New System.Windows.Forms.Padding(0)
        itemWrapper.Padding = New System.Windows.Forms.Padding(35, 35, 0, 0)
        itemWrapper.Size = New System.Drawing.Size(235, 235)
        itemWrapper.TabIndex = 1

        '
        'itemBox
        '
        itemBox.BackColor = System.Drawing.Color.Transparent
        itemBox.Dock = System.Windows.Forms.DockStyle.Fill
        itemBox.Location = New System.Drawing.Point(0, 0)
        itemBox.Margin = New System.Windows.Forms.Padding(0)
        itemBox.Padding = New System.Windows.Forms.Padding(10, 15, 10, 15)
        itemBox.Size = New System.Drawing.Size(200, 200)
        itemBox.TabIndex = 2


        '
        'imgBox
        '

        Me.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        imgBox.Dock = System.Windows.Forms.DockStyle.Top
        imgBox.Location = New System.Drawing.Point(10, 15)
        imgBox.Size = New System.Drawing.Size(180, 100)
        imgBox.TabIndex = 3
        imgBox.TabStop = False


        '
        'infoPanel
        '
        infoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        infoPanel.Location = New System.Drawing.Point(10, 115)
        infoPanel.Padding = New System.Windows.Forms.Padding(2, 5, 2, 2)
        infoPanel.Size = New System.Drawing.Size(180, 70)
        infoPanel.TabIndex = 4

        '
        'itemLoc
        '
        itemLoc.AutoSize = True
        itemLoc.BackColor = System.Drawing.Color.Transparent
        itemLoc.Dock = System.Windows.Forms.DockStyle.Bottom
        itemLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        itemLoc.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        itemLoc.Location = New System.Drawing.Point(2, 55)
        itemLoc.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        itemLoc.Size = New System.Drawing.Size(92, 13)
        itemLoc.TabIndex = 4
        itemLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        '
        'itemName
        '
        itemName.AutoSize = True
        itemName.BackColor = System.Drawing.Color.Transparent
        itemName.Dock = System.Windows.Forms.DockStyle.Top
        itemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        itemName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        itemName.Location = New System.Drawing.Point(2, 30)
        itemName.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        itemName.Size = New System.Drawing.Size(62, 14)
        itemName.TabIndex = 3
        itemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        '
        'itemPrice
        '
        itemPrice.AutoSize = True
        itemPrice.BackColor = System.Drawing.Color.Transparent
        itemPrice.Dock = System.Windows.Forms.DockStyle.Top
        itemPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        itemPrice.Font = New System.Drawing.Font("Lexend Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        itemPrice.Location = New System.Drawing.Point(2, 5)
        itemPrice.Size = New System.Drawing.Size(58, 25)
        itemPrice.TabIndex = 2
        itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        '
        'btnWrapper
        '
        btnWrapper.Dock = System.Windows.Forms.DockStyle.Right
        btnWrapper.Location = New System.Drawing.Point(130, 115)
        btnWrapper.Size = New System.Drawing.Size(60, 70)
        btnWrapper.TabIndex = 5


        '
        'quantPanel
        '
        quantPanel.Dock = System.Windows.Forms.DockStyle.Fill
        quantPanel.Location = New System.Drawing.Point(0, 0)
        quantPanel.Padding = New System.Windows.Forms.Padding(1, 22, 1, 3)
        quantPanel.Size = New System.Drawing.Size(60, 40)
        quantPanel.TabIndex = 3


        '
        'itemQuant
        '
        itemQuant.BackColor = System.Drawing.Color.Transparent
        itemQuant.Dock = System.Windows.Forms.DockStyle.Fill
        itemQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        itemQuant.Font = New System.Drawing.Font("Lexend Medium", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        itemQuant.Location = New System.Drawing.Point(11, 22)
        itemQuant.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        itemQuant.Size = New System.Drawing.Size(38, 15)
        itemQuant.TabIndex = 6
        itemQuant.Text = "1"
        itemQuant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter


        '
        'btnAddQuant
        '
        btnAddQuant.BackColor = System.Drawing.Color.Transparent
        btnAddQuant.Dock = System.Windows.Forms.DockStyle.Right
        btnAddQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        btnAddQuant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        btnAddQuant.FlatAppearance.BorderSize = 0
        btnAddQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAddQuant.Location = New System.Drawing.Point(49, 22)
        btnAddQuant.Size = New System.Drawing.Size(10, 15)
        btnAddQuant.TabIndex = 5
        btnAddQuant.UseVisualStyleBackColor = False

        '
        'btnSubQuant
        '
        btnSubQuant.BackColor = System.Drawing.Color.Transparent
        btnSubQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        btnSubQuant.Dock = System.Windows.Forms.DockStyle.Left
        btnSubQuant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        btnSubQuant.FlatAppearance.BorderSize = 0
        btnSubQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSubQuant.Location = New System.Drawing.Point(1, 22)
        btnSubQuant.Size = New System.Drawing.Size(10, 15)
        btnSubQuant.TabIndex = 4
        btnSubQuant.UseVisualStyleBackColor = False

        '
        'addToCart
        '
        addToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        addToCart.Dock = System.Windows.Forms.DockStyle.Bottom
        addToCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        addToCart.Location = New System.Drawing.Point(0, 40)
        addToCart.Size = New System.Drawing.Size(60, 30)
        addToCart.TabIndex = 2
        addToCart.UseVisualStyleBackColor = True

        '
        ' Names
        ' 
        itemWrapper.Name = "itemWrapper_" & index
        itemBox.Name = "itemBox_" & index
        imgBox.Name = "imgBox_" & index
        infoPanel.Name = "infoPanel_" & index
        itemPrice.Name = "itemPrice_" & index
        itemName.Name = "itemName_" & index
        itemLoc.Name = "itemLoc_" & index
        btnWrapper.Name = "btnWrapper_" & index
        addToCart.Name = "addToCart_" & index
        quantPanel.Name = "quantPanel_" & index
        itemQuant.Name = "itemQuant_" & index
        btnAddQuant.Name = "btnAddQuant_" & index
        btnSubQuant.Name = "btnSubQuant_" & index

        '
        ' Images
        '
        'itemBox.BackgroundImage = CType(resources.GetObject("itemBox.BackgroundImage"), System.Drawing.Image)
        'itemBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch

        itemBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        imgBox.BackgroundImage = CType(resources.GetObject("imgBox.BackgroundImage"), System.Drawing.Image)
        addToCart.BackgroundImage = CType(resources.GetObject("addToCart.BackgroundImage"), System.Drawing.Image)
        btnSubQuant.BackgroundImage = CType(resources.GetObject("btnSubQuant.BackgroundImage"), System.Drawing.Image)
        btnAddQuant.BackgroundImage = CType(resources.GetObject("btnAddQuant.BackgroundImage"), System.Drawing.Image)


        imgBox.Image = Nothing


        '
        ' Labels
        ' 
        itemName.Text = "Earpods_" & index
        itemPrice.Text = "$6969"
        itemLoc.Text = "Alabama, USA"

        '
        ' Child Control
        '
        itemWrapper.Controls.Add(itemBox)

        itemBox.Controls.Add(btnWrapper)
        itemBox.Controls.Add(infoPanel)
        itemBox.Controls.Add(imgBox)

        infoPanel.Controls.Add(itemLoc)
        infoPanel.Controls.Add(itemName)
        infoPanel.Controls.Add(itemPrice)

        btnWrapper.Controls.Add(quantPanel)
        btnWrapper.Controls.Add(addToCart)

        quantPanel.Controls.Add(itemQuant)
        quantPanel.Controls.Add(btnAddQuant)
        quantPanel.Controls.Add(btnSubQuant)



        Return itemWrapper
    End Function





End Class
