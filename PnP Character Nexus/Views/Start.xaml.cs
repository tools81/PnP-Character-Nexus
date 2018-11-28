using System;
using Windows.Storage.AccessCache;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;

namespace PnP_Character_Nexus.Views
{
    public sealed partial class Start : Page
    {
        public Start()
        {
            this.InitializeComponent();            
        }

        private async void btnSource_Click(object sender, RoutedEventArgs e)
        {
            pickSource.FileTypeFilter.Add("*");
            await OpenFolderPicker();

            Frame.Navigate(typeof(WelcomeScreen));
        }

        private async Task OpenFolderPicker()
        {
            var folder = await pickSource.PickSingleFolderAsync().AsTask().ConfigureAwait(false);
            if (folder != null)
            {
                StorageApplicationPermissions.FutureAccessList.AddOrReplace("PickedFolderToken", folder);
                Storage.Source.Folder = folder;
            }
        }
    }
}
