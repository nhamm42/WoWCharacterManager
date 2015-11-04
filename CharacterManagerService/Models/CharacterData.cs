namespace CharacterManagerService.Models
{
    public class CharacterData
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Faction Faction { get; set; }
        public Race Race { get; set; }
        public Class Class { get; set; }
    }
}