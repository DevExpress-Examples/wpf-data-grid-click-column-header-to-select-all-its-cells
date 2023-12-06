using System.Collections.Generic;
using System.Windows;
using DevExpress.Xpf.Grid;
using System.Windows.Input;

namespace B183292SelectingColumnsByClickOnHeader {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            List<TestData> list = new List<TestData>();
            for (int i = 0; i < 100; i++)
                list.Add(new TestData() { Text = "Row" + i, Number1 = i, Number2 = i + 2, Number3 = i + 4 });
            DataContext = list;
        }
        private void ColumnHeaderClick(object sender, ColumnHeaderClickEventArgs e) {
            if (Keyboard.Modifiers.HasFlag(ModifierKeys.Alt)) {
                view.Grid.BeginSelection();
                for (int i = 0; i < view.Grid.VisibleRowCount; i++)
                    view.SelectCell(i, e.Column as GridColumn);
                view.Grid.EndSelection();
                e.Handled = true;
            }
        }
    }

    public class TestData {
        public string Text { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
    }
}
