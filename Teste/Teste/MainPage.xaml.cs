﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Teste
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("Teste.Images.googleMap.png");
        }
    }
}

