using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //vars at top
    /*
    multi line support
    */

    public int fuel = 100;
    public int laps;
    public float lapProgress;
    public float reqLapProgress = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* every frame: check how much fuel we have - if we have more than 0 fuel continue going
                        increase our progress, and decrease our fuel
                        if our lap progress, is less than required, do nothing, else, increase lap by 1, reset progress to 0
        */

        if (fuel > 0)
        {
            //we have fuel
            lapProgress += 5;
            fuel --;


        }
        else
        {
            //we have no fuel
            Debug.Log("We've run out of fuel");
        }
        
        if (lapProgress >= reqLapProgress)
            {
                laps++;
                lapProgress = 0;
            }
        Debug.Log ("Current Fuel:" + fuel);
        Debug.Log ("Completed Laps" + laps );
    }
}
