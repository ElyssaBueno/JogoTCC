using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private AudioController _audioController;
    private UIManager _uiManager;
    // Start is called before the first frame update
    void Start()
    {
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        _audioController = GameObject.Find("SoundEffects").GetComponent<AudioController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            _audioController.playSound(1);
           
            _uiManager.gotPoint();
            Destroy(this.gameObject);


            

            
        }
    }
}
