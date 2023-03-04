using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int timeForLevelToComplete = 60;

    private void Start()
    {
        StartCoroutine("Timer");
    }
    IEnumerator Timer()
    {
        int tempTime = timeForLevelToComplete;
        while(tempTime>0)
        {
            tempTime--;
            yield return new WaitForSeconds(1);
        }
        //GAME OVER
        GameManager.instance.GameOver();
    }
}
