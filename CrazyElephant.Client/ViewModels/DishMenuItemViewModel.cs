using CrazyElephant.Client.Models;
using Prism.Mvvm;

namespace CrazyElephant.Client.ViewModels
{
    public class DishMenuItemViewMode : BindableBase
    {
        /// <summary>
        /// 这是一个ViewModel的属性，用于表示菜品是否被选中
        /// 不是Model的属性
        /// </summary>
        public Dish Dish { get; set; }
        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.RaisePropertyChanged("IsSelected");
            }
        }

    }
}
