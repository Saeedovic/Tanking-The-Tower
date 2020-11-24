using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag == "Boulder")
        {
            Destroy(this.gameObject);
        }
    }
}
