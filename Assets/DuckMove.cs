using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMove : MonoBehaviour
{
    public float timerMultiplicator = 1f;
    public float moveSpeed = 5f;
    float timer = 0f;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        switch (direction) {
            case 0:

                if (timer < 1f * timerMultiplicator) {
                    transform.position = transform.position + (Vector3.left  * moveSpeed) * Time.deltaTime;
                }
                else
                {
                    direction = 1;
                    timer = 0f;
                }
                break;

            case 1:
                if (timer < 1f * timerMultiplicator)
                {
                    transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;

                }
                else
                {
                    direction = 0;
                    timer = 0f;
                }
                break;
                
    
    
        }
        
    }
}
