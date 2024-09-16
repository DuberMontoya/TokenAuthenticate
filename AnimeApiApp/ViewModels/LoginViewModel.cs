using AnimeApiApp.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AnimeApiApp.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly ILoginService _loginService;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string token;

        public LoginViewModel()
        {
            _loginService = Startup.GetService<ILoginService>();
            LoginCommand = new AsyncRelayCommand(LoginAsync);
        }

        public IAsyncRelayCommand LoginCommand { get; }

        private async Task LoginAsync()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Username and Password are required.", "OK");
                return;
            }

            var resultToken = await _loginService.LoginAsync(Username, Password);

            if (resultToken != null)
            {
                Token = resultToken;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid username or password.", "OK");
            }
        }
    }
}
