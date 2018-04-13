using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doorrise : MonoBehaviour
{

    public float updistance = 0;
    
    // Use this for initialization
    void Start()
    {
        

    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.collider.tag != "LightOrb") return;
        transform.Translate(0, updistance, 0);

    }
    
}
