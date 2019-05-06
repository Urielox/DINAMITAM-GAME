using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    private bool smoot = true;
    public float smoothSpeed = 0.125f;
    public Vector3 offSet = new Vector3(0, 0, -10);
    private Transform lookAt;

    private void Start()
    {
        lookAt = player;
    }

    private void FixedUpdate()
    {
        Vector3 desiredPosition = lookAt.transform.position + offSet;
        if (smoot)
        {
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        }
    }
}
