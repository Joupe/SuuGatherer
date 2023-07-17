using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerrySpawner : MonoBehaviour
{
    float minX = -8;
    float minY = 5;
    float maxX = 8;
    float maxY = 6;
    float randomX;
    float randomY;

    // Start is called before the first frame update
    void Start()
    {
        randomX = Random.Range(minX, maxX);
        randomY = Random.Range(minY, maxY);
        gameObject.transform.position = new Vector2(randomX, randomY);
    }

    void FixedUpdate()
    {
        if (gameObject.transform.position.y < -3.5)
        {
            Destroy(gameObject);
        }
    }

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Destroy(gameObject);
    //}

}
