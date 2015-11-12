using CharacterManagerService.Models;
using WoWCharacterManager.CharacterManagerServiceReference;

namespace WoWCharacterManager.ViewModels
{
    class CharacterVm
    {
        public static Faction[] GetFactions()
        {
            Faction[] result;
            using (var client = new CharacterManagerServiceClient())
            {
                result = client.GetFactions();
            }
            return result;
        }

        public int SelectedFaction;

        public static Race[] GetRaces()
        {
            Race[] result;
            using (var client = new CharacterManagerServiceClient())
            {
                result = client.GetRaces(1);
            }
            return result;
        }

        public static Class[] GetClasses()
        {
            Class[] result;
            using (var client = new CharacterManagerServiceClient())
            {
                result = client.GetClasses();
            }
            return result;
        }
    }
}
