using System.ComponentModel;

namespace SimpleMvvmDemo.Client.ViewModels
{
    // 具有通知功能的对象
    class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
