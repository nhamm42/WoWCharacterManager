using System;
using System.Collections.Generic;
using CharacterManagerService.Models;

namespace CharacterManagerService
{
    public class CharacterManagerService : ICharacterManagerService
    {
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        private readonly List<CharacterData> _characterList = new List<CharacterData>(); 

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Faction> GetFactions()
        {
            var factions = new List<Faction>
            {
                new Faction
                {
                    FactionId = 1,
                    FactionString = "Alliance"
                },
                new Faction
                {
                    FactionId = 2,
                    FactionString = "Horde"
                }
            };
            return factions;
        }

        public List<Race> GetRaces()
        {
            var races = new List<Race>
            {
                //Horde
                new Race
                {
                    FactionId = 1,
                    RaceId = 1,
                    RaceString = "Orc"
                },
                new Race
                {
                    FactionId = 1,
                    RaceId = 2,
                    RaceString = "Troll"
                },
                new Race
                {
                    FactionId = 1,
                    RaceId = 3,
                    RaceString = "Undead"
                },
                new Race
                {
                    FactionId = 1,
                    RaceId = 4,
                    RaceString = "Tauren"
                },
                new Race
                {
                    FactionId = 1,
                    RaceId = 5,
                    RaceString = "Blood Elf"
                },
                new Race
                {
                    FactionId = 1,
                    RaceId = 5,
                    RaceString = "Goblin"
                },
                //Alliance
                new Race
                {
                    FactionId = 2,
                    RaceId = 6,
                    RaceString = "Human"
                },
                new Race
                {
                    FactionId = 2,
                    RaceId = 7,
                    RaceString = "Dwarf"
                },
                new Race
                {
                    FactionId = 2,
                    RaceId = 8,
                    RaceString = "Gnome"
                },
                new Race
                {
                    FactionId = 2,
                    RaceId = 9,
                    RaceString = "Night Elf"
                },
                new Race
                {
                    FactionId = 2,
                    RaceId = 10,
                    RaceString = "Worgen"
                },
                new Race
                {
                    FactionId = 3,
                    RaceId = 11,
                    RaceString = "Pandaren"
                }
            };
            return races;
        }

        public List<Class> GetClasses()
        {
            var classes = new List<Class>
            {
                new Class
                {
                    ClassId = 1,
                    ClassString = "Death Knight"
                },
                new Class
                {
                    ClassId = 2,
                    ClassString = "Druid"
                },
                new Class
                {
                    ClassId = 3,
                    ClassString = "Hunter"
                },
                new Class
                {
                    ClassId = 4,
                    ClassString = "Mage"
                },
                new Class
                {
                    ClassId = 5,
                    ClassString = "Monk"
                },
                new Class
                {
                    ClassId = 6,
                    ClassString = "Paladin"
                },
                new Class
                {
                    ClassId = 7,
                    ClassString = "Priest"
                },
                new Class
                {
                    ClassId = 8,
                    ClassString = "Rogue"
                },
                new Class
                {
                    ClassId = 9,
                    ClassString = "Shaman"
                },
                new Class
                {
                    ClassId = 10,
                    ClassString = "Warlock"
                },
                new Class
                {
                    ClassId = 11,
                    ClassString = "Warrior"
                }
            };
            return classes;
        }

        public List<CharacterData> SubmitCharacterData(CharacterData submitCharacter)
        {
            _characterList.Add(submitCharacter);

            return _characterList;
        }
    }
}
