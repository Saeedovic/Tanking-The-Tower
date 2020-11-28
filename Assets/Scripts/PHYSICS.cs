using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHYSICS : MonoBehaviour
{
    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Bullet_Emitter;
    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject missle;
    public int  spinspeed;
    public int  fastspin;
    public Rigidbody2D rb;
    public float forceMult;
    public int live;
    public GameObject explosionPrefab;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject bullet;
            bullet = Instantiate(missle, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
            Rigidbody2D bulletrb;
            bulletrb = bullet.GetComponent<Rigidbody2D>();
            bulletrb.velocity = transform.forward * Bullet_Forward_Force;
            Destroy(bullet, 10);

            rb.velocity = transform.forward * Time.deltaTime * -forceMult;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
        transform.Rotate(0, fastspin, 0 * Time.deltaTime);
        }
        else
        {
        transform.Rotate(0, spinspeed, 0 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boulder")
        {
            live -= 1;
            if (live == 0)
            {
                Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
                Destroy(explosionPrefab.gameObject, 2);
                Destroy(this.gameObject);
            }
        }
    }
}
