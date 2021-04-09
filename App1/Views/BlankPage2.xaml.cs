using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        public ViewModels.ViewModel1 ViewModel { get; set; } = new ViewModels.ViewModel1();
        public BlankPage2()
        {
            this.InitializeComponent();
            ViewModel.FrameVM = Window.Current.Content as Frame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.FrameVM.Navigate(typeof(BlankPage1));
        }
    }
}
