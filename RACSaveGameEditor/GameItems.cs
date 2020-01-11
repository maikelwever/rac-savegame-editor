using System.Collections.Generic;


namespace RACSaveGameEditor
{
    public static class GameItems
    {
#region RacOneItems
        public static Dictionary<string, List<SaveGameItem>> RacOneItems = new Dictionary<string, List<SaveGameItem>> {
            {
                "Weapon Ammo", new List<SaveGameItem> {
                    new SaveGameItem.RangedShort("Bomb Glove", 0x147, 40),
                    new SaveGameItem.RangedShort("Blaster", 0x15b, 200),
                    new SaveGameItem.RangedShort("Visibomb", 0x153, 20),
                    new SaveGameItem.RangedShort("Devastator", 0x14b, 20),
                    new SaveGameItem.RangedShort("Gold Glove of Doom", 0x16f, 10),
                    new SaveGameItem.RangedShort("R.Y.N.O.", 0x17b, 50),
                    new SaveGameItem.RangedShort("Drone", 0x17f, 10),
                    new SaveGameItem.RangedShort("Pyrociter", 0x15f, 240),
                    new SaveGameItem.RangedShort("Mine Glove", 0x163, 50),
                    new SaveGameItem.RangedShort("Tesla Claw", 0x16b, 240),
                    new SaveGameItem.RangedShort("Decoy Glove", 0x183, 20),
                }
            },
            {
                "Weapon Unlocks", new List<SaveGameItem> {
                    new SaveGameItem.Boolean("Bomb Glove", 0x1c2),
                    new SaveGameItem.Boolean("Pyrocitor", 0x1c8),
                    new SaveGameItem.Boolean("Blaster", 0x1c7),
                    new SaveGameItem.Boolean("Glove of Doom", 0x1cc),
                    new SaveGameItem.Boolean("Mine Glove", 0x1c9),
                    new SaveGameItem.Boolean("Taunter", 0x1c6),
                    new SaveGameItem.Boolean("Suck Cannon", 0x1c1),
                    new SaveGameItem.Boolean("Devastator", 0x1c3),
                    new SaveGameItem.Boolean("Walloper", 0x1ca),
                    new SaveGameItem.Boolean("Visibomb Gun", 0x1c5),
                    new SaveGameItem.Boolean("Decoy Glove", 0x1d1),
                    new SaveGameItem.Boolean("Drone Device", 0x1d0),
                    new SaveGameItem.Boolean("Tesla Claw", 0x1cb),
                    new SaveGameItem.Boolean("Morph-o-ray", 0x1cd),
                    new SaveGameItem.Boolean("R.Y.N.O.", 0x1cf),
                }
            },
            {
                "Gadget unlocks", new List<SaveGameItem> {
                    new SaveGameItem.Boolean("Trespasser", 0x1d2),
                    new SaveGameItem.Boolean("Hydrodisplacer", 0x1ce),
                    new SaveGameItem.Boolean("Swingshot", 0x1c4),
                    new SaveGameItem.Boolean("Gadgetron PDA", 0x1d8),
                    new SaveGameItem.Boolean("Metal Detector", 0x1d3),
                    new SaveGameItem.Boolean("Hologuise", 0x1d7),
                    
                    new SaveGameItem.Boolean("Heli-Pack", 0x1ba),
                    new SaveGameItem.Boolean("Thruster-Pack", 0x1bb),
                    new SaveGameItem.Boolean("Hydro-Pack", 0x1bc),
                    
                    new SaveGameItem.Boolean("O2 Mask", 0x1be),
                    new SaveGameItem.Boolean("Sonic Summoner", 0x1bd),
                    new SaveGameItem.Boolean("Pilot's Helmet", 0x1bf),
                    
                    new SaveGameItem.Boolean("Grindboots", 0x1d5),
                    new SaveGameItem.Boolean("Magneboots", 0x1d4),
                }
            },
            {
                "Item unlocks", new List<SaveGameItem> {
                    new SaveGameItem.Boolean("Hoverboard", 0x1d6),
                    new SaveGameItem.Boolean("Persuader", 0x1db),
                    new SaveGameItem.Boolean("Bolt Grabber", 0x1da),
                    new SaveGameItem.Boolean("Map-o-matic", 0x1d9),
                }
            },
            {
                "Bolt counts", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Number of Bolts", 0x24),
                    new SaveGameItem.Integer("Total Bolts Collected", 0x48),
                }
            }
        };

#endregion
#region RacTwoItems
        public static Dictionary<string, List<SaveGameItem>> RacTwoItems = new Dictionary<string, List<SaveGameItem>> {
            {
                "Bolt counts", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Number of Bolts", 0x24),
                    new SaveGameItem.Integer("Number of Raritanium", 0x28),
                    new SaveGameItem.Integer("Total Bolts Collected", 0x48),
                }
            },
            {
                "Item Unlocks", new List<SaveGameItem> {
                    new SaveGameItem.Boolean("Heli-Pack", 0x292),
                    new SaveGameItem.Boolean("Thruster-Pack", 0x293),
                    new SaveGameItem.Boolean("Hydro-Pack", 0x294),
                    new SaveGameItem.Boolean("Mapper", 0x295),
                    new SaveGameItem.Boolean("Levitator", 0x298),
                    new SaveGameItem.Boolean("Swingshot", 0x29d),
                    new SaveGameItem.Boolean("Gravity Boots", 0x2a3),
                    new SaveGameItem.Boolean("Grindboots", 0x2a4),
                    new SaveGameItem.Boolean("Glider", 0x2a5),
                    new SaveGameItem.Boolean("Dynamo", 0x2b4),
                    new SaveGameItem.Boolean("Electrolyzer", 0x2b6),
                    new SaveGameItem.Boolean("Thermanator", 0x2b7),
                    new SaveGameItem.Boolean("Tractor Beam", 0x2be),
                    new SaveGameItem.Boolean("Biker Helmet", 0x2c0),
                    new SaveGameItem.Boolean("Quark Statuette", 0x2c1),
                    new SaveGameItem.Boolean("Box Breaker", 0x2c2),
                    new SaveGameItem.Boolean("Infiltrator", 0x2c4),
                    new SaveGameItem.Boolean("Charge Boots", 0x2c6),
                    new SaveGameItem.Boolean("Hypnomatic", 0x2c7),
                }
            },
            {
                "Weapon Ammo", new List<SaveGameItem> {
                    new SaveGameItem.RangedShort("Clank Zapper", 0x1c8, 30),
                    new SaveGameItem.RangedShort("Bomb Glove", 0x1c8, 40),
                    new SaveGameItem.RangedShort("Visibomb Gun", 0x1d8, 20),
                    new SaveGameItem.RangedShort("Decoy Glove", 0x1e8, 20),
                    new SaveGameItem.RangedShort("Tesla Claw", 0x1f0, 300),
                    new SaveGameItem.RangedShort("Chopper", 0x200, 35),
                    new SaveGameItem.RangedShort("Pulse Rifle", 0x204, 8),
                    new SaveGameItem.RangedShort("Seeker Gun", 0x208, 25),
                    new SaveGameItem.RangedShort("Hoverbomb Gun", 0x20c, 10),
                    new SaveGameItem.RangedShort("Blitz Gun", 0x210, 40),
                    new SaveGameItem.RangedShort("Minirocket Tube", 0x214, 25),
                    new SaveGameItem.RangedShort("Plasma Coil", 0x218, 15),
                    new SaveGameItem.RangedShort("Lava Gun", 0x21c, 200),
                    new SaveGameItem.RangedShort("Lancer", 0x220, 200),
                    new SaveGameItem.RangedShort("Synthenoid", 0x224, 12),
                    new SaveGameItem.RangedShort("Spiderbot Glove", 0x228, 8),
                    new SaveGameItem.RangedShort("Bouncer", 0x23c, 25),
                    new SaveGameItem.RangedShort("Miniturret Glove", 0x24c, 20),
                    new SaveGameItem.RangedShort("Zodiac", 0x254, 4),
                    new SaveGameItem.RangedShort("RYNO II", 0x258, 100),
                    new SaveGameItem.RangedShort("Shield Charger", 0x25c, 5),
                }
            },
            {
                "Weapon Unlocks", new List<SaveGameItem> {
                    new SaveGameItem.Boolean("Clank Zapper", 0x299),
                    new SaveGameItem.Boolean("Bomb Glove", 0x29c),
                    new SaveGameItem.Boolean("Visibomb Gun", 0x29e),
                    new SaveGameItem.Boolean("Sheepinator", 0x2a0),
                    new SaveGameItem.Boolean("Decoy Glove", 0x2a1),
                    new SaveGameItem.Boolean("Tesla Claw", 0x2a2),
                    new SaveGameItem.Boolean("Chopper", 0x2a5),
                    new SaveGameItem.Boolean("Pulse Rifle", 0x2a7),
                    new SaveGameItem.Boolean("Seeker Gun", 0x2a8),
                    new SaveGameItem.Boolean("Hoverbomb Gun", 0x2a9),
                    new SaveGameItem.Boolean("Blitz Gun", 0x2aa),
                    new SaveGameItem.Boolean("Minirocket Tube", 0x2ab),
                    new SaveGameItem.Boolean("Plasma Coil", 0x2ac),
                    new SaveGameItem.Boolean("Lava Gun", 0x2ad),
                    new SaveGameItem.Boolean("Lancer", 0x2ae),
                    new SaveGameItem.Boolean("Synthenoid", 0x2af),
                    new SaveGameItem.Boolean("Spiderbot Glove", 0x2b0),
                    new SaveGameItem.Boolean("Bouncer", 0x2b5),
                    new SaveGameItem.Boolean("Miniturret Glove", 0x2b9),
                    new SaveGameItem.Boolean("Zodiac", 0x2bb),
                    new SaveGameItem.Boolean("RYNO II", 0x2bc),
                    new SaveGameItem.Boolean("Shield Charger", 0x2bd),
                    new SaveGameItem.Boolean("Walloper", 0x2c5),
                }
            }
        };
