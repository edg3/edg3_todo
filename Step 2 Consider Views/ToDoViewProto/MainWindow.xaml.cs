using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoViewProto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (null == cmbViews.SelectedItem) return;

            Window w = null;
            switch (cmbViews.SelectedIndex)
            {
                case 0:
                    w = new MainView();
                    (w as MainView).lstList.ItemsSource = lstItems;
                    break;
            }
            if (null != w)
            {
                this.Content = w.Content;
                w.Close();
            }
        }

        public List<ToDoItems> lstItems = new List<ToDoItems>() {
            new ToDoItems()
            {
                Name = "Blog Post",
                When = new DateTime(2020, 4, 5),
                Description = "This is nondescript but just to show how we can play with UI."
            },
            new ToDoItems()
            {
                Name = "Program Something",
                When = new DateTime(2020, 4, 7),
                Description = "This could perhaps help me with data binding."
            }
        };
    }
}
