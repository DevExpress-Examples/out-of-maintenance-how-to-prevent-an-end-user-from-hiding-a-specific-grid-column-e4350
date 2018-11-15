<!-- default file list -->
*Files to look at*:

* [AbsoluteVisible.cs](./CS/DXSample/AbsoluteVisible.cs) (VB: [AbsoluteVisible.vb](./VB/DXSample/AbsoluteVisible.vb))
* [CustomRemoveColumnDropTarget.cs](./CS/DXSample/CustomRemoveColumnDropTarget.cs) (VB: [CustomRemoveColumnDropTarget.vb](./VB/DXSample/CustomRemoveColumnDropTarget.vb))
* [CustomTableView.cs](./CS/DXSample/CustomTableView.cs) (VB: [CustomTableView.vb](./VB/DXSample/CustomTableView.vb))
* [DataHelper.cs](./CS/DXSample/DataHelper.cs) (VB: [DataHelper.vb](./VB/DXSample/DataHelper.vb))
* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))
<!-- default file list end -->
# How to prevent an end-user from hiding a specific grid column


<p>This example demonstrates how to prevent an end-user from hiding a specific grid column. For this, you first need to create a <strong>RemoveColumnDropTarget</strong> class descendant and override the <strong>Drop</strong> method. Then, create a <strong>TableView</strong> class descendant and override the <strong>CreateEmptyDropTarget</strong> method, which should return an instance of the <strong>RemoveColumnDropTarget</strong> descendant. And finally, create an attached property for the AbsoluteVisible.<strong>IsEnable</strong> columns.<br><br></p>
<p>To prevent all columns from being hidden, use the built-in <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridDataViewBase_AllowMoveColumnToDropAreatopic.aspx">AllowMoveColumnToDropArea</a> property.</p>

<br/>


