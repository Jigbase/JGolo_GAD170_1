using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour

{
    public GameObject fighterPrefab;
    public int teamSize = 3;
    public string[] fighterNames;
    public GameObject[] teamAFighters;
    public GameObject[] teamBFighters;

    // Start is called before the first frame update
    void Start()
    {
        //Create the teams before combat starts. We are changing the original variables through a function
        teamAFighters = CreateTeam(teamAFighters);
        teamBFighters = CreateTeam(teamBFighters);
        
        //pick a random character from each team
        GameObject randomA = teamAFighters[Random.Range(0, teamSize)];
        GameObject randomB = teamBFighters[Random.Range(0, teamSize)];
        Battle(randomA, randomB);
    }
    //set the teams based on the team size, and assign theme names from the name array
    public GameObject[] CreateTeam(GameObject[] incTeam)
    {
        incTeam = new GameObject[teamSize];
        for (int i = 0; i < teamSize; i++)
        {
            //gameobject gets saved as a local variable 'go' for faster typing. Our character gets instantiated as 'fighterPrefab'
            GameObject go = Instantiate(fighterPrefab);
            incTeam[i] = go;
            //we run the update name and init stats functions from our instantiated objects as they're created
            go.GetComponent<Character>().UpdateName(fighterNames[Random.Range(0, fighterNames.Length)]);
            go.GetComponent<Character>().InitStats();
        }
        return incTeam;
    }
    public void Battle(GameObject fighterA, GameObject fighterB)
    {
        int coinFlip = Random.Range (0, 2);
        Character fAStats = fighterA.GetComponent<Character>();
        Character fBStats = fighterB.GetComponent<Character>();
        if (coinFlip == 0)
        {
            fBStats.health -= fAStats.attack - fBStats.defense;
            Debug.Log("fighter A attacks fighter B, and fighter B's health is now:" + fBStats.health);
        }
        else
        {
            fAStats.health -= fBStats.attack - fAStats.defense;
            Debug.Log("fighter B attacks fighter A, and fighter A's health is now:" + fAStats.health);
        }
    }
}
