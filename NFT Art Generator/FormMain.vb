Imports System.Drawing.Imaging
Imports System.IO


Public Class FormMain

    Dim heldDownItem As ListViewItem
    Dim heldDownPoint As Point
    Dim ServiceGen As GenService = New GenService()
    Dim NFTService As NFTService = New NFTService()

    Public Sub New()
        InitializeComponent()
        txtOutputImages.Text = Application.StartupPath
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I As New FolderBrowserDialog With {
              .ShowNewFolderButton = True,
              .RootFolder = Environment.SpecialFolder.Desktop,
              .Description = "Images"
            }
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLayers.Text = I.SelectedPath
            Dim directories = Directory.GetDirectories(I.SelectedPath)
            Lv1.Items.Clear()
            For Each folderName In directories
                Dim itm As New ListViewItem
                itm.SubItems.Add(Path.GetFileName(folderName))
                itm.SubItems.Add(Directory.GetFiles(folderName).Length)
                itm.Tag = folderName
                itm.ImageIndex = 0
                Lv1.Items.Add(itm)
            Next

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim I As New FolderBrowserDialog With {
            .ShowNewFolderButton = True,
            .RootFolder = Environment.SpecialFolder.Desktop,
            .Description = "Images"
            }
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtOutputImages.Text = I.SelectedPath
        End If
    End Sub

    Private Sub Lv1_MouseDown(sender As Object, e As MouseEventArgs) Handles Lv1.MouseDown
        heldDownItem = Lv1.GetItemAt(e.X, e.Y)
        If heldDownItem IsNot Nothing Then
            heldDownPoint = New Point(e.X - heldDownItem.Position.X, e.Y - heldDownItem.Position.Y)
        End If
    End Sub

    Private Sub Lv1_MouseMove(sender As Object, e As MouseEventArgs) Handles Lv1.MouseMove
        If heldDownItem Is Nothing Then Return
        Cursor = Cursors.Hand
        Dim lastItemBottom As Integer = Math.Min(e.Y, Lv1.Items(Lv1.Items.Count - 1).GetBounds(ItemBoundsPortion.Entire).Bottom - 1)
        Dim itemOver As ListViewItem = Lv1.GetItemAt(0, lastItemBottom)
        If itemOver Is Nothing Then Return
        Dim rc As Rectangle = itemOver.GetBounds(ItemBoundsPortion.Entire)

        If e.Y < rc.Top + (rc.Height / 2) Then
            Lv1.LineBefore = itemOver.Index
            Lv1.LineAfter = -1
        Else
            Lv1.LineBefore = -1
            Lv1.LineAfter = itemOver.Index
        End If
        Lv1.Invalidate()
    End Sub

    Private Sub Lv1_MouseUp(sender As Object, e As MouseEventArgs) Handles Lv1.MouseUp
        If heldDownItem Is Nothing Then Return

        Try
            Dim lastItemBottom As Integer = Math.Min(e.Y, Lv1.Items(Lv1.Items.Count - 1).GetBounds(ItemBoundsPortion.Entire).Bottom - 1)
            Dim itemOver As ListViewItem = Lv1.GetItemAt(0, lastItemBottom)
            If itemOver Is Nothing Then Return
            Dim rc As Rectangle = itemOver.GetBounds(ItemBoundsPortion.Entire)
            Dim insertBefore As Boolean

            If e.Y < rc.Top + (rc.Height / 2) Then
                insertBefore = True
            Else
                insertBefore = False
            End If

            If heldDownItem IsNot itemOver Then

                If insertBefore Then
                    Lv1.Items.Remove(heldDownItem)
                    Lv1.Items.Insert(itemOver.Index, heldDownItem)
                Else
                    Lv1.Items.Remove(heldDownItem)
                    Lv1.Items.Insert(itemOver.Index + 1, heldDownItem)
                End If
            End If

            Lv1.LineAfter = -1
            Lv1.LineBefore = -1

            Lv1.Invalidate()
        Finally
            heldDownItem = Nothing
            Cursor = Cursors.[Default]
        End Try
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click

        If Lv1.Items.Count <= 0 Then
            MessageBox.Show("There is no layers !", "X-SLAYER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Try
            Dim folderPaths As New List(Of String)
            For Each folder As ListViewItem In Lv1.Items
                folderPaths.Add(folder.Tag)
            Next
            Dim layers = ServiceGen.Load(folderPaths.ToArray())
            Dim imageDescriptors As List(Of NFTImage) = ServiceGen.Create(layers, nbSize.Value)
            pBar.Maximum = nbSize.Value

            If Not Directory.Exists(txtOutputImages.Text) Then
                Directory.CreateDirectory(txtOutputImages.Text)
            End If

            Dim collectionNumber As Integer = 0

            For Each item In imageDescriptors
                Dim combinedImages = NFTService.Combine(item.Files.ToArray())
                Dim filename = $"{If(txtPrefix.Text Is Nothing, "SLAYER_", txtPrefix.Text)}{collectionNumber}.png"
                combinedImages.Save($"{txtOutputImages.Text}{Path.DirectorySeparatorChar}{filename}", ImageFormat.Png)
                combinedImages?.Dispose()
                collectionNumber += 1
                pBar.Increment(1)
            Next
            If MessageBox.Show("Generating Completed ^_^" & vbCrLf & "Do You Want To open file location", "X-SLAYER", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Process.Start(txtOutputImages.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
