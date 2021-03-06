using System.Collections.Generic;

namespace CastleGrimtol.Game
{
    public class Room : IRoom
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public List<Item> Items {get; set;}
        public void UseItem(Item item)
        {
            
        }
        public Dictionary<string, Room> Exits { get; set; }

        public Room(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}