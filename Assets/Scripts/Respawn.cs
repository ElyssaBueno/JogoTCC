using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _respawnPoint;
    private AudioController _audioController;
    void Start()
    {
        _audioController = GameObject.Find("SoundEffects").GetComponent<AudioController>();
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _audioController.playSound(2);
            _player.transform.position = _respawnPoint.transform.position;
        }
    }
}
