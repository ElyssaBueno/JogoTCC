using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
   
    private AudioClip _clip;
    private UIManager _uiManager;
    private AudioSource _audioSource;
   
    // Start is called before the first frame update
    void Start()
    { 
        _audioSource = GetComponent<AudioSource>();
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void playSound(int id)
    {
        //Carrega o Audio correspondente na pasta Resources de acordo com o arquivo de texto e o id 
       if(id == 0) {
            _clip = (Resources.Load<AudioClip>(_uiManager.analise.text+"Jump"));
        }
       if (id == 1)
       {
            _clip = (Resources.Load<AudioClip>(_uiManager.analise.text + "Cherry"));
       }
        if (id == 2)
        {
            _clip = (Resources.Load<AudioClip>(_uiManager.analise.text + "Destroy"));
        }

        _audioSource.clip = _clip;
        _audioSource.Play();
    
    }
}
