using Serializable;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Monobehaviours
{
    public class PauseScript : MonoBehaviour
    {
        [SerializeField] private GameObject pause_panel;
        [SerializeField] private GameObject save_panel;
        [SerializeField] private GameObject game_panel;
        [SerializeField] private GameHandler GameHandler;

        /*private Weapon Weapon;
        private Achievements Achievements;*/
        
        private void Start()
        {
            Time.timeScale = 1;
            pause_panel.SetActive(false); 
            save_panel.SetActive(false);
            game_panel.SetActive(true);
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!pause_panel.activeInHierarchy)
                {
                    PauseGame();
                }
                else
                {
                    Resume();
                }
            }
        }

        public void Menu()
        {
            SceneManager.LoadScene("Menu");
        }

        private void PauseGame()
        {
            Time.timeScale = 0;
            game_panel.SetActive(false);
            pause_panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        private void Resume()
        {
            Time.timeScale = 1;
            pause_panel.SetActive(false);
            game_panel.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        public void Save()
        {
            pause_panel.SetActive(false);
            save_panel.SetActive(true);
        }

        public void Ok()
        {
            GameHandler.Save();
            save_panel.SetActive(false);
            pause_panel.SetActive(true);
        }

        public void Back()
        {
            save_panel.SetActive(false);
            pause_panel.SetActive(true);
        }
        
    }
}
