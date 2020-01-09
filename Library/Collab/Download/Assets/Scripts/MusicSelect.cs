using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MusicSelect : MonoBehaviour
{
    [SerializeField] private int _buttonId;

    // Start is called before the first frame update
    public void LoadByIndex(int sceneIndex)
    {
        StaticClass.id = _buttonId;
        SceneManager.LoadScene(sceneIndex);
    }
    // Update is called once per frame

}
