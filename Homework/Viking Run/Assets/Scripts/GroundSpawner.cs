using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    public Transform spawnPosition;
    Vector3 nextSpawnPoint;
    int spawnCount;
    float[] rotation = { -90f, 90f };
    float angle;
    public void SpawnTile()
    {
        spawnCount++;
        if (spawnCount >= 15)
        {
            if (Random.Range(0,100)<=20)
            {
                spawnCount = 0;
                angle += rotation[Random.Range(0,rotation.Length)];
                if (angle >= 360)
                {
                    angle -= 360;
                }
                else if (angle < 0)
                {
                    angle += 360;
                }
            }
        }
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.Euler(0, angle, 0));
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    private void Start()
    {
        nextSpawnPoint = spawnPosition.position;
        for(int i = 0; i < 30; i++)
        {
            SpawnTile();
            spawnCount = 0;
        }
    }
}
