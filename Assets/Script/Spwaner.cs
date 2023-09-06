using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{

    public GameObject duckPrefab;
    public bool toogleVisibility;
    private bool isSpawned = false;


    private void Start()
    {
        if (toogleVisibility)
        {
            GetComponent<Renderer>().enabled = true;

        }
        else
        {
            GetComponent<Renderer>().enabled = false;
        }
    }

    void Update()
    {

        if (isSpawned == false)
        {
            Instantiate(duckPrefab, transform.position, Quaternion.identity);
            isSpawned = true;
        }
    }
}
