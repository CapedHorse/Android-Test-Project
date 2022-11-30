using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CapedHorse.AndroidTest
{
    public class TestButton : MonoBehaviour
    {
        public TextMeshProUGUI testSceneName;
        public Button loadTestSceneButton;

        public void Init(string scene)
        {
            testSceneName.text = scene;
            loadTestSceneButton.onClick.AddListener(() =>
            {
                MainManager.instance.LoadScene(scene);
            });
        }
    }
}

