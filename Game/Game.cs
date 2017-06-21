using System.Collections.Generic;

namespace CastleGrimtol.Game
{
    public class Game : IGame
    {
        public Room CurrentRoom {get; set;}
        public Player CurrentPlayer{get; set;}
        public void Setup()
        {
            var barracks = new Room("Barracks", "whatever");
            var captainsQuarters = new Room("Captian's Quarters", "whatever");
            var castleCourtyard = new Room("Castle Courtyard", "whatever");
            var guardRoom = new Room("Guard Room", "whatever");
            var dungeon = new Room("Dungeon", "whatever");
            var squireTower = new Room("Squire Tower", "whatever");
            var councilRoom = new Room("Council Room", "whatever");
            var throneRoom = new Room("Throne Room", "whatever");
            var hall1 = new Room("Hallway", "North is barracks, south is captains quarters, east is castle courtyard");
            var hall2 = new Room("Hallway", "North is throne room, east is squire tower, south is castle courtyard");
            var hall3 = new Room("Hallway", "North is castle courtyard, west is captains quarters, east is guard room");
            
            hall1.Exits.Add("North", throneRoom);
            hall1.Exits.Add("South", captainsQuarters);
            hall1.Exits.Add("East", castleCourtyard);
            hall2.Exits.Add("North", throneRoom);
            hall2.Exits.Add("East", squireTower);
            hall2.Exits.Add("South", castleCourtyard);
            hall3.Exits.Add("North", castleCourtyard);
            hall3.Exits.Add("West", captainsQuarters);
            hall3.Exits.Add("East", guardRoom);
            barracks.Exits.Add("South", hall1);
            captainsQuarters.Exits.Add("North", hall1);
            captainsQuarters.Exits.Add("East", hall3);
            throneRoom.Exits.Add("South", hall2);
            squireTower.Exits.Add("West", hall2);
            squireTower.Exits.Add("North", councilRoom);
            councilRoom.Exits.Add("South", squireTower);
            dungeon.Exits.Add("South", guardRoom);
            guardRoom.Exits.Add("North", dungeon);
            guardRoom.Exits.Add("West", hall3);
            castleCourtyard.Exits.Add("North", hall2);
            castleCourtyard.Exits.Add("South", hall3);
            castleCourtyard.Exits.Add("East", hall1);

            //create all rooms 
            // var Foyer = new Room(name, description here)
            // var ballroom = new Room(name,.....)

            //create 'relationships' exits from each room 
            // Foyer.Exits.Add("north", ballroom)

            //create items 
            //var flask = new Item(....)
            //Foyer.Items.Add(flask)



            //currentRoom = Foyer

            //if player is in Foyer and says go N CurrentRoom = currentroom.exits.north
        }
        public void Reset()
        {

        }
        public void UseItem(string itemName)
        {

        }
        

    }
}