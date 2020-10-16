using System;
using System.Collections.Generic;
using Serializable;
using UnityEngine;
using UnityEngine.UI;

namespace Monobehaviours
{
    public class GameHandler : MonoBehaviour
    {
        public Game Game;
        public Player Player;
        public Weapon Weapon;
        public Achievements Achievements;
        public Enemy Enemy;
        public InputField InputField;
        public PlayerHandler PlayerHandler;

        private bool _clicked;
        private string _toLoad;
        
        private void Start()
        {
            _clicked = GameToLoad.Clicked;
            if (_clicked)
            {
                _toLoad = GameToLoad.ToLoad;
                Load();
            }
        }

        public void Save()
        {
            Game = new Game()
            {
                Name = InputField.text,
                Player = new Player
                {
                    Name = Game.Name,
                    Position = PlayerHandler.transform.position,
                    Pv = PlayerHandler.Pv,
                    Xp = PlayerHandler.Xp,
                    Level = PlayerHandler.Level,
                    MaxLevelXp = PlayerHandler.MaxLevelXp
                },
                Weapon = Weapon,
                Achievements = Achievements,
                Enemy = Enemy
            };
            

            DataHandler.Save(UnityDirectory.StreamingAssetPath, Game, Game.Name);
        }
        
        public void Load()
        {
            Game = DataHandler.Load<Game>(UnityDirectory.StreamingAssetPath, _toLoad);
            PlayerHandler.Name = _toLoad;
            PlayerHandler.transform.position = Game.Player.Position;
            PlayerHandler.Xp = Game.Player.Xp;
            PlayerHandler.Pv = Game.Player.Pv;
            PlayerHandler.Level = Game.Player.Level;
            PlayerHandler.MaxLevelXp = Game.Player.MaxLevelXp;
            
        }

    }
}
