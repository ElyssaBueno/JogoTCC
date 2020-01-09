using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float _speed = 3f, _max, _min;
    private bool _moveR = true;
    [SerializeField] private bool _horizontal = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_horizontal == true) { 
            if (transform.position.x > _max)
            {
                _moveR = false;
            }
            else if (transform.position.x < _min)
            {
                _moveR = true;
            }

            if (_moveR)
            {
                transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime, transform.position.y);
            }
            else
            {
                transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);
            }
        }

        else if (_horizontal == false)
        {
            if (transform.position.y > _max)
            {
                _moveR = false;
            }
            else if (transform.position.y < _min)
            {
                _moveR = true;
            }

            if (_moveR)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + _speed * Time.deltaTime);
            }
            else
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - _speed * Time.deltaTime);
            }
        }
    }
}
