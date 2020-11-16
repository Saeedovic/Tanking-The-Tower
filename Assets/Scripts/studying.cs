using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studying : MonoBehaviour
{
    public Rigidbody rb;
    public float forceMult;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {

        }
    }

    void Launch()
    {
        rb.velocity = transform.forward * Time.deltaTime * -forceMult;
    }
}
