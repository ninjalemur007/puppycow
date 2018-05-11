﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AZED.CivicsApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SectionCardControl : Grid
    {


        public SectionCardControl()
        {
            InitializeComponent();

        }

        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(SectionCardControl));
        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly BindableProperty SectionNumberProperty = BindableProperty.Create(nameof(SectionNumber), typeof(string), typeof(SectionCardControl));
        public string SectionNumber
        {
            get { return (string)GetValue(SectionNumberProperty); }
            set { SetValue(SectionNumberProperty, value); }
        }

        public static readonly BindableProperty SectionTitleProperty = BindableProperty.Create(nameof(SectionTitle), typeof(string), typeof(SectionCardControl));
        public string SectionTitle
        {
            get { return (string)GetValue(SectionTitleProperty); }
            set { SetValue(SectionTitleProperty, value); }
        }

        public static readonly BindableProperty InfoPageProperty = BindableProperty.Create(nameof(InfoPage), typeof(string), typeof(SectionCardControl));
        public string InfoPage
        {
            get { return (string)GetValue(InfoPageProperty); }
            set { SetValue(InfoPageProperty, value); }
        }

        private double width = 0;
        private double height = 0;

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width != this.width || height != this.height)
            {
                this.width = width;
                this.height = height;
                double product = height / width;
                //if (width > height)
                if (product > .5)
                {
                    labelTitle.FontSize = 20;
                }
                else
                {
                    labelTitle.FontSize = 22;
                }
            }
        }

    }
}
