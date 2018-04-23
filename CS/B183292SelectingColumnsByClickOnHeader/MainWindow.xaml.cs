using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid;

namespace B183292SelectingColumnsByClickOnHeader {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            List<TestData> list = new List<TestData>();
            for(int i = 0; i < 100; i++)
                list.Add(new TestData() { Text = "Row" + i, Number1 = i, Number2 = i + 2, Number3 = i + 4 });
            DataContext = list;
        }
    }

    public class TestData {
        public string Text { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
    }

    public class MyTableView : TableView {
        protected override void OnColumnHeaderClick(ColumnBase column, bool isShift, bool isCtrl) {
            if(isCtrl) {
                BeginSelection();
                for(int i = 0; i < Grid.VisibleRowCount; i++)
                    SelectCell(i, column as GridColumn);
                EndSelection();
                return;
            }
            base.OnColumnHeaderClick(column, isShift, isCtrl);
        }
    }
}
