using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour {

    public float parallaxSpeed = 0.5f;
    public Vector2 offset = new Vector2(0, 0);
    public Transform camera;

    private void Start()
    {
    }

    private void LateUpdate()
    {
        var lerpTo = new Vector3(camera.position.x + offset.x, camera.position.y + offset.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, lerpTo, parallaxSpeed * Time.deltaTime);
    }
}