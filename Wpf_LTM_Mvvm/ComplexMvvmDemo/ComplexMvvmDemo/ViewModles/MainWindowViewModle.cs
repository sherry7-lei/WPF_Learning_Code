using ComplexMvvmDemo.Modles;
using ComplexMvvmDemo.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ComplexMvvmDemo.ViewModles
{
    internal class MainWindowViewModle : BindableBase
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

        private List<DishMenuItemViewModel> dishMenu;

        public List<DishMenuItemViewModel> DishMenu
        {
            get { return dishMenu; }
            set
            {
                dishMenu = value;
                this.RaisePropertyChanged("DishMenu");
            }
        }

        public MainWindowViewModle()
        {
            this.LoadRestaurant();
            this.LoadDishMenu();
            this.PlaceOrderCommand = new DelegateCommand(new Action(this.PlaceOrderCommandExecute));
            this.SelectMenuItemCommand = new DelegateCommand(new Action(this.SelectMenuItemCommandExecute));

        }

        private void SelectMenuItemCommandExecute()
        {
            this.Count = this.DishMenu.Count(i => i.IsSelected == true);
        }

        private void PlaceOrderCommandExecute()
        {
            var selectedDishes = this.dishMenu.Where(i => i.IsSelected == true).Select(i => i.Dish.Name).ToList();
            IOrderServices orderSevice = new MockOrderServices();
            orderSevice.PlaceOrder(selectedDishes);
            MessageBox.Show("订餐成功！");
        }

        // 加载View页面的菜单信息
        private void LoadDishMenu()
        {
            XmlDataServices ds = new XmlDataServices();
            var dishes = ds.GetAllDishes();
            this.dishMenu = new List<DishMenuItemViewModel>();
            foreach (var dish in dishes)
            {
                DishMenuItemViewModel item = new DishMenuItemViewModel();
                item.Dish = dish;
                this.DishMenu.Add(item);
            }
        }

        // 加载View页面的餐馆信息
        private void LoadRestaurant()
        {
            this.Restaurant = new Restaurant();
            this.Restaurant.Name = "樹羅酒吧";
            this.Restaurant.Address = "S省X市C区J路111号";
            this.Restaurant.PhoneNumber = "181 **** 3186";

        }
    } 
}
