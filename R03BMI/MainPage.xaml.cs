﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A32 平山　敬幸";
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            double h, w, answer;
            h = double.Parse(heighit.Text);
            if (h > 3)
            {
                h = h / 100;
            }
            w = double.Parse(weighit.Text);
            if (w > 1000)
            {
                w = w / 100;
            }



            answer = w / (h * h);
            result.Text = "" + answer;

        }
    }
}
