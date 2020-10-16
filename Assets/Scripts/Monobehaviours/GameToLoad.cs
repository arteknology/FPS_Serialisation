using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Serializable;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Monobehaviours
{
    public class GameToLoad : MonoBehaviour
    {
        public static Dictionary<string, Game> dict = new Dictionary<string, Game>();
        public static bool Clicked;
        public static string ToLoad;
        
        [SerializeField] private GameObject _button; 

        private void Start()
        {
            Clicked = false;
            GameObject parentObj = GameObject.Find("LoadGamePanel");
            string[] files = DataHandler.GetFilesInPath(UnityDirectory.StreamingAssetPath);
            foreach (string s in files)
            {
                if (dict.ContainsKey(s) == false)
                {
                    dict.Add(s, new Game());
                }
                GameObject instantiate = Instantiate(_button, parentObj.transform);
                string buttonText = Path.GetFileName(s);
                instantiate.GetComponentInChildren<Text>().text = buttonText;
                instantiate.GetComponent<Button>().onClick.AddListener(delegate
                {
                    ToLoad = buttonText;
                    Clicked = true;
                    SceneManager.LoadScene("Game");
                });
            }
        }


        // Update is called once per frame
        private void Update()
        {
        
        }
    }
}
