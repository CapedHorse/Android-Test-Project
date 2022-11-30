using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CapedHorse.AndroidTest
{
    public class AudioPlayerManager : MonoBehaviour
    {
        public static AudioPlayerManager instance;
        public AudioSource audioSource;

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

        public void PlayRecorded()
        {
            if (RecorderManager.instance.recorded != null)
            {
                audioSource.PlayOneShot(RecorderManager.instance.recorded);
            }
        }

        public void StopPlay()
        {
            audioSource.Stop();
        }

    }
}

