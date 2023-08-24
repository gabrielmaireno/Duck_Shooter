using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
        clickHandler();
    }

    private void clickHandler() {
        if (Input.GetMouseButtonDown(0)) {
            shot();
            gunAudio.Play();
        }
    }

    void shot()
    {
       
    }
}
