using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studying : MonoBehaviour
{
    bool heyyo;

    void Start()
    {
        heyyo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            heyyo = true;
        }
    }

    private void FixedUpdate()
    {
        if (heyyo == true)
        {

        }
    }

}
