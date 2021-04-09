using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class BlankPage1 : Page
    {
        public ViewModels.ViewModel1 ViewModel { get; set; } = new ViewModels.ViewModel1();
        Frame _frame;
        public BlankPage1()
        {
            this.InitializeComponent();
            _frame = new Frame
            {
                Content = new Grid
                {
                    Background = new LinearGradientBrush
                    {
                        GradientStops =
                        {
                            new GradientStop
                            {
                                Color = Colors.Yellow,
                                Offset = 0
                            },
                            new GradientStop
                            {
                                Color = Colors.Orange,
                                Offset = 0.5
                            },
                            new GradientStop
                            {
                                Color = Colors.OrangeRed,
                                Offset = 1
                            }
                        }
                    },
                    Children =
                    {
                        new Button
                        {
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center,
                            Padding = new Thickness(40),
                            Command = ViewModel.GoNextPageCommand,
                            Content = new TextBlock
                            {
                                Text = "🐱‍🏍 Next Page",
                                FontSize = 32
                            }
                        }
                    }
                }
            };
            ViewModel.FrameVM = _frame;
            Content = _frame;
        }
    }
}
