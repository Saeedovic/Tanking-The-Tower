using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployBoulders : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public int randMin;
    public int randMax;
    private Vector2 screenBounds;
    private float respawnTime;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(AsteroidWave());
    }
    private void SpawnEnemy()
    {
        respawnTime = Random.Range(randMin, randMax);
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -3, Random.Range(-screenBounds.y, screenBounds.y));
        a.gameObject.tag = "Boulder";
    }
    IEnumerator AsteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }
    }
}
