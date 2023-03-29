using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    // Reference initialization
    public Camera mainCamera;

    // Game code, executed once per frame or more
    void Update()
    {
        Vector3 pos = mainCamera.transform.position;
    }
}
