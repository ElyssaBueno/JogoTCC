﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    private SpriteRenderer _render;
    private Sprite _thisSprite;
    // private LineReader _file;
    private UIManager _uiManager;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        _render = GetComponent<SpriteRenderer>();
        
        //pega componentes do objeto leitor de arquivos de texto
        //_file = GameObject.Find("FileReader").GetComponent<LineReader>(); 
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (_thisSprite == null)
        {
            
           //Seleciona um sprite disponível na pasta Resources que possua o nome adequado
           _thisSprite = (Resources.Load<Sprite>(_uiManager.analise.text + gameObject.tag));
           //Renderiza o sprite selecionado
           _render.sprite = _thisSprite;
         
           
        }
       
    }
}