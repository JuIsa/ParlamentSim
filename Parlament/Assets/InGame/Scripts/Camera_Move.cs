using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 _offset;

    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.5f;
    void Start()
    {
        _offset = transform.position - playerTransform.position;
    }

    void Update()
    {
        Vector3 newPos = playerTransform.position + _offset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
    }
}
