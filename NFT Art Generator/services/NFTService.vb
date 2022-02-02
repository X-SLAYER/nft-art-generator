
Friend Class NFTService

    Public Function Combine(files As String()) As Bitmap
        Dim images = New List(Of Bitmap)()
        Dim baseImage As Bitmap = Nothing
        Dim imageIndex As Integer = 0
        Try
            Dim tempBitmap = New Bitmap(files(imageIndex))
            Dim width = tempBitmap.Width
            Dim height = tempBitmap.Height
            tempBitmap?.Dispose()
            baseImage = New Bitmap(width, height)

            For Each image In files
                Dim bitmap = New Bitmap(image)

                If bitmap.Width <> width OrElse bitmap.Height <> height Then
                    Throw New Exception("All images MUST have the same dimensions (width and height).")
                End If

                images.Add(bitmap)
            Next

            Dim gr = Graphics.FromImage(baseImage)

            For Each image In images
                gr.DrawImage(image, New Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, Nothing)
            Next

            Return baseImage
        Catch e As Exception
            baseImage?.Dispose()
            Throw New Exception("Error with this image: " & files(0))
        Finally
            For Each image In images
                image.Dispose()
            Next
        End Try
    End Function
End Class
