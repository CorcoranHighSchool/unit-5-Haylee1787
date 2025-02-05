using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeValue = 60;
    public GameManagerX gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManagerX>();   
    }

    // Update is called once per frame
    void Update()
    {
      if (gameManager.isGameActive)
        {
            if (timeValue > 0 )
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;
            }
            DisplayTime(timeValue);
        } 
    }
    void DisplayTime ( float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0; 
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
