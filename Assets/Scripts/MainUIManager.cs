using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CapedHorse.AndroidTest
{
    public class MainUIManager : MonoBehaviour
    {
        public static MainUIManager instance;
        public Button backToMenuButton;


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

        void Start()
        {
            backToMenuButton.onClick.AddListener( () =>
            {
                Debug.Log("Clicked Back to Menu");
                MainManager.instance.BackToMenu();
            });
        }

        
    }
}

