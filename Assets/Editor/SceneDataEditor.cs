using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CapedHorse.AndroidTest
{
    [CustomEditor(typeof(SceneData))]
    public class SceneDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var sceneData = target as SceneData;
            sceneData.scenes.Clear();

            var sceneNames = AssetDatabase.FindAssets("t:Scene", new string[] { "Assets/Scenes/ContentScenes" });
            foreach (var item in sceneNames)
            {
                var scenePath = AssetDatabase.GUIDToAssetPath(item);
                var scene = AssetDatabase.LoadAssetAtPath<Object>(scenePath);
                sceneData.scenes.Add(scene.name);
            }
            
            EditorUtility.SetDirty(target);
        }
    }
}

