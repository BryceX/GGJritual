using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Deactive : MonoBehaviour {
    bool startTimer;
    Text text;
    Countdown countdown;
    Button button;
    float timeLeft;

	void Start () {
        
        countdown = GetComponentInParent<Countdown>();
        
        button = GetComponentInChildren<Button>();
        text = button.GetComponentInChildren<Text>();
       
        timeLeft = 4;
	}
	
	void Update () {
	    

        if (startTimer)
        {
            if (timeLeft > 1)
            {
                timeLeft -= Time.deltaTime;
                text.text = ((int)timeLeft).ToString();
                countdown.shouldCount = false;
                
            }
            if (timeLeft < 1)
            {
                gameObject.SetActive(false);
                countdown.shouldCount = true;
                countdown.shouldSpawn = true;
            }
        }
    }
   public void Clicked()
    {
        startTimer = true;

    }
}

