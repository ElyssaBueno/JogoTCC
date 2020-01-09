using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CsvReader : MonoBehaviour
{
    public string[] data_values;
    public int line;
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
     
        StreamReader strReader = new StreamReader("Assets/Resources/analise.csv");
        //bool endOfFile = false;
        while (line < StaticClass.id+1)
        {
            string data_string = strReader.ReadLine();
            //if(data_string == null)
            //{
              //  endOfFile = true;
              //  break;
            //}
            data_values = data_string.Split(';');
            line++;
            
            //for(int o =0; o <data_values.Length; o++)
            //{
            //  Debug.Log("Value:"+o.ToString() + " " + data_values[o].ToString());
            //}
            //Debug.Log(data_values[0].ToString() + " " + data_values[1].ToString() + " " + data_values[2].ToString());
        }
    }
}
