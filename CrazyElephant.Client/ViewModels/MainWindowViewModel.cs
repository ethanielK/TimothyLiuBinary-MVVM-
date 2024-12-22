using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CrazyElephant.Client.Models;
using CrazyElephant.Client.Services;
using Prism.Commands;
using Prism.Mvvm;

namespace CrazyElephant.Client.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand PlaceOrderCommand { get; set; }
        public DelegateCommand SelectMenuItemCommand { get; set; }

        private int count;

        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                this.RaisePropertyChanged("Count");
            }
        }

        private Restaurant restaurant;

        public Restaurant Restaurant
        {
            get { return restaurant; }
            set
            {
                restaurant = value;
                this.RaisePropertyChanged("Restaurant");
            }
        }

        private List<DishMenuItemViewMode> dishMenu;

        public List<DishMenuItemViewMode> DishMenu
        {
            get { return dishMenu; }
            set
            {
                dishMenu = value;
                this.RaisePropertyChanged("DishMenu");
            }
        }

        public MainWindowViewModel()
        {
            this.LoadRestaurant();
            this.LoadDishMenu();
            this.PlaceOrderCommand = new DelegateCommand(new Action(this.PlaceOrderCommandExecute));
            this.SelectMenuItemCommand = new DelegateCommand(new Action(this.SelectMenuItemCommandExecute));
        }

        private void LoadRestaurant()
        {
            this.Restaurant = new Restaurant()
            {
                Name = "Crazy 大象",
                Address = "北京市海淀区万泉河路紫金庄园1号楼1层113室（亲们：这地儿特难找！）",
                PhoneNumber = "010-88888888"
            };
        }

        private void LoadDishMenu()
        {
            XmlDataService ds = new XmlDataService();
            var dishes = ds.getAllDishes();
            this.DishMenu = new List<DishMenuItemViewMode>();
            foreach (var dish in dishes)
            {
                DishMenuItemViewMode item = new DishMenuItemViewMode();
                item.Dish = dish;
                this.DishMenu.Add(item);
            }
        }

        private void PlaceOrderCommandExecute()
        {
            var selectedDishes = this.DishMenu.Where(x => x.IsSelected).Select(x => x.Dish.Name).ToList();
            IOrderService orderService = new MockOrderService();
            orderService.PlaceOrder(selectedDishes);
            MessageBox.Show("下单成功！");
        }

        private void SelectMenuItemCommandExecute()
        {
            this.Count = this.DishMenu.Count(x => x.IsSelected);
        }
    }
}
