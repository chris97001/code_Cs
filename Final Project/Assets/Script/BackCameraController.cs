using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCameraController : MonoBehaviour
{
    public Cinemachine.CinemachineFreeLook BaseCam;
    public Cinemachine.CinemachineFreeLook ControlCam;
    // Update is called once per frame
    void Update()
    {
        if (ControlCam.Priority == 0)
        {
            ControlCam.m_XAxis.Value = BaseCam.m_XAxis.Value + 180f;
            ControlCam.m_YAxis.Value = BaseCam.m_YAxis.Value;
        }
        else
        {
            BaseCam.m_XAxis.Value = ControlCam.m_XAxis.Value + 180f;
            BaseCam.m_YAxis.Value = ControlCam.m_YAxis.Value;
        }
    }
}
