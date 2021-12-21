using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] Vector3 LookAt_offset;
    [SerializeField] float smoothSpeed = 0.125f;
    private void Start()
    {
        offset = new Vector3(0,3,-5);
        LookAt_offset = new Vector3(0,2.5f,0);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target.position+LookAt_offset);//rotate the camera
    }
}
