using UnityEngine;
using UnityEngine.SceneManagement;

namespace Monobehaviours
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject loadGame_panel;
        [SerializeField] private GameObject main_panel;
        // Start is called before the first frame update
        void Start()
        {
            loadGame_panel.SetActive(false);
        }

        public void NewGameClick()
        {
            SceneManager.LoadScene("Game");
        }

        public void LoadGameClick()
        {
            main_panel.SetActive(false);
            loadGame_panel.SetActive(true);
        }
    
        public void GoBack()
        {
            if (loadGame_panel.activeInHierarchy)
            {
                loadGame_panel.SetActive(false);
                main_panel.SetActive(true);
            }
        }
    
        public void Quitt()
        {
            Application.Quit();
        }
        // Update is called once per frame

    }
}
