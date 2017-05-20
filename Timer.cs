using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    //private float startTime;
    private float timeLeft = 300.0f;
    private bool Finnished = false;

    //// Use this for initialization
    //void Start()
    //{
    //    startTime = Time.time;
    //}

    // Update is called once per frame
    void Update()
      {
        timeLeft -= Time.deltaTime;
        timerText.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
        //    if (Finnished)
        //        return;

        //    float t = Time.time - startTime;

        //    string minutes = ((int)t / 60).ToString();
        //    string seconds = (t % 60).ToString("f2");

        //    timerText.text = minutes + ":" + seconds;

    }
    public void Finnish()
    {
        //Finnished = true;
        //timerText.color = Color.yellow;
    }
}