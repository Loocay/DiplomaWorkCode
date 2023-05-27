using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpCamera;
    [SerializeField] float zoomedOutFOV = 40f;
    [SerializeField] float zoomedInFOV = 20f;

    bool zoomState = false;

    private void OnDisable()
    {
        ZoomOut();
    }

    public void Zoom(bool zoomedIn)
    {
        fpCamera.m_Lens.FieldOfView = zoomedIn ? zoomedInFOV : zoomedOutFOV;
    }

    void update()
    {
        if(Input.GetMouseButtonDown(1)) 
        {
            if(zoomState == false)
            {
                ZoomIn();
            }

            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomOut()
    {
        zoomState = false;

        fpCamera.m_Lens.FieldOfView = zoomedOutFOV;
    }

    private void ZoomIn()
    {
        zoomState = true;

        fpCamera.m_Lens.FieldOfView = zoomedInFOV;
    }
}
