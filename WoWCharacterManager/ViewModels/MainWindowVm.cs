using CharacterManagerService.Models;

namespace WoWCharacterManager.ViewModels
{
    class MainWindowVm
    {
        public static CharacterData[] Characters;

        public static void GetCharacterList(CharacterData[] characterList)
        {
            Characters = characterList;
        }
    }
}
