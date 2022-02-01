
Imports Weighted_Randomizer

Class GenService

    Public Function Create(layers As List(Of Layer), collectionSize As Integer) As List(Of NFTImage)
        Dim images = New List(Of NFTImage)()
        Dim dic = New Dictionary(Of Integer, String)()
        Dim uniqueImagesCount = 0
        Dim dnaDuplicatedAttempts = 0

        While uniqueImagesCount <> collectionSize
            Dim nftImage = UniqueImage(layers)

            If Not dic.ContainsValue(nftImage.Schema) Then
                dic.Add(uniqueImagesCount, nftImage.Schema)
                images.Add(nftImage)
                uniqueImagesCount += 1
                dnaDuplicatedAttempts = 0
            Else

                If dnaDuplicatedAttempts >= 50 Then
                    Throw New Exception("We can't generate unique images with the following size." & vbCrLf & "make sure the size of the collection is consistent with the number of the layers ")
                End If

                dnaDuplicatedAttempts += 1
            End If

        End While

        Return images
    End Function

    Private Function UniqueImage(layers As List(Of Layer)) As NFTImage
        Dim files = New List(Of String)()
        Dim schema = New List(Of String)()

        For Each layer In layers
            Dim index = layer.Randomizer.NextWithReplacement()
            files.Add(layer.Elements(index).Path)
            schema.Add(index)
        Next

        Return New NFTImage With {
            .Files = files,
            .Schema = String.Join("-", schema)
        }
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
