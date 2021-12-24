using UnityEngine;

public class CoinController : MonoBehaviour
{
    public PlayerController playerController;
    public AudioSource audioSource;
    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        audioSource = GameObject.Find("CoinSoundEffect").GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        playerController.CoinCount++;
        Destroy(gameObject);
    }
}
