using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTriggerZone : MonoBehaviour
{
    public AudioSource music;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (music.isPlaying)
            {
                music.Pause();
            }
            else
                music.UnPause();
        }
    }
}