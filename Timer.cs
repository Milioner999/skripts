using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TMPro.TextMeshProUGUI timer;

    //Цикл обновления 0.01
    void Update()
    {
        timer.text = timer.text + minutes + ":" + seconds;
        seconds -= Time.deltaTime;

        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                seconds += 59;

                minutes -=1 ;
            }
            else
            {
                int sceneindex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneindex);
            }
         }
     }
}
