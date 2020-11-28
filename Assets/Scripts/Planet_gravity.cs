using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_gravity : MonoBehaviour
{
    public List<GameObject> gravitylist;
    public float gravityScale;
    Vector2 dir;
    void Start()
    {
        
    }

    void Update()
    {
        for (int i = 0; i < gravitylist.Count; i++)
        {
            dir = (gravitylist[i].transform.position - this.transform.position).normalized * gravityScale;
        }
    }

    public void FixedUpdate()
    {
        for (int i = 0; i < gravitylist.Count; i++)
        {
            gravitylist[i].transform.position = Vector2.MoveTowards(gravitylist[i].transform.position, this.transform.position, gravityScale);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gravitylist.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gravitylist.Remove(collision.gameObject);

    }
}
