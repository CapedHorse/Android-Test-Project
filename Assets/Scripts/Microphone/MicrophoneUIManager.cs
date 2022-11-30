using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CapedHorse.AndroidTest
{
    public class MicrophoneUIManager : MonoBehaviour
    {
        public static MicrophoneUIManager instance;
        public Button recordButton, stopRecordButton, playButton;

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
            recordButton.onClick.AddListener(() =>
            {
                OnUIRecording(true);
                RecorderManager.instance.Record();
            });

            stopRecordButton.onClick.AddListener(() =>
            {
                OnUIRecording(false);
                RecorderManager.instance.StopRecord();
            });

            playButton.onClick.AddListener(() =>
            {
                AudioPlayerManager.instance.PlayRecorded();
            });

            OnUIRecording(false);
        }

        public void OnUIRecording(bool on)
        {
            stopRecordButton.gameObject.SetActive(on);
            recordButton.gameObject.SetActive(!on);
            playButton.interactable = !on;
            if(on)AudioPlayerManager.instance.StopPlay();
        }
    }
}

