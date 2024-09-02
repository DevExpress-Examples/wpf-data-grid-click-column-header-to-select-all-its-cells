<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128652747/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2926)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid – Click a Column Header to Select All Its Cells

This example selects all column cells when a user clicks the column header (similar to Excel). Handle the [DataViewBase.ColumnHeaderClick](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderClick) event and if the user holds the `Alt` key, iterate through visible rows and call the [TableView.SelectCell](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.SelectCell(System.Int32-DevExpress.Xpf.Grid.GridColumn)) method.

## Files to Review

* [MainWindow.xaml](./CS/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml)
* [MainWindow.xaml.cs](./CS/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/B183292SelectingColumnsByClickOnHeader/MainWindow.xaml.vb))

## Documentation

* [DataViewBase.ColumnHeaderClick](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderClick)
* [TableView.SelectCell](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.SelectCell(System.Int32-DevExpress.Xpf.Grid.GridColumn))

## More Examples

* [WPF Data Grid - Customize Column Headers Based on Their Location](https://github.com/DevExpress-Examples/wpf-data-grid-customize-column-headers-based-on-location)
* [WPF Data Grid - Display a Check Box in Column Headers](https://github.com/DevExpress-Examples/wpf-data-grid-display-check-box-in-column-headers)
* [WPF Data Grid - Display an Image within a Column Header](https://github.com/DevExpress-Examples/how-to-display-an-image-within-a-column-header-e1629)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-click-column-header-to-select-all-its-cells&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-click-column-header-to-select-all-its-cells&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
