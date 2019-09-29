using System.Collections.Generic;


namespace RACSaveGameEditor
{
    public static class GameItems
    {
        public static Dictionary<string, List<SaveGameItem>> RacOneItems = new Dictionary<string, List<SaveGameItem>> {
            {
                "Weapon Ammo", new List<SaveGameItem> {
                    new SaveGameItem.RangedShort("Bomb Glove", 0x147, 0, 40),
                    new SaveGameItem.RangedShort("Blaster", 0x15b, 0, 200),
                    new SaveGameItem.RangedShort("Visibomb", 0x153, 0, 20),
                    new SaveGameItem.RangedShort("Devastator", 0x14b, 0, 20),
                    new SaveGameItem.RangedShort("Gold Glove of Doom", 0x16f, 0, 10),
                    new SaveGameItem.RangedShort("R.Y.N.O.", 0x17b, 0, 50),
                    new SaveGameItem.RangedShort("Drone", 0x17f, 0, 10),
                    new SaveGameItem.RangedShort("Pyrociter", 0x15f, 0, 240),
                    new SaveGameItem.RangedShort("Mine Glove", 0x163, 0, 50),
                    new SaveGameItem.RangedShort("Tesla Claw", 0x16b, 0, 240),
                    new SaveGameItem.RangedShort("Decoy Glove", 0x183, 0, 20),
                }
            },
            {
                "Bolt counts", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Number of Bolts", 0x24),
                    new SaveGameItem.Integer("Total Bolts Collected", 0x48),
                }
            }
        };

        public static Dictionary<string, List<SaveGameItem>> RacTwoItems = new Dictionary<string, List<SaveGameItem>> {
            {
                "Bolt counts", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Number of Bolts", 0x24),
                    new SaveGameItem.Integer("Number of Raritanium", 0x28),
                    new SaveGameItem.Integer("Total Bolts Collected", 0x48),
                }
            }
        };

