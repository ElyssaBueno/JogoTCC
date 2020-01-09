using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class CsvReader : MonoBehaviour
{
    public string[] data_values;
    public int line;
    [SerializeField]private TextAsset _csvFile;
    private List<string> eachLine;

    // Start is called before the first frame update
    void Start()
    {
        Read();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Read()
    {

     
        string data_string = _csvFile.text;
        eachLine = new List<string>();
        eachLine.AddRange(data_string.Split("\n"[0]));
        
        data_values = eachLine[StaticClass.id].Split(';');
     
    }
}
