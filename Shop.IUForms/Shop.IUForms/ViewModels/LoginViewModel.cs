

namespace Shop.IUForms.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Shop.IUForms.Views;
    using System.Windows.Input;
using Xamarin.Forms;
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        public LoginViewModel()
        {
            this.Email = "adonayhv@gmail.com";
            this.Password = "123456";
        }

        private async void Login()
        {

            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email",
                    "Acept"

                    );
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a password",
                    "Acept"

                    );
                return;
            }

            if (!this.Email.Equals("adonayhv@gmail.com") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "user or  password wrong",
                   "Acept"

                   );
                return;
            }
            //await Application.Current.MainPage.DisplayAlert(
            //      "Ok",
            //      "Fuck yeah!!!",
            //      "Acept"

            //      );
            //return;

            MainViewModel.GetInstance().Products = new ProductsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());
        }
    }
}
