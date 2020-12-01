using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetgravity_destruction : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //used for objects that collided with main circle collider of the planet
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if the boulder game object collides with circle collider
        if (collision.gameObject.CompareTag("Boulder"))
        {
            //then destory boulder tag game object
            Destroy(collision.gameObject);
        }
    }
}
