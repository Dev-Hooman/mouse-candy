using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class LevelTime : MonoBehaviour
{
    [SerializeField] private int timerDurationMinutes = 5;
    [SerializeField] private Text levelTime;


    private float timer = 0f;
    private bool timerStarted = true;

    private void Start()
    {
        timer = timerDurationMinutes * 60f; 
    }

    private void Update()
    { 
        if (timerStarted)
        {
            timer -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(timer / 60f);
            int seconds = Mathf.FloorToInt(timer % 60f);

            string timeFormatted = string.Format("{0:00}:{1:00}", minutes, seconds);
            //Debug.Log("Scene Time: " + timeFormatted);
            levelTime.text = "Time: " + timeFormatted;

            if (timer <= 0f)
            {
                timerStarted = false;
                LoadNextScene();
            }
        }
    }

    public void StartTimer()
    {
        timerStarted = true;
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("EndScene");
    }
}
