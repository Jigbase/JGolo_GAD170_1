using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XP_System : MonoBehaviour
{
    // level stats (altered during gameplay)
    public int level;
    public int curXP;
    public int reqXP;

    //character stats (change with level)
    public float maxHealth;
    public float curHealth;
    public int def;
    public float speed;
    public int atk;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InitStats(float maxHealth, int def, float speed, int atk, int level, int reqXP)
    {
        maxHealth = 120.0f;
        curHealth = maxHealth;
        def = Random.Range(1, 4);
        speed = Random.Range(1.0f, 1.4f);
        atk = Random.Range(1, 3);
        level = 1;
        reqXP = 110;

    }
    public void Interaction(int exp)
    {

    }
    public void GainXP(int amount)
    {

    }
    public void LevelUp()
    {

    }
    public void IncreaseStats()
    {
        
    }
}
