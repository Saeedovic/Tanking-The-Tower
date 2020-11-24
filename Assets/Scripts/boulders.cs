using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulders : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public int score;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < screenBounds.x)
        {
            Destroy(this.gameObject);
        }
        Debug.Log(score);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            new WaitForSeconds(0.1f);
            Destroy(this.gameObject);
        }

        if(collision.gameObject.tag == "Missle")
        {
            Destroy(this.gameObject);
            AddPoints();
        }
    }

    void AddPoints()
    {
        score++;
    }

}
