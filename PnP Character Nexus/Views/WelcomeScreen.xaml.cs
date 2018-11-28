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
        private Ruleset SelectedRuleset;

        public WelcomeScreen()
        {
            this.InitializeComponent();
            var rulesetTask = Task.Run(() => SelectedRuleset = Storage.Data.Rulesets[0]);
            rulesetTask.Wait();

            //SetBackground().Wait();
        }

        private async Task SetBackground()
        {
            var bitmap = new BitmapImage();
            var file = await Storage.Source.Folder.GetFileAsync(SelectedRuleset.Image);
            var stream = await file.OpenReadAsync();
            await bitmap.SetSourceAsync(stream);

            main.Background = new ImageBrush
            {
                ImageSource = bitmap
            };
        }
    }
}
