using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour

{
    private UIManager _uiManager;
   

    void Start()
    {
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            _uiManager.gameOver();
            if (Input.GetKey("escape"))
            {
                Application.Quit();
            }
       


        }
    }
}
