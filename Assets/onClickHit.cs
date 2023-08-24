using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class onClickHit : MonoBehaviour
{
    // Start is called before the first frame update
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
                
            }
        }
        
    }

    void shot()
    {
        if (GetComponent<Reload>().Ammo >= 1)
        // Coloque aqui a lógica para o efeito do disparo
        gunAudio.Play(); // Isso reproduzirá o áudio associado ao AudioSource
        GetComponent<Reload>().DecreaseAmmo();
    }
}
