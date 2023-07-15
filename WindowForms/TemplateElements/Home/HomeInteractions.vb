Module HomeInteractions

    Public Sub debuggerFunc(sender As Object, e As EventArgs)
        CreateNewProduct()
    End Sub

    Public Sub CreateNewProduct()
        Dim parent As Control = HomePage.itemsContainer
        Dim index As Integer = parent.Controls.Count

        Dim pnl As New ProductCard(parent, index)


    End Sub


End Module
