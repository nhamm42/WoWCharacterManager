using System;
using System.Windows;
using CharacterManagerService.Models;
using WoWCharacterManager.CharacterManagerServiceReference;
using WoWCharacterManager.ViewModels;

namespace WoWCharacterManager.Views
{
    public partial class Character
    {
        public Character()
        {
            InitializeComponent();
            DataContext = new CharacterVm();
            FactionTypes.ItemsSource = CharacterVm.GetFactions();
            RaceTypes.ItemsSource = CharacterVm.GetRaces();
            ClassTypes.ItemsSource = CharacterVm.GetClasses();
        }
     
         

        private void btn_SubmitCharacter(object sender, RoutedEventArgs routedEventArgs)
        {
            var submitCharacter = new CharacterData
            {
                Name = Charactername.Text,
                Level = Convert.ToInt32(CharacterLevel.Text),
                Faction = (Faction)FactionTypes.SelectedItem,
                Race = (Race) RaceTypes.SelectedItem,
                Class = (Class)ClassTypes.SelectedItem
            };

            using (var client = new CharacterManagerServiceClient())
            {
               client.SubmitCharacterData(submitCharacter);
            }
            MainWindowVm.GetCharacterList();

            Close();
        }

        private void btn_Cancel(object sender, RoutedEventArgs routedEventArgs)
        {
            Close();
        }
    }
}