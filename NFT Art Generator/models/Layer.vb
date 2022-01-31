Imports Weighted_Randomizer

Public Class Layer
    Public Property Id As Integer
    Public Property Name As String
    Public Property Elements As List(Of Element)

    Public Property Randomizer As IWeightedRandomizer(Of Integer)

    Public Overrides Function ToString() As String
        Return String.Format("{0} - {1} - {2}", Id, Name, Elements)
    End Function
End Class
