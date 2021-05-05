using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoints : MonoBehaviour
{
    [SerializeField]
    private string[] increasePointTag, decreasePointTag;
    [SerializeField]
    private int[] increasePoint, decreasePoint;
    private int index=0;
    private void OnTriggerEnter(Collider other)
    {
        index = 0;
        foreach (string pointTag in increasePointTag)
        {
            if (other.tag == pointTag)
            {
                BuildScr.bonusScore += increasePoint[index];
                index = 0;
                break;
            }
            index++;
        }
        index = 0;
        foreach (string pointTag in decreasePointTag)
        {
            if (other.tag == pointTag)
            {
                BuildScr.bonusScore -= decreasePoint[index];
                index = 0;
                break;
            }
            index++;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        index = 0;
        foreach (string pointTag in increasePointTag)
        {
            if (other.tag == pointTag)
            {
                BuildScr.bonusScore -= increasePoint[index];
                index = 0;
                break;
            }
            index++;
        }
        index = 0;
        foreach (string pointTag in decreasePointTag)
        {
            if (other.tag == pointTag)
            {
                BuildScr.bonusScore += decreasePoint[index];
                index = 0;
                break;
            }
            index++;
        }
    }
}
