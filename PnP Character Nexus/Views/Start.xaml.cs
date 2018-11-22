using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.AccessCache;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.Storage;

namespace PnP_Character_Nexus.Views
{
    public sealed partial class Start : Page
    {
        public Start()
        {
            this.InitializeComponent();            
        }

        private void btnSource_Click(object sender, RoutedEventArgs e)
        {
            pickSource.FileTypeFilter.Add("*");
            var pickerTask = Task.Factory.StartNew(new Func<Task>(async () =>
            {
                var folder = await pickSource.PickSingleFolderAsync().AsTask();
                if (folder != null)
                {
                    StorageApplicationPermissions.FutureAccessList.AddOrReplace("PickedFolderToken", folder);
                    Storage.Source.Path = folder;
                }
            }));
            pickerTask.Wait();
            
            this.Frame.Navigate(typeof(WelcomeScreen));
        }

        private async Task OpenFolderPicker()
        {
            var folder = await pickSource.PickSingleFolderAsync().AsTask();
            if (folder != null)
            {
                StorageApplicationPermissions.FutureAccessList.AddOrReplace("PickedFolderToken", folder);
                Storage.Source.Path = folder;
            }
        }
    }
}
