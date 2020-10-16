using System;
using UnityEngine;

namespace Serializable
{
    [Serializable]
    public class Player
    {
        public string Name;
        public int Pv;
        public int Xp;
        public int Level;
        public int MaxLevelXp;
        public Vector3 Position;
    }
}
