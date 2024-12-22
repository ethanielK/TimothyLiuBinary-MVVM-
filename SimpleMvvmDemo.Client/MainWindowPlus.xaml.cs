using System.Windows;
using SimpleMvvmDemo.Client.ViewModels;

namespace SimpleMvvmDemo.Client
{
    /// <summary>
    /// MainWindowPlus.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindowPlus : Window
    {
        public MainWindowPlus()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }
}
