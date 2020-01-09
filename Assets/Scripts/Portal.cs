using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
   // [SerializeField] private Transform _player;
    [SerializeField] private Transform _portal;

    void OnTriggerEnter2D(Collider2D other)
    {

        other.transform.position = _portal.transform.position;
    }
}
