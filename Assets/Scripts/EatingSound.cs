using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingSound : MonoBehaviour
{
    [SerializeField]
    AudioClip sound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Berry")
        {
            SoundManager.instance.PlaySingle(sound);
        }
    }

}
