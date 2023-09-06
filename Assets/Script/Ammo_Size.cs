using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ammo_Size : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text reloadSizeTxt;
    private int ammoSize;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        reloadSizeTxt.text = $"{GetComponent<Reload>().Ammo}/8";
    }

}
