<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128652747/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2926)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml.vb))
<!-- default file list end -->
# How to select all column cells by clicking on the column header similar to Excel


<p>To provide this functionality, handle the ready-to-use <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderClick.event">ColumnHeaderClick</a> event. In the event handler, iterate through the grid's visible rows and invoke the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.SelectCell.method">SelectCell</a> method for them.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-click-column-header-to-select-all-its-cells&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-click-column-header-to-select-all-its-cells&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
