﻿using AnimeApiApp.Pages;

namespace AnimeApiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }
    }
}
