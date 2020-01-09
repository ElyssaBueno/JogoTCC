using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMode : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]  private bool _isRandom = false;
    private UIManager _uiManager;
    private int _flag;
    void Start()
    {
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        Randomize();
    }

    // Update is called once per frame
    void Update()
    {
        Randomize();
    }
    void Randomize()
    {
        if (_isRandom == true)
        {
            _flag = Random.Range(1, 5);
            if (_flag == 1)
            {
                _uiManager.analise.text = "Happy";
            }
            if (_flag == 2)
            {
                _uiManager.analise.text = "Fear";
            }
            if (_flag == 3)
            {
                _uiManager.analise.text = "Sad";
            }
            if (_flag == 4)
            {
                _uiManager.analise.text = "Tender";
            }
        }
    }
}
