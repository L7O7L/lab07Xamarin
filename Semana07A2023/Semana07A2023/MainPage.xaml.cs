﻿using Semana07A2023.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana07A2023
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnScan_Clicked(object sender, EventArgs e)  
        {  
            try  
            {  
                var scanner = DependencyService.Get<IQrScanningService>();  
                var result = await scanner.ScanAsync();  
                if (result != null)  
                {  
                    txtBarcode.Text = result;  
                }  
            }  
            catch (Exception ex)  
            {
                await DisplayAlert("Error", ex.Message.ToString(), "OK"); 
            }  
        } 
        
    }
}