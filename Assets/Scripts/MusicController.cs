using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    private AudioClip _music;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {

        _audioSource = GetComponent<AudioSource>();
        _music = Resources.Load<AudioClip>(StaticClass.id.ToString());  

        playMusic();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void playMusic()
    {
        _audioSource.clip = _music;
        _audioSource.Play();
    }
}
