using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    //private UIManager _uiManager;
    private AudioClip _music;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //_uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        // _music = GetComponent<AudioClip>();
        _audioSource = GetComponent<AudioSource>();
        _music = Resources.Load<AudioClip>(StaticClass.id.ToString());  

        playMusic();
        //Debug.Log(StaticClass.id.ToString());
        //Debug.Log(_music.name);
        
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
