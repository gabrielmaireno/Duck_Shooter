using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class onClickHit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject duck;
    private AudioSource gunAudio;
    
    
    void Start()
    {
        gunAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        clickHandler(); // Chama o método para verificar o clique do mouse e chamar shot()
    }

    private void clickHandler()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(GetComponent<Reload>().Ammo > 0)
            {
                shot();
                if (hit() == true) {
                    Debug.Log("Vai TOmar no CU");
                }
            }
        }
        
    }

    void shot()
    {
        if (GetComponent<Reload>().Ammo >= 1)
        
        gunAudio.Play();
        GetComponent<Reload>().DecreaseAmmo();
    }
    private bool hit() {

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (duck.GetComponent<BoxCollider2D>().OverlapPoint(mousePosition) == true) { 
            
            return true;
        }
         
        return false;

    }
}   
