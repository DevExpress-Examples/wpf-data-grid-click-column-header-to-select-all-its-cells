Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports System.Windows.Input

Namespace B183292SelectingColumnsByClickOnHeader
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Dim list As New List(Of TestData)()
            For i As Integer = 0 To 99
                list.Add(New TestData() With { _
                    .Text = "Row" & i, _
                    .Number1 = i, _
                    .Number2 = i + 2, _
                    .Number3 = i + 4 _
                })
            Next i
            DataContext = list
        End Sub
        Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As ColumnHeaderClickEventArgs)
            If Keyboard.IsKeyDown(Key.LeftCtrl) Then
                view.Grid.BeginSelection()
                For i As Integer = 0 To view.Grid.VisibleRowCount - 1
                    view.SelectCell(i, TryCast(e.Column, GridColumn))
                Next i
                view.Grid.EndSelection()
                e.Handled = True
            End If
        End Sub
    End Class

    Public Class TestData
        Public Property Text() As String
        Public Property Number1() As Integer
        Public Property Number2() As Integer
        Public Property Number3() As Integer
    End Class
End Namespace