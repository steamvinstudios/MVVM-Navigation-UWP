using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace App1.ViewModels
{
    public class ViewModel1
    {
        public Frame FrameVM;
        public ICommand GoNextPageCommand { get; set; }
        public ViewModel1()
        {
            GoNextPageCommand = new Commands.RelayCommand(GoNextPage);
        }
        void GoNextPage()
        {
            FrameVM.Navigate(typeof(Views.BlankPage2), null, new DrillInNavigationTransitionInfo());
        }
    }
}
