<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128652747/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2926)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml.vb))
<!-- default file list end -->
# How to select all column cells by clicking on the column header similar to Excel


<p>To provide this functionality, handle the ready-to-use <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderClick.event">ColumnHeaderClick</a> event. In the event handler, iterate through the grid's visible rows and invoke the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.SelectCell.method">SelectCell</a> method for them.</p>

<br/>


