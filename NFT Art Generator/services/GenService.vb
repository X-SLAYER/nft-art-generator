
Imports Weighted_Randomizer

Class GenService

    Public Function Create(layers As List(Of Layer), collectionSize As Integer) As List(Of NFTImage)
        Dim images = New List(Of NFTImage)()
        Dim uniqueImagesCount = 0

        While uniqueImagesCount <> collectionSize
            Dim imageDescriptor = UniqueImage(layers)
            images.Add(imageDescriptor)
            uniqueImagesCount += 1
        End While

        Return images
    End Function

    Private Function UniqueImage(layers As List(Of Layer)) As NFTImage
        Dim files = New List(Of String)()

        For Each layer In layers
            Dim index = layer.Randomizer.NextWithReplacement()
            files.Add(layer.Elements(index).Path)
        Next

        Return New NFTImage With {
            .Files = files
        }
    End Function


    Function GetCombinations(ByVal depth As Integer, ByVal values As String()) As IEnumerable(Of String)
        If depth > values.Count + 1 Then Return New List(Of String)
        Dim result = New List(Of String)

        For i = 0 To depth - 1
            For y = 0 To values.Count - 1
                If i = 0 Then
                    result.Add(values(y))
                Else
                    result.Add(values(i - 1) + values(y))
                End If
            Next
        Next
        Return result
    End Function


    Public Function Load(paths As String()) As List(Of Layer)
        Dim layers = New List(Of Layer)()
        For i As Integer = 0 To paths.Length - 1
            Dim randomizer = New DynamicWeightedRandomizer(Of Integer)
            Dim filePaths = IO.Directory.GetFiles(paths(i))
            If filePaths.Length > 0 Then
                Dim elements = HandleElements(filePaths, randomizer)
                If (elements.Count > 0) Then
                    Dim layer = New Layer With {
                    .Id = i,
                    .Name = IO.Path.GetFileName(paths(i)),
                    .Elements = elements,
                    .Randomizer = randomizer
                }
                    layers.Add(layer)
                End If
            End If
        Next
        Return layers
    End Function


    Public Function HandleElements(filePaths As String(), randomizer As DynamicWeightedRandomizer(Of Integer)) As List(Of Element)
        Dim elements = New List(Of Element)()

        For i As Integer = 0 To filePaths.Length - 1
            Dim path = filePaths(i)
            Dim singleElement = New Element With {
                .Id = i,
                .Name = IO.Path.GetFileNameWithoutExtension(path),
                .Path = path,
                .Weight = filePaths.Length
            }
            randomizer.Add(singleElement.Id, singleElement.Weight)
            elements.Add(singleElement)
        Next
        Return elements
    End Function

End Class
