using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    public Reload ammo;
    private bool isShooted = false;

    private void Update()
    {
        isShooted = false;
    }

    private void OnMouseDown()
    {
        int s2 = ammo.GetComponent<Reload>().Ammo;

        if(s2 > 0)
        { 

        isShooted = true;
        Debug.Log("funcionou");
        
        }
    }

}
