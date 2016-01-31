using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Win : MonoBehaviour {
    public GameObject winScreen;
    Countdown countdown;
	void Start () {
        countdown = GetComponent<Countdown>();
	}
	
	void Update () {
        if (countdown.timeLeft < 0)
        {
            winScreen.SetActive(true);

        }
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
