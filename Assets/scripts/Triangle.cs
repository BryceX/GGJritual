using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Triangle : MonoBehaviour {

    bool startTimer;
    Countdown countdown;
    Button button;
    float timeLeft;
    float xPos;
    float moveSpeed = 100;
    void Start()
    {

        countdown = GetComponentInParent<Countdown>();
        button = GetComponent<Button>();

        timeLeft = 4;
    }

    void Update()
    {
        
        countdown.shouldCount = false;
        transform.position = new Vector3(transform.position.x+Time.deltaTime*moveSpeed,transform.position.y,transform.position.z);
        if (transform.position.x > 1000)
        {
            transform.position = new Vector3(1000, transform.position.y, transform.position.z);
            moveSpeed = -moveSpeed;
        }
        if (transform.position.x < 29)
        {
            transform.position = new Vector3(29, transform.position.y, transform.position.z);
            moveSpeed = -moveSpeed;
        }
    }
    public void Clicked()
    {
        startTimer = true;
        gameObject.SetActive(false);

        countdown.shouldCount = true;
        
    }
}
