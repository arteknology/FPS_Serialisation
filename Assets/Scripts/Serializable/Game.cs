using System;

namespace Serializable
{
    [Serializable]
    public class Game
    {
        public string Name;
        public Player Player;
        public Weapon Weapon;
        public Achievements Achievements;
        public Enemy Enemy;
    }
}