#region RacThreeItems
        public static Dictionary<string, List<SaveGameItem>> RacThreeItems = new Dictionary<string, List<SaveGameItem>> {
            {
                "Bolt counts", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Number of Bolts", 0x24),
                }
            },
            {
                "Item Unlocks", new List<SaveGameItem> {
                    new SaveGameItem.Boolean("Heli Pack", 0x4aa),
                    new SaveGameItem.Boolean("Thruster Pack", 0x4ab),
                    new SaveGameItem.Boolean("Hydro Pack", 0x4ac),
                    new SaveGameItem.Boolean("Map-o-matic", 0x4ad),
                    new SaveGameItem.Boolean("Commando Suit", 0x4ae),
                    new SaveGameItem.Boolean("Bolt Grabber v2", 0x4af),
                    new SaveGameItem.Boolean("Levitator", 0x4b0),
                    new SaveGameItem.Boolean("Omniwrench", 0x4b1),
                    new SaveGameItem.Boolean("Hypershot", 0x4b3),
                    new SaveGameItem.Boolean("Gravity Boots", 0x4b5),
                    new SaveGameItem.Boolean("Plasma Coil", 0x4b8),
                    new SaveGameItem.Boolean("Lava Gun", 0x4b9),
                    new SaveGameItem.Boolean("Refractor", 0x4ba),
                    new SaveGameItem.Boolean("Bouncer", 0x4bb),
                    new SaveGameItem.Boolean("The Hacker", 0x4bc),
                    new SaveGameItem.Boolean("Miniturret", 0x4bd),
                    new SaveGameItem.Boolean("Shield Charger", 0x4be),
                    new SaveGameItem.Boolean("Charge Boots", 0x4c5),
                    new SaveGameItem.Boolean("Thyrra Guise", 0x4c6),
                    new SaveGameItem.Boolean("Warp Pad", 0x4c7),
                    new SaveGameItem.Boolean("Nano Pak", 0x4c8),
                    new SaveGameItem.Boolean("Star Map", 0x4ca),
                    new SaveGameItem.Boolean("Master Plan", 0x4cb),
                    new SaveGameItem.Boolean("PDA", 0x4cc),
                    new SaveGameItem.Boolean("Third Person Mode", 0x4cc),
                    new SaveGameItem.Boolean("First Person Mode", 0x4cd),
                    new SaveGameItem.Boolean("Lock-Strafe Mode", 0x4ce),
                }
            },
            {
                "Weapon Ammo", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Shock Blaster", 0x2cc),
                    new SaveGameItem.Integer("N60 Storm", 0x2ec),
                    new SaveGameItem.Integer("Infector", 0x30c),
                    new SaveGameItem.Integer("Annihilator", 0x32c),
                    new SaveGameItem.Integer("Spitting Hydra", 0x34c),
                    new SaveGameItem.Integer("Disc Blade Gun", 0x36c),
                    new SaveGameItem.Integer("Agents of Doom", 0x38c),
                    new SaveGameItem.Integer("Rift Inducer", 0x3ac),
                    new SaveGameItem.Integer("Holoshield", 0x3cc),
                    new SaveGameItem.Integer("Flux Rifle", 0x3ec),
                    new SaveGameItem.Integer("Nitro Launcher", 0x40c),
                    new SaveGameItem.Integer("Plasma Whip", 0x42c),
                    new SaveGameItem.Integer("Quack-O-Ray", 0x46c),
                    new SaveGameItem.Integer("R3YNO", 0x48c),
                }
            },
            {
                "Weapon EXP", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Shock Blaster", 0x68c),
                    new SaveGameItem.Integer("N60 Storm", 0x6ac),
                    new SaveGameItem.Integer("Infector", 0x6cc),
                    new SaveGameItem.Integer("Annihilator", 0x6ec),
                    new SaveGameItem.Integer("Spitting Hydra", 0x70c),
                    new SaveGameItem.Integer("Disc Blade Gun", 0x72c),
                    new SaveGameItem.Integer("Agents of Doom", 0x74c),
                    new SaveGameItem.Integer("Rift Inducer", 0x76c),
                    new SaveGameItem.Integer("Holoshield", 0x78c),
                    new SaveGameItem.Integer("Flux Rifle", 0x7ac),
                    new SaveGameItem.Integer("Nitro Launcher", 0x7cc),
                    new SaveGameItem.Integer("Plasma Whip", 0x7ec),
                    new SaveGameItem.Integer("Quack-O-Ray", 0x80c),
                    new SaveGameItem.Integer("R3YNO", 0x84c),
                }
            },
            {
                "Weapon Unlocks", new List<SaveGameItem> {
                    new SaveGameItem.Boolean("Shock Blaster V1", 0x4cf),
                    new SaveGameItem.Boolean("N60 Storm V1", 0x4d7),
                    new SaveGameItem.Boolean("Infector V1", 0x4df),
                    new SaveGameItem.Boolean("Annihilator V1", 0x4e7),
                    new SaveGameItem.Boolean("Spitting Hydra V1", 0x4ef),
                    new SaveGameItem.Boolean("Disc Blade Gun V1", 0x4f7),
                    new SaveGameItem.Boolean("Agents of Doom V1", 0x4ff),
                    new SaveGameItem.Boolean("Rift Inducer V1", 0x507),
                    new SaveGameItem.Boolean("Holoshield V1", 0x50f),
                    new SaveGameItem.Boolean("Flux Rifle V1", 0x517),
                    new SaveGameItem.Boolean("Nitro Launcher V1", 0x51f),
                    new SaveGameItem.Boolean("Plasma Whip V1", 0x527),
                    new SaveGameItem.Boolean("Quack-O-Ray V1", 0x52f),
                    new SaveGameItem.Boolean("R3YNO V1", 0x53f),
                } 
            },
            {
                "Misc", new List<SaveGameItem> {
                    new SaveGameItem.Boolean("Enable Quick Select Pause", 0x2c26),
                }
            }
        };
#endregion

        public static Dictionary<string, List<SaveGameItem>> RacQuestBooty = new Dictionary<string, List<SaveGameItem>> {
            {
                "Bolt counts", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Number of Bolts", 0x247),
                }
            }
        };
    }
}
