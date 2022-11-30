using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CapedHorse.AndroidTest
{
    public class MainMenuManager : MonoBehaviour
    {
        public static MainMenuManager instance;
        public TestButton testButtonPrefab;
        public Transform testButtonsParent;
        public List<TestButton> testButtons;


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

        private void Start()
        {
            foreach (var item in MainManager.instance.sceneData.scenes)
            {
                var testBtn = Instantiate(testButtonPrefab, testButtonsParent);
                testBtn.Init(item);
                testButtons.Add(testBtn);
            }
        }


    }
}

