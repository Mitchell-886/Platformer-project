using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Transform cam;
    Vector3 previousCamPos;
    public float parallaxScale;

    void Start()
    {
        cam = Camera.main.transform;
        previousCamPos = cam.transform.position;
    }

    void Update()
    {
        float parallax = (previousCamPos.x - cam.position.x) * parallaxScale;
        Vector3 pos = transform.position;
        pos.x += parallax;
        transform.position = pos;
        previousCamPos = cam.position;
    }
}
