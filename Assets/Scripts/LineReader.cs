using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class LineReader : MonoBehaviour
{
    protected FileInfo theSourceFile = null;
    protected StreamReader reader = null;
    public string text = " "; // permite que a primeira linha seja lida

    void Start()
    {
        theSourceFile = new FileInfo("Assets/Resources/analise.txt");
        if (theSourceFile == null)
        {
            theSourceFile = new FileInfo(Application.dataPath + "/analise.txt");
            //text = "Happy";
        }
        else
        {
            reader = theSourceFile.OpenText();
            text = reader.ReadLine();
        }
       // if (!File.Exists(Application.dataPath + "/analise.txt"))
        //{
          //  File.WriteAllText(Application.dataPath + "/analise.txt", text);
        //}
        //print(text);
        //Debug.Log(Application.persistentDataPath + "/analise.txt");
    }

    void Update()
    {
    
    }
}
