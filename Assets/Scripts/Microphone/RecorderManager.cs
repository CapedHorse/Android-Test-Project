using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microphone = UnityEngine.Microphone;


namespace CapedHorse.AndroidTest
{
    public class RecorderManager : MonoBehaviour
    {
        public static RecorderManager instance;
        public AudioClip recorded;
        bool recording;
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

            //foreach (var item in Microphone.devices)
            //{
            //    Debug.Log(item);
            //}
        }

        public void Record()
        {
            recorded = Microphone.Start(Microphone.devices[0], true, 999, 44100);

        }

        private void Update()
        {
            
        }

        public void StopRecord()
        {
            Microphone.End(Microphone.devices[0]);
        }

    }
}

