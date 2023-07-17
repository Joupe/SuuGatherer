using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SuuScripts : MonoBehaviour
{
    public TextMeshProUGUI berryScore;
    public TextMeshProUGUI encScreenCount;
    int berries;

    void Start()
    {
        berries = 0;
        berryScore.text = "Berries: " + berries.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Berry")
        {
            Destroy(collision.gameObject);
            berries = berries + 1;
            berryScore.text = "Berries: " + berries.ToString();
            encScreenCount.text = berries.ToString();
        }
    }

}
