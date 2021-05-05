using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTag : MonoBehaviour
{
    public string BuildTag;
    private void Start()
    {
        BuildTag = this.tag;   
    }
}
