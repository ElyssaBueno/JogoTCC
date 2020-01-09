using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private float _speed = 3f, _max, _min;
    [SerializeField] private Transform _respawnPoint;
    private bool _moveR = true;
    private AudioController _audioController;
    // Start is called before the first frame update
    void Start()
    {
        _audioController = GameObject.Find("SoundEffects").GetComponent<AudioController>();
        Flip();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > _max)
        {
            Flip();
            _moveR = false;
            
            
        }
        else if (transform.position.x < _min)
        {
            Flip();
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
    void Flip()
    {
      
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (other.transform.position.y > this.gameObject.transform.position.y)
            {
                
                other.rigidbody.AddForce(new Vector2(0, 400));
                Destroy(this.gameObject);
            }
            else {
                other.transform.position = _respawnPoint.transform.position;
            }
            _audioController.playSound(2);
        }    
    }

    

    

}

