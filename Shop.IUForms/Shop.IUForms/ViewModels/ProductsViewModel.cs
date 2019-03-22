
using Shop.Common.Models;
using Shop.Common.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Shop.IUForms.ViewModels
{
 public   class ProductsViewModel : BaseViewModel
    {
        private readonly ApiService apiService;
        private ObservableCollection<Product> products;
        private bool isRefreshing;


        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { this.SetValue(ref this.isRefreshing, value); }
        }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();

        }

        private async void LoadProducts()
        {
            this.IsRefreshing = true;
            //antes
            //var response = await this.apiService.GetListAsync<Product>(
            //   "http://192.168.0.112:8090",
            //    "/API",
            //    "/Products"
            //    );
            //this.IsRefreshing = false;

            var url = Application.Current.Resources["UrlAPI"].ToString();
            var response = await this.apiService.GetListAsync<Product>(
                url,
                "/api",
                "/Products",
                "bearer",
                MainViewModel.GetInstance().Token.Token);


            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;

            }
            var myProducts = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(myProducts);
        }
    }
}
