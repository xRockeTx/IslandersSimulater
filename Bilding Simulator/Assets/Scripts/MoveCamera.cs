using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveCamera : MonoBehaviour
{
    Quaternion originRot,rotationY, rotationX;
    private float angleVertical, angleHorisontal,mouseSens=4f;
    private void Start()
    {
        originRot = transform.rotation;
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            angleHorisontal += Input.GetAxis("Mouse X") * mouseSens;
            angleVertical -= Input.GetAxis("Mouse Y") * mouseSens;
            rotationY = Quaternion.AngleAxis(angleHorisontal, Vector3.up);
            rotationX = Quaternion.AngleAxis(angleVertical, Vector3.right);
            transform.rotation = originRot * rotationY * rotationX;
        }
    }
}
