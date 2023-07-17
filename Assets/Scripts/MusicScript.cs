using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    [SerializeField]
    AudioClip music;
    
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.PlayMusic(music);
    }

    // Update is called once per frame
    void OnMouseUp()
    {
        SoundManager.instance.PauseMusic();
    }
}
