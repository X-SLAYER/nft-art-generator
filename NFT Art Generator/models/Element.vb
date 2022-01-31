Public Class Element
    Public Property Id As Integer
    Public Property Name As String
    Public Property Path As String
    Public Property Weight As Integer

    Public Overrides Function ToString() As String
        Return String.Format("Id: {0} - Name: {1} - Path: {2}", Id, Name, Path)
    End Function
End Class
