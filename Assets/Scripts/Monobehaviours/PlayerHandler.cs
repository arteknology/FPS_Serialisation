using System.Collections;
using System.Collections.Generic;
using Serializable;
using UnityEngine;
using UnityEngine.UI;

namespace Monobehaviours
{
    public class PlayerHandler : MonoBehaviour
    {
        public string Name;
        public int Xp;
        public int Level;
        public int MaxPv = 100;
        public int Pv;
        public int MaxLevelXp = 100;

        private const int max_level = 10;

        private void Start()
        {
            Pv = MaxPv;
        }

        //Gain Xp
        public void GainXp()
        {
            if (Xp < MaxLevelXp)
            {
                Xp++;
            }
            else LevelUp();
        }
        
        //Gain level
        private void LevelUp()
        {
            if (Level >= max_level || Xp < MaxLevelXp) return;
            Level++;
            Xp -= MaxLevelXp;
            MaxLevelXp += MaxLevelXp;
        }
    }
}
