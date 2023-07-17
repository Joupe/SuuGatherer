using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField]
    GameObject cloud;
    [SerializeField]
    GameObject blue;
    [SerializeField]
    GameObject cow;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 0.5f);
    }

    // Update is called once per frame
    void Spawn()
    {
        float rX = Random.Range(-5, 5);
        float rY = Random.Range(2, 8);
        Instantiate(cloud, new Vector2(rX, rY), Quaternion.identity);
        Instantiate(blue, new Vector2(rX, rY), Quaternion.identity);
        Instantiate(cow, new Vector2(rX, rY), Quaternion.identity);
    }
}
