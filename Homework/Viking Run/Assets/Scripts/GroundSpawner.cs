using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    public GameObject groundTile_hole;
    public Transform spawnPosition;
    Vector3 nextSpawnPoint;
    public int TurningTileSpawnCooldown;
    public int ObstacleSpawnCooldown;
    float[] rotation = { -90f, 90f };
    public float angle;
    public void SpawnTile()
    {
        TurningTileSpawnCooldown++;
        ObstacleSpawnCooldown++;

        //Spawn turning tile
        if (TurningTileSpawnCooldown >= 15)
        {
            if (Random.Range(0,100)<=20)
            {
                TurningTileSpawnCooldown = 0;
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
        GameObject temp;
        if (Random.Range(0, 100) <= 10 && TurningTileSpawnCooldown!=0 && ObstacleSpawnCooldown>=5)
            temp = Instantiate(groundTile_hole, nextSpawnPoint, Quaternion.Euler(0, angle, 0));
        else
            temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.Euler(0, angle, 0));


        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    private void Start()
    {
        nextSpawnPoint = spawnPosition.position;
        for(int i = 0; i < 30; i++)
        {
            TurningTileSpawnCooldown = 0;
            SpawnTile();
        }
    }
}
