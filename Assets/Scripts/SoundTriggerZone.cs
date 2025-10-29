using UnityEngine;

public class SoundTriggerZone : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sound.Play();
        }
    }
}