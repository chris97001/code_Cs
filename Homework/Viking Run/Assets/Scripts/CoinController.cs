using UnityEngine;

public class CoinController : MonoBehaviour
{
    public PlayerController playerController;
    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        playerController.CoinCount++;
        Destroy(gameObject);
    }
}
