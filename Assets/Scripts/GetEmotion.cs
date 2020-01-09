using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEmotion : MonoBehaviour
{
    private CsvReader _csv;
    private UIManager _uiManager;
    public float arousal, valence;
    // Start is called before the first frame update
    void Start()
    {
        _csv = GameObject.Find("FileReader").GetComponent<CsvReader>();
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        analyze();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void analyze()
    {

        arousal = float.Parse(_csv.data_values[1]);
        valence = float.Parse(_csv.data_values[2]);
        
        if (arousal>0 && valence > 0)
        {
            _uiManager.analise.text = "Happy";
        }
        else if (arousal > 0 && valence < 0)
        {
            _uiManager.analise.text = "Tender";
        }
        else if (arousal < 0 && valence > 0)
        {
            _uiManager.analise.text = "Fear";
        }
        else if (arousal < 0 && valence < 0)
        {
            _uiManager.analise.text = "Sad";
        }
    }
}
