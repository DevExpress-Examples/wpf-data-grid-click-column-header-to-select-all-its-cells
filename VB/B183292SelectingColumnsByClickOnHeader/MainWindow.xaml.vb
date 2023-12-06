Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports System.Windows.Input

Namespace B183292SelectingColumnsByClickOnHeader

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim list As List(Of TestData) = New List(Of TestData)()
            For i As Integer = 0 To 100 - 1
                list.Add(New TestData() With {.Text = "Row" & i, .Number1 = i, .Number2 = i + 2, .Number3 = i + 4})
            Next

            DataContext = list
        End Sub

        Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As ColumnHeaderClickEventArgs)
            If Keyboard.Modifiers.HasFlag(ModifierKeys.Alt) Then
                Me.view.Grid.BeginSelection()
                For i As Integer = 0 To Me.view.Grid.VisibleRowCount - 1
                    Me.view.SelectCell(i, TryCast(e.Column, GridColumn))
                Next

                Me.view.Grid.EndSelection()
                e.Handled = True
            End If
        End Sub
    End Class

    Public Class TestData

        Public Property Text As String

        Public Property Number1 As Integer

        Public Property Number2 As Integer

        Public Property Number3 As Integer
    End Class
End Namespace
