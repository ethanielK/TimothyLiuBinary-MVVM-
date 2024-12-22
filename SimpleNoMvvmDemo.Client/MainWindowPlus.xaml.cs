using System.Windows;
using Microsoft.Win32;

namespace SimpleNoMvvmDemo.Client
{
    /// <summary>
    /// MainWindowPlus.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindowPlus : Window
    {
        public MainWindowPlus()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.slider3.Value = this.slider1.Value + this.slider2.Value;
        }

        private void menuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }
    }
}
