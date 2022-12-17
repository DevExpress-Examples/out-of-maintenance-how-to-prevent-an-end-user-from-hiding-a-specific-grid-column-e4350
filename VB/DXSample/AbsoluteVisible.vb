Imports System.Windows

Namespace DXSample

    Public Class AbsoluteVisible

        Public Shared ReadOnly IsEnableProperty As DependencyProperty = DependencyProperty.RegisterAttached("IsEnable", GetType(Boolean), GetType(AbsoluteVisible), New UIPropertyMetadata(CType(Nothing, PropertyChangedCallback)))

        Public Shared Function GetIsEnable(ByVal target As DependencyObject) As Boolean
            Return CBool(target.GetValue(IsEnableProperty))
        End Function

        Public Shared Sub SetIsEnable(ByVal target As DependencyObject, ByVal value As Boolean)
            target.SetValue(IsEnableProperty, value)
        End Sub
    End Class
End Namespace
