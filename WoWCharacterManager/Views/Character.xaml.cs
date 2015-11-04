﻿using System;
using System.Windows;
using CharacterManagerService.Models;
using WoWCharacterManager.CharacterManagerServiceReference;

namespace WoWCharacterManager.Views
{
    public partial class Character
    {
        public Character()
        {
            InitializeComponent();
            FactionTypes.ItemsSource = Factions;
            RaceTypes.ItemsSource = Races;
            ClassTypes.ItemsSource = Classes;
        }

        public Faction[] Factions
        {
            get { return _factions; }
            set { _factions = value; }
        }

        public Race[] Races
        {
            get { return _races; }
            set { _races = value; }
        }

        public Class[] Classes
        {
            get { return _classes; }
            set { _classes = value; }
        }

        Faction[] _factions = GetFactions();
        Race[] _races = GetRaces();
        Class[] _classes = GetClasses();

        private static Faction[] GetFactions()
        {
            Faction[] result;
            using (var client = new CharacterManagerServiceClient())
            {
                result = client.GetFactions();
            }
            return result;
        }

        private static Race[] GetRaces()
        {
            Race[] result;
            using (var client = new CharacterManagerServiceClient())
            {
                result = client.GetRaces();
            }
            return result;
        }

        private static Class[] GetClasses()
        {
            Class[] result;
            using (var client = new CharacterManagerServiceClient())
            {
                result = client.GetClasses();
            }
            return result;
        }

        private void btn_SubmitCharacter(object sender, RoutedEventArgs routedEventArgs)
        {
            var submitCharacter = new CharacterData
            {
                Name = Charactername.Text,
                Level = Convert.ToInt32(CharacterLevel.Text),
                Faction = (Faction)FactionTypes.SelectionBoxItem,
                Race = (Race)RaceTypes.SelectionBoxItem,
                Class = (Class)ClassTypes.SelectionBoxItem
            };

            using (var client = new CharacterManagerServiceClient())
            {
                var result = client.SubmitCharacterData(submitCharacter);
            }
        }

        private void btn_Cancel(object sender, RoutedEventArgs routedEventArgs)
        {
            Close();
        }
    }
}