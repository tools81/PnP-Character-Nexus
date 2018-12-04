using PnP_Character_Nexus.Models;
using PnP_Character_Nexus.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PnP_Character_Nexus.ViewModel
{
    public class WelcomeScreenViewModel : INotifyPropertyChanged
    {
        private Ruleset _selectedRuleset;
        public Ruleset SelectedRuleset
        {
            get { return _selectedRuleset; }
            set
            {
                _selectedRuleset = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand UpdateRuleset { get; set; }

        public WelcomeScreenViewModel()
        {
            SelectedRuleset = Storage.Data.Rulesets[0];
            UpdateRuleset = new RelayCommand<string>(new Action<string>(UpdateRulesetHandler));
        }

        private void UpdateRulesetHandler(string increment)
        {
            var incr = 0;
            int.TryParse(increment, out incr);
            var newIndex = Storage.Data.Rulesets.FindIndex(r => r.Name == SelectedRuleset.Name) + incr;

            if (incr > 0)
                SelectedRuleset = newIndex <= Storage.Data.Rulesets.Count() - 1 ? 
                    Storage.Data.Rulesets[newIndex] : Storage.Data.Rulesets.First();
            else
                SelectedRuleset = newIndex >= 0 ?
                    Storage.Data.Rulesets[newIndex] : Storage.Data.Rulesets.Last();
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
