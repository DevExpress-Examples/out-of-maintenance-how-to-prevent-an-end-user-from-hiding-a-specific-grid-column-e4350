Imports System.Windows
Imports System.Windows.Controls

Namespace DXSample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GetData()
        End Sub
    End Class
End Namespace
