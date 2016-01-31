using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Countdown : MonoBehaviour {
    public Text timer;
    public Button circle;
    public Button triangle;
    public bool shouldCount = true;
    public bool shouldSpawn = false;
    public bool shouldSpawnTriangle = false;   
    public float timeLeft = 20;
    float delay = 0;
    float triangleDelay = 0;
	void Start () {
        
        timer = GetComponentInChildren<Text>();
        timer.text = timeLeft.ToString();
        shouldSpawnTriangle = false;
	}
	
	void Update () {


        timer.text = ((int)timeLeft).ToString(); 
        if (shouldCount==true)
        {
            timeLeft -= Time.deltaTime;
        }
        if (timeLeft < 13)
        {
            shouldSpawnTriangle = true;
        }
        if (shouldSpawn)
        {
            delay += Time.deltaTime;
            if (delay > Random.Range(2,5))
            {
                Button childobject = Instantiate(circle);
                childobject.transform.SetParent(transform, false);
                shouldSpawn = false;
                delay = 0;
                shouldCount = false;
            }
            
        }
        if (shouldSpawnTriangle)
        {
            triangleDelay += Time.deltaTime;
            if (triangleDelay > Random.Range(3, 9))
            {
                Button childobject = Instantiate(triangle);
                childobject.transform.SetParent(transform, false);
                shouldSpawn = false;
                triangleDelay = 0;
                shouldCount = false;
            }

        }


    }
    IEnumerator SpawnDelay()
    {
        yield return new WaitForSeconds(5);
        

    }
}
