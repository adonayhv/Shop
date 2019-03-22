﻿using GalaSoft.MvvmLight.Command;
using Shop.Common.Models;
using Shop.IUForms.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Shop.IUForms.ViewModels
{
 public   class MainViewModel
    {
        private static MainViewModel instance;

        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        public TokenResponse Token { get; set; }

        public LoginViewModel Login { get; set; }

        public ProductsViewModel Products { get; set; }
        public AddProductViewModel addProduct{ get; set; }
        public ICommand AddProductCommand { get { return new RelayCommand(this.GoAddProduct); } }

        private async void GoAddProduct()
        {
            this.addProduct = new AddProductViewModel();
         await   App.Navigator.PushAsync(new AddProductPage());
        }

        public MainViewModel()
        {
            instance = this;
            this.LoadMenus();

        }

        private void LoadMenus()
        {
            var menus = new List<Menu>
    {
        new Menu
        {
            Icon = "ic_info",
            PageName = "AboutPage",
            Title = "About"
        },

        new Menu
        {
            Icon = "ic_phonelink_setup",
            PageName = "SetupPage",
            Title = "Setup"
        },

        new Menu
        {
            Icon = "ic_exit_to_app",
            PageName = "LoginPage",
            Title = "Close session"
        }
    };

            this.Menus = new ObservableCollection<MenuItemViewModel>(menus.Select(m => new MenuItemViewModel
            {
                Icon = m.Icon,
                PageName = m.PageName,
                Title = m.Title
            }).ToList());
        }


        public static MainViewModel GetInstance()
        {
            if (instance==null)
            {
                return new MainViewModel();
            }
            return instance;
        }
    }
}
