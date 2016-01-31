using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class AvoidX : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    Image image;
    Countdown countdown;
    public bool mOn = false;
    float moveSpeed = 500;

    void Start () {
        image = GetComponent<Image>();
        countdown = GetComponentInParent<Countdown>();
        image.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (countdown.timeLeft < 7)
        {
            image.enabled = true;
        }
        if (countdown.timeLeft>7)
        {
            image.enabled = false;
        }
        image.transform.Rotate(Vector3.back * Time.deltaTime*20);
        image.transform.position = new Vector3(image.transform.position.x + Time.deltaTime * moveSpeed, image.transform.position.y, image.transform.position.z);
        if (image.transform.position.x > 1000)
        {
            image.transform.position = new Vector3(1000, image.transform.position.y, image.transform.position.z);
            moveSpeed = -moveSpeed;
        }
        if (image.transform.position.x < 29)
        {
            image.transform.position = new Vector3(29, image.transform.position.y, image.transform.position.z);
            moveSpeed = -moveSpeed;
        }
        if (mOn)
        {
            countdown.timeLeft += Time.deltaTime*5;
        }
        
    }
    

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
        mOn = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
        mOn = false;
    }
}
