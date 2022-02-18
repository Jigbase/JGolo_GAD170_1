using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{
    public int laps = 0;
    public float curLapProgress = 0.0f;
    public float reqLapProgress = 100.0f;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            GainProgress(speed);
        }
    }
    public void GainProgress(float progress)
    {
        curLapProgress += progress;
        Debug.Log (" Gained " + progress + " progress ");
        Debug.Log(" Total current progress is " + curLapProgress);
        CheckProgress(curLapProgress);
    }
    public void CheckProgress(float progress)
    {
        if(progress>= reqLapProgress)
        {
            
            LapCompleted();
            laps ++;
            curLapProgress = 0.0f;
            Debug.Log(" reached the required progress ");
        }

    }
    public void LapCompleted()
    {
        laps ++;
        curLapProgress = 0.0f;
        reqLapProgress *= 1.05f;

        Debug.Log(" Completed laps: " + laps);

        //update speed
    }
}
