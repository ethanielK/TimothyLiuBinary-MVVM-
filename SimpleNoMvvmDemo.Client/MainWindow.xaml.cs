using System.Windows;
using Microsoft.Win32;

namespace SimpleNoMvvmDemo.Client
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(tb1.Text);
            double num2 = double.Parse(tb2.Text);
            double result = num1 + num2;
            tb3.Text = result.ToString();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }
    }
}