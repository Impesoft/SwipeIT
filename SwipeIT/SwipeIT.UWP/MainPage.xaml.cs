﻿namespace SwipeIT.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new SwipeIT.App());
        }
    }
}