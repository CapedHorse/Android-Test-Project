using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CapedHorse.AndroidTest
{
    public class MainManager : MonoBehaviour
    {
        public static MainManager instance;
        public SceneData sceneData;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
                return;
            }
        }

        public void LoadScene(string name)
        {
            SceneManager.LoadScene(name);
            LoadUIScene();
        }

        public void LoadUIScene()
        {
            SceneManager.LoadScene("MainUIScene", LoadSceneMode.Additive);
        }

        public void BackToMenu()
        {
            Debug.Log("Back To Menu");
            SceneManager.LoadScene("MainMenuScene");
            //SceneManager.UnloadSceneAsync("MainUIScene");
        }
    }
}

