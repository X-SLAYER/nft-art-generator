Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace ListViewCustomReorder
    Public Class ListViewEx
        Inherits ListView

        Private Const WM_PAINT As Integer = &HF

        Public Sub New()
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        End Sub

        Private _LineBefore As Integer = -1

        Public Property LineBefore As Integer
            Get
                Return _LineBefore
            End Get
            Set(ByVal value As Integer)
                _LineBefore = value
            End Set
        End Property

        Private _LineAfter As Integer = -1

        Public Property LineAfter As Integer
            Get
                Return _LineAfter
            End Get
            Set(ByVal value As Integer)
                _LineAfter = value
            End Set
        End Property

        Protected Overrides Sub WndProc(ByRef m As Message)
            MyBase.WndProc(m)

            If m.Msg = WM_PAINT Then

                If LineBefore >= 0 AndAlso LineBefore < Items.Count Then
                    Dim rc As Rectangle = Items(LineBefore).GetBounds(ItemBoundsPortion.Entire)
                    DrawInsertionLine(rc.Left, rc.Right, rc.Top)
                End If

                If LineAfter >= 0 AndAlso LineBefore < Items.Count Then
                    Dim rc As Rectangle = Items(LineAfter).GetBounds(ItemBoundsPortion.Entire)
                    DrawInsertionLine(rc.Left, rc.Right, rc.Bottom)
                End If
            End If
        End Sub

        Private Sub DrawInsertionLine(ByVal X1 As Integer, ByVal X2 As Integer, ByVal Y As Integer)
            Using g As Graphics = Me.CreateGraphics()
                g.DrawLine(Pens.Red, X1, Y, X2 - 1, Y)
                Dim leftTriangle As Point() = New Point(2) {New Point(X1, Y - 4), New Point(X1 + 7, Y), New Point(X1, Y + 4)}
                Dim rightTriangle As Point() = New Point(2) {New Point(X2, Y - 4), New Point(X2 - 8, Y), New Point(X2, Y + 4)}
                g.FillPolygon(Brushes.Red, leftTriangle)
                g.FillPolygon(Brushes.Red, rightTriangle)
            End Using
        End Sub
    End Class
End Namespace
