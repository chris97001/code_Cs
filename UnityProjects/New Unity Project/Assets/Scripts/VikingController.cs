using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VikingController : MonoBehaviour
{
    public Vector3 MovingDirection;
    [SerializeField] float movingSpeed = 10f;
    [SerializeField] float jumpingSpeed = 10f;
    Transform t;
    MeshRenderer mr;
    bool jumping=false;
    int height = 0;
    private void Awake()
    {
        Debug.Log("awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        t = GetComponent<Transform>();
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (jumping)
        {
            if (height >= 500)
            {
                height = 0;
                jumping = false;
                Debug.Log("jumping done");
            }
            else
            {
                height++;
                transform.localPosition += jumpingSpeed * Time.deltaTime * Vector3.up;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if(!jumping)
                jumping = true;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.down;
        }
    }
}
