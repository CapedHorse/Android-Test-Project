using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CapedHorse.AndroidTest
{
    [CreateAssetMenu(fileName = "Scene Data", menuName = "Scene Data")]
    public class SceneData : ScriptableObject
    {
        public List<string> scenes;
    }
}

