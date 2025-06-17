using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    [SerializeField] private AudioClip specialClip;

    private int pelletCount = 0;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pellet"))
        {
            Destroy(other.gameObject);
            pelletCount++;

            if (pelletCount == 3)
            {
                PlaySpecialSound();
            }
        }
    }

    private void PlaySpecialSound()
    {
        audioSource.PlayOneShot(specialClip);
    }
}
