﻿using System;
using Xamarin.Forms;
using Teste.Views;
using Xamarin.Forms.Xaml;

namespace Teste
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new TabbedHome();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

