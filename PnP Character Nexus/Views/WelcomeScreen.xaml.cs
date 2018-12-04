using PnP_Character_Nexus.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.AccessCache;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace PnP_Character_Nexus.Views
{
    public sealed partial class WelcomeScreen : Page
    {
        private WelcomeScreenViewModel _vm = new WelcomeScreenViewModel();
        //public WelcomeScreenViewModel ViewModel { get { return _vm; } set { _vm = value; SetViewModelBinding(value); } }

        public WelcomeScreen()
        {
            this.InitializeComponent();
            DataContext = _vm;
        }

        //private void SetViewModelBinding(WelcomeScreenViewModel value)
        //{
        //    DataContext = _vm;
        //}
    }
}
