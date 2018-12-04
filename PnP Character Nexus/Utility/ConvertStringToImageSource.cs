using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace PnP_Character_Nexus.Utility
{
    public static class ConvertStringToImageSource
    {
        public static async Task<ImageBrush> GetSourceFromPath(string path)
        {
            var bitmap = new BitmapImage();
            var file = await Storage.Source.Folder.GetFileAsync(path);
            var stream = await file.OpenReadAsync();
            await bitmap.SetSourceAsync(stream);

            return new ImageBrush
            {
                ImageSource = bitmap
            };
        }
    }
}
