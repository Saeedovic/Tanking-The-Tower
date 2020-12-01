using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulders : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public int score;
    private ParticleSystem particles;
    public GameObject myPrefab;
    PHYSICS playerScript;
    void Start()
    {
        particles = this.GetComponent<ParticleSystem>();
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PHYSICS>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < screenBounds.x)
        {
            Destroy(this.gameObject);
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Instantiate(myPrefab, this.transform.position, Quaternion.identity);
            Destroy(myPrefab.gameObject, 2);
            Destroy(this.gameObject);        }
        if(collision.gameObject.tag == "Missle")
        {
            Instantiate(myPrefab, this.transform.position, Quaternion.identity);
            Destroy(myPrefab.gameObject, 2);
            Destroy(this.gameObject);
            playerScript.ScoreIncrement();
        }

    }

}
