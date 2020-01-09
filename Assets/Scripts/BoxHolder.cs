using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHolder : MonoBehaviour
{
    [SerializeField] private float _max, _min;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < _min)
        {
            transform.position = new Vector3(_min, transform.position.y, 0);
        }
        else if (transform.position.x > _max)
        {
            transform.position = new Vector3(_max, transform.position.y, 0);
        }
    }
}
