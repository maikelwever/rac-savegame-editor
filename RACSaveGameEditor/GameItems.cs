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
                    new SaveGameItem.Boolean("Shock Blaster V2", 0x4d0),
                    new SaveGameItem.Boolean("Shock Blaster V3", 0x4d1),
                    new SaveGameItem.Boolean("Shock Blaster V4", 0x4d2),
                    new SaveGameItem.Boolean("Shock Blaster V5", 0x4d3),
                    new SaveGameItem.Boolean("Shock Blaster V6", 0x4d4),
                    new SaveGameItem.Boolean("Shock Blaster V7", 0x4d5),
                    new SaveGameItem.Boolean("Shock Blaster V8", 0x4d6),
                    new SaveGameItem.Boolean("N60 Storm V1", 0x4d7),
                    new SaveGameItem.Boolean("N60 Storm V2", 0x4d8),
                    new SaveGameItem.Boolean("N60 Storm V3", 0x4d9),
                    new SaveGameItem.Boolean("N60 Storm V4", 0x4da),
                    new SaveGameItem.Boolean("N60 Storm V5", 0x4db),
                    new SaveGameItem.Boolean("N60 Storm V6", 0x4dc),
                    new SaveGameItem.Boolean("N60 Storm V7", 0x4dd),
                    new SaveGameItem.Boolean("N60 Storm V8", 0x4de),
                    new SaveGameItem.Boolean("Infector V1", 0x4df),
                    new SaveGameItem.Boolean("Infector V2", 0x4e0),
                    new SaveGameItem.Boolean("Infector V3", 0x4e1),
                    new SaveGameItem.Boolean("Infector V4", 0x4e2),
                    new SaveGameItem.Boolean("Infector V5", 0x4e3),
                    new SaveGameItem.Boolean("Infector V6", 0x4e4),
                    new SaveGameItem.Boolean("Infector V7", 0x4e5),
                    new SaveGameItem.Boolean("Infector V8", 0x4e6),
                    new SaveGameItem.Boolean("Annihilator V1", 0x4e7),
                    new SaveGameItem.Boolean("Annihilator V2", 0x4e8),
                    new SaveGameItem.Boolean("Annihilator V3", 0x4e9),
                    new SaveGameItem.Boolean("Annihilator V4", 0x4ea),
                    new SaveGameItem.Boolean("Annihilator V5", 0x4eb),
                    new SaveGameItem.Boolean("Annihilator V6", 0x4ec),
                    new SaveGameItem.Boolean("Annihilator V7", 0x4ed),
                    new SaveGameItem.Boolean("Annihilator V8", 0x4ee),
                    new SaveGameItem.Boolean("Spitting Hydra V1", 0x4ef),
                    new SaveGameItem.Boolean("Spitting Hydra V2", 0x4f0),
                    new SaveGameItem.Boolean("Spitting Hydra V3", 0x4f1),
                    new SaveGameItem.Boolean("Spitting Hydra V4", 0x4f2),
                    new SaveGameItem.Boolean("Spitting Hydra V5", 0x4f3),
                    new SaveGameItem.Boolean("Spitting Hydra V6", 0x4f4),
                    new SaveGameItem.Boolean("Spitting Hydra V7", 0x4f5),
                    new SaveGameItem.Boolean("Spitting Hydra V8", 0x4f6),
                    new SaveGameItem.Boolean("Disc Blade Gun V1", 0x4f7),
                    new SaveGameItem.Boolean("Disc Blade Gun V2", 0x4f8),
                    new SaveGameItem.Boolean("Disc Blade Gun V3", 0x4f9),
                    new SaveGameItem.Boolean("Disc Blade Gun V4", 0x4fa),
                    new SaveGameItem.Boolean("Disc Blade Gun V5", 0x4fb),
                    new SaveGameItem.Boolean("Disc Blade Gun V6", 0x4fc),
                    new SaveGameItem.Boolean("Disc Blade Gun V7", 0x4fd),
                    new SaveGameItem.Boolean("Disc Blade Gun V8", 0x4fe),
                    new SaveGameItem.Boolean("Agents of Doom V1", 0x4ff),
                    new SaveGameItem.Boolean("Agents of Doom V2", 0x500),
                    new SaveGameItem.Boolean("Agents of Doom V3", 0x501),
                    new SaveGameItem.Boolean("Agents of Doom V4", 0x502),
                    new SaveGameItem.Boolean("Agents of Doom V5", 0x503),
                    new SaveGameItem.Boolean("Agents of Doom V6", 0x504),
                    new SaveGameItem.Boolean("Agents of Doom V7", 0x505),
                    new SaveGameItem.Boolean("Agents of Doom V8", 0x506),
                    new SaveGameItem.Boolean("Rift Inducer V1", 0x507),
                    new SaveGameItem.Boolean("Rift Inducer V2", 0x508),
                    new SaveGameItem.Boolean("Rift Inducer V3", 0x509),
                    new SaveGameItem.Boolean("Rift Inducer V4", 0x50a),
                    new SaveGameItem.Boolean("Rift Inducer V5", 0x50b),
                    new SaveGameItem.Boolean("Rift Inducer V6", 0x50c),
                    new SaveGameItem.Boolean("Rift Inducer V7", 0x50d),
                    new SaveGameItem.Boolean("Rift Inducer V8", 0x50e),
                    new SaveGameItem.Boolean("Holoshield V1", 0x50f),
                    new SaveGameItem.Boolean("Holoshield V2", 0x510),
                    new SaveGameItem.Boolean("Holoshield V3", 0x511),
                    new SaveGameItem.Boolean("Holoshield V4", 0x512),
                    new SaveGameItem.Boolean("Holoshield V5", 0x513),
                    new SaveGameItem.Boolean("Holoshield V6", 0x514),
                    new SaveGameItem.Boolean("Holoshield V7", 0x515),
                    new SaveGameItem.Boolean("Holoshield V8", 0x516),
                    new SaveGameItem.Boolean("Flux Rifle V1", 0x517),
                    new SaveGameItem.Boolean("Flux Rifle V2", 0x518),
                    new SaveGameItem.Boolean("Flux Rifle V3", 0x519),
                    new SaveGameItem.Boolean("Flux Rifle V4", 0x51a),
                    new SaveGameItem.Boolean("Flux Rifle V5", 0x51b),
                    new SaveGameItem.Boolean("Flux Rifle V6", 0x51c),
                    new SaveGameItem.Boolean("Flux Rifle V7", 0x51d),
                    new SaveGameItem.Boolean("Flux Rifle V8", 0x51e),
                    new SaveGameItem.Boolean("Nitro Launcher V1", 0x51f),
                    new SaveGameItem.Boolean("Nitro Launcher V2", 0x520),
                    new SaveGameItem.Boolean("Nitro Launcher V3", 0x521),
                    new SaveGameItem.Boolean("Nitro Launcher V4", 0x522),
                    new SaveGameItem.Boolean("Nitro Launcher V5", 0x523),
                    new SaveGameItem.Boolean("Nitro Launcher V6", 0x524),
                    new SaveGameItem.Boolean("Nitro Launcher V7", 0x525),
                    new SaveGameItem.Boolean("Nitro Launcher V8", 0x526),
                    new SaveGameItem.Boolean("Plasma Whip V1", 0x527),
                    new SaveGameItem.Boolean("Plasma Whip V2", 0x528),
                    new SaveGameItem.Boolean("Plasma Whip V3", 0x529),
                    new SaveGameItem.Boolean("Plasma Whip V4", 0x52a),
                    new SaveGameItem.Boolean("Plasma Whip V5", 0x52b),
                    new SaveGameItem.Boolean("Plasma Whip V6", 0x52c),
                    new SaveGameItem.Boolean("Plasma Whip V7", 0x52d),
                    new SaveGameItem.Boolean("Plasma Whip V8", 0x52e),
                    new SaveGameItem.Boolean("Quack-O-Ray V1", 0x52f),
                    new SaveGameItem.Boolean("Quack-O-Ray V2", 0x530),
                    new SaveGameItem.Boolean("Quack-O-Ray V3", 0x531),
                    new SaveGameItem.Boolean("Quack-O-Ray V4", 0x532),
                    new SaveGameItem.Boolean("Quack-O-Ray V5", 0x533),
                    new SaveGameItem.Boolean("Quack-O-Ray V6", 0x534),
                    new SaveGameItem.Boolean("Quack-O-Ray V7", 0x535),
                    new SaveGameItem.Boolean("Quack-O-Ray V8", 0x536),
                    new SaveGameItem.Boolean("R3YNO V1", 0x53f),
                    new SaveGameItem.Boolean("R3YNO V2", 0x540),
                    new SaveGameItem.Boolean("R3YNO V3", 0x541),
                    new SaveGameItem.Boolean("R3YNO V4", 0x542),
                    new SaveGameItem.Boolean("R3YNO V5", 0x543),
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