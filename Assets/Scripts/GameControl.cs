﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null){
	    instance = this;
	} else if (instance != this){
	    Destroy(gameObject);
	}
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0)) 
        {
	   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdDied(){
	gameOverText.SetActive(true);
	gameOver = true;
    }
}
