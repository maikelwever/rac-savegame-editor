namespace RACSaveGameEditor
{
    public enum GameType
    {
        ERROR = 0,
        RAC = 1,
        GC = 2,
        UYA = 3,
        DL = 4,
        TOD = 5,
        QFB = 6,
        ACIT = 7,

    }
    public static class GameTypeFormatter {
        public static string ToString(GameType type) {
            switch (type) {
                case GameType.RAC:
                    return "Ratchet and Clank";
                case GameType.GC:
                    return "Ratchet and Clank 2 : Going Commando";
                case GameType.UYA:
                    return "Ratchet and Clank 3 : Up Your Arsenal";
                case GameType.DL:
                    return "Ratchet : Deadlocked / Gladiator";
                case GameType.TOD:
                    return "Ratchet and Clank Future : Tools of Destruction";
                case GameType.QFB:
                    return "Ratchet and Clank Future : Quest for Booty";
                case GameType.ACIT:
                    return "Ratchet and Clank Future : A Crack in Time";
                default:
                    return "Game version could not be properly detected.";
            }
        }
    }
}