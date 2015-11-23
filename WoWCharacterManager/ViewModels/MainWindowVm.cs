using CharacterManagerService.Models;
using WoWCharacterManager.CharacterManagerServiceReference;

namespace WoWCharacterManager.ViewModels
{
    class MainWindowVm
    {
        public static CharacterData[] Characters;

        public static void GetCharacterList()
        {
            using (var client = new CharacterManagerServiceClient())
            {
                Characters = client.GetCharacterList();
            }
            //Characters = characterList;
        }
    }
}
