using System;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.AccessCache;
using Windows.Storage.Pickers;

namespace PnP_Character_Nexus.Storage
{
    public static class Source
    {
        public static StorageFolder Path { get; set; }

        private static async Task<StorageFolder> GetPath()
        {
            var picker = new FolderPicker() { SuggestedStartLocation = PickerLocationId.Desktop, ViewMode = PickerViewMode.Thumbnail };
            picker.FileTypeFilter.Add("*");
            var folder = await picker.PickSingleFolderAsync().AsTask().ConfigureAwait(false);

            if (folder != null)
            {
                StorageApplicationPermissions.FutureAccessList.AddOrReplace("PickedFolderToken", folder);
            }

            return folder;
        }
    }    
}
