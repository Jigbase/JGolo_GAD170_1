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

    // Update is called once per frame (update = tick)
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            GainProgress(speed);
        }
    }
    public void GainProgress(float progress)
    { //add progress, to current lap progress and set it
        curLapProgress += progress;
        Debug.Log (" Gained " + progress + " progress ");
        Debug.Log(" Total current progress is " + curLapProgress);
        CheckProgress(curLapProgress);
    }
    public void CheckProgress(float progress)
    {//check progress against required progress, if its = or > than required, increment 'laps' variable
        if(progress>= reqLapProgress)
        {
            
            LapCompleted();
            laps ++;
            curLapProgress = 0.0f;
            Debug.Log(" reached the required progress ");
        }

    }
    public void LapCompleted()
    {//when lap is completed, reser current lap progress and do some thing additional (in this case I'm increasing the lap size)
        laps ++;
        curLapProgress = 0.0f;
        reqLapProgress *= 1.05f;

        Debug.Log(" Completed laps: " + laps);

        //update speed (ignor this)


        // *** THIS CODE AND FUNCTIONS CAN ALL BE USED TO DO AN XP AND LEVELLING SYSTEM ***
    }
}
