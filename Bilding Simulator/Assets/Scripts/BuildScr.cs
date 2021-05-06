using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Drawing;

public class BuildScr : MonoBehaviour
{
    public Transform[] original, mask;
    private Transform tmp_original, tmp_mask;
    private Vector3 curPos;
    private float shift = 0.01f;
    public static bool canBuild = false;
    static public int bonusScore, allPoint;
    [SerializeField]
    private Text addPointTxt, PointTxt;

    public void SetMask(int id)
    {
        if (tmp_mask != null)
            Destroy();
        tmp_original = Instantiate(original[id]);
        tmp_original.gameObject.SetActive(false);
        tmp_mask = Instantiate(mask[id]);
    }
    private void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            curPos = hit.point + hit.normal * shift;
        }

        if (tmp_mask)
        {
            tmp_mask.position = curPos;
            if (Input.GetMouseButtonDown(0) && canBuild)
            {
                allPoint += bonusScore;
                PointTxt.text = allPoint.ToString();
                bonusScore = 0;
                tmp_original.gameObject.SetActive(true);
                tmp_original.position = tmp_mask.position;
                tmp_original.localEulerAngles = tmp_mask.localEulerAngles;
                tmp_original = null;
                Destroy(tmp_mask.gameObject);
            }
            else if (Input.GetMouseButtonDown(2))
            {
                Destroy();
            }
            else if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                tmp_mask.localEulerAngles += new Vector3(0, 22.5f, 0);
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                tmp_mask.localEulerAngles -= new Vector3(0, 22.5f, 0);
            }
            addPointTxt.text = bonusScore.ToString();
        }
    }
    private void Destroy()
    {
        Destroy(tmp_original.gameObject);
        Destroy(tmp_mask.gameObject);
    }
}
