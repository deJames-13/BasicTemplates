Public Class HomePage
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MakeHandlers()

    End Sub

    Private Sub MakeHandlers()
        '
        ' Button Events
        '
        AddHandler btnDebug.Click, AddressOf debuggerFunc


    End Sub


End Class
