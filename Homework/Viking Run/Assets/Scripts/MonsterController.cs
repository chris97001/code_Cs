using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public bool isCaught = false;
    public void catchPlayer()
    {
        isCaught = true;
        transform.localPosition = new Vector3(0,0,-6);
    }

    public void PlayerFall()
    {
        isCaught = true;
        transform.localPosition = new Vector3(0,0,-30);
    }
}
