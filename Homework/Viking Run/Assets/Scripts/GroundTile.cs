using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    float groundTileAngle;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        groundTileAngle = groundSpawner.angle;
        if (Random.Range(0, 100) <= 20)
        {
            if (Random.Range(0, 100) <= 50 && groundSpawner.ObstacleSpawnCooldown >= 5)
            {
                SpawnObstacle();
                groundSpawner.ObstacleSpawnCooldown = 0;
            }
            else
                SpawnCoin();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 10);
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        Transform spawnPoint = transform.GetChild(2).transform;

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.Euler(0, groundTileAngle, 0), transform);
    }

    public GameObject coinPrefab;

    void SpawnCoin()
    {
        Transform spawnPoint = transform.GetChild(Random.Range(3, 5)).transform;

        Instantiate(coinPrefab, spawnPoint.position, Quaternion.Euler(0, groundTileAngle, 0), transform);
    }
    
}
