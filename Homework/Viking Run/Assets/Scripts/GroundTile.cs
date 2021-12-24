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
        if (Random.Range(0, 100) <= 40)
        {
            if (groundSpawner.ObstacleSpawnCooldown >= 5 && groundSpawner.TurningTileSpawnCooldown != 0)
            {
                SpawnObstacle();
                groundSpawner.ObstacleSpawnCooldown = 0;
            }
        }
        if (Random.Range(0, 100) <= 50)
        {
            if (groundSpawner.ObstacleSpawnCooldown != 0)
            {
                SpawnCoin();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 10);
    }

    public GameObject obstaclePrefab_crossbar;
    public GameObject obstaclePrefab_pillar;

    void SpawnObstacle()
    {
        if (Random.Range(0, 100) <= 50)
        {
            Transform spawnPoint = transform.GetChild(2).transform;
            Instantiate(obstaclePrefab_crossbar, spawnPoint.position, Quaternion.Euler(0, groundTileAngle, 0), transform);
        }
        else
        {
            Transform spawnPoint = transform.GetChild(Random.Range(2, 5)).transform;
            Instantiate(obstaclePrefab_pillar, spawnPoint.position, Quaternion.Euler(0, groundTileAngle, 0), transform);
        }

    }

    public GameObject coinPrefab;

    void SpawnCoin()
    {
        Transform spawnPoint = transform.GetChild(Random.Range(5, 7)).transform;

        Instantiate(coinPrefab, spawnPoint.position, Quaternion.Euler(0, groundTileAngle, 0), transform);
    }
    
}
