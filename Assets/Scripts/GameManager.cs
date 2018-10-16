﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour {

        public static GameManager instance;        
        public Text scoreText;                 
        public GameObject gameOverText;            

        private int score = 0;                     
        public bool gameOver = false;          
        public float scrollSpeed = -1.5f;


        void Awake()
        {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);
        }

        void Update()
        {
            if (gameOver && Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        public void BirdScored()
        {
            if (gameOver)
                return;
            score++;
            scoreText.text = "Score: " + score.ToString();
        }

        public void BirdDied()
        {
            gameOverText.SetActive(true);
            gameOver = true;
        }
    }
}
