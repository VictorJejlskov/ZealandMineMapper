﻿using Windows.UI.Xaml.Controls;
using MVVMEx05.Configuration.App;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MVVMEx05.Views.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            AppConfig.Setup(this, AppFrame);
        }
    }
}
