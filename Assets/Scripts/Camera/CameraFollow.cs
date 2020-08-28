using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public Vector2 offset = new Vector2(10f, 10f);
    public float followSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(
            transform.position,
            new Vector3(target.position.x + offset.x, target.position.y + offset.y, transform.position.z),
            Time.deltaTime * followSpeed
            );
    }
}
