# How to select all column cells by clicking on the column header similar to Excel


<p>To provide this functionality, handle the ready-to-use <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderClick.event">ColumnHeaderClick</a> event. In the event handler, iterate through the grid's visible rows and invoke the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.SelectCell.method">SelectCell</a> method for them.</p>

<br/>


