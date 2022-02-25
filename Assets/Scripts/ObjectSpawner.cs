using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefab;

    public int amountToSpawn = 1;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amountToSpawn; i++)
        {
            //spawn object at location
            Vector3 pos = new Vector3(  transform.position.x + Random.Range(-20f, 20f),
                                        transform.position.y,
                                        transform.position.z + Random.Range(-20f, 20f));

            //transform.(setting) sets transform location of object's editor location
            Instantiate(prefab, pos, transform.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}