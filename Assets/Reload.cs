using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using System.Threading;




public class Reload : MonoBehaviour
{

    // Start is called before the first frame update
    public int Ammo { get; set; }
    public TMP_Text reloadTxt;
    int horaTermino;
    public bool isReloading = false;
    private float reloadStartTime;
    private float reloadCooldown = 2.5f;


    void Start()
    {
        Ammo = 8;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && !isReloading)
        {
            StartReload();
        }

        if (isReloading)
        {
            if (Time.time - reloadStartTime >= reloadCooldown)
            {
                CompleteReload();
                IncreaseAmmo();
            }
        }
    }

    public void DecreaseAmmo()
    {
        Ammo = Ammo - 1;
    }
    public void IncreaseAmmo()
    {  
        Ammo = Ammo + 8;
    }
    void StartReload()
    {
        isReloading = true;
        reloadStartTime = Time.time;
        Debug.Log("Recarregando...");
        reloadTxt.text = "Recarregando...";


}

    void CompleteReload()
    {
        isReloading = false;
        Debug.Log("Recarregamento completo!");
        reloadTxt.text = "";
    }
}

