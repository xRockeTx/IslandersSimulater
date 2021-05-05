using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField]
    private Transform cameraTransform;
    private void OnMouseDown()
    {
        cameraTransform.position = new Vector3(transform.position.x, transform.position.y + transform.localScale.y ,transform.position.z);   
    }
}