#endregion
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
#region RacDeadlockedItems
        public static Dictionary<string, List<SaveGameItem>> RacDeadlockedItems = new Dictionary<string, List<SaveGameItem>> {
            {
                "Bolt counts", new List<SaveGameItem> {
                }
            }
        };
#endregion
#region RacToolsItems
        public static Dictionary<string, List<SaveGameItem>> RacToolsItems = new Dictionary<string, List<SaveGameItem>> {
            {
                "Bolt counts", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Number of Bolts", 0x41c),
                    new SaveGameItem.Integer("Number of Raritanium", 0x420),
                }
            }
        };
#endregion
#region RacQuestBootyItems
        public static Dictionary<string, List<SaveGameItem>> RacQuestBootyItems = new Dictionary<string, List<SaveGameItem>> {
            {
                "Bolt counts", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Number of Bolts", 0x247),
                }
            }
        };
#endregion
#region RacCrackTimeItems
        public static Dictionary<string, List<SaveGameItem>> RacCrackTimeItems = new Dictionary<string, List<SaveGameItem>> {
        };
#endregion
#region RacNexusItems
        public static Dictionary<string, List<SaveGameItem>> RacNexusItems = new Dictionary<string, List<SaveGameItem>> {
            {
                "Bolt counts", new List<SaveGameItem> {
                    new SaveGameItem.Integer("Number of Bolts", 0x105c),
                    new SaveGameItem.Integer("Number of Raritanium", 0x1060),
                }
            }
        };
#endregion
    }
}
