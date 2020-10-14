using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Monobehaviours
{
    public class PlayerHandler : MonoBehaviour
    {
        private Player Player;
        public int Xp;
        public int Level;
        private int MaxLevel = 10;
        private int MaxLevelXp = 10;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        //Save Player
        private void Save()
        {
            Player = new Player
            {
                Position = transform.position
                //Name = 
            };
            DataHandler.Save(UnityDirectory.StreamingAssetPath, Player, Player.Name);
        }
        
        //Load Player
        public void Load()
        {
            Player = DataHandler.Load<Player>(UnityDirectory.StreamingAssetPath, Player.Name);
            transform.position = Player.Position;
            Xp = Player.Xp;
            Level = Player.Level;
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
        public void LevelUp()
        {
            if (Level < MaxLevel && Xp >= MaxLevelXp)
            {
                Level++;
                Xp -= MaxLevelXp;
                MaxLevelXp += MaxLevel;
            }
        }
    }
}
