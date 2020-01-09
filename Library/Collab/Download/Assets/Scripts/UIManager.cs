using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public GameObject Lightning;
    public Text pointsText;
    public Text analise;
    public GameObject gameOverScreen;
    private int points = 0;
    private int _flag=0;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GameObject.Find("Music").GetComponent<AudioSource>();
        // analise.text = "Tender";

    }

    // Update is called once per frame
    void Update()
    {
        if (_flag == 0)
        {
            enableLightning();
            _flag = 1;
        }
    }

    public void gotPoint() {
        points++;
        pointsText.text = "Points: " + points;
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        _audioSource.Stop();
        Time.timeScale = 0;

    }

    void enableLightning(){
        if (analise.text == "Fear")
        {
            Lightning.SetActive(true);
        }
    }
}
