using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private float currentTime = 0f;
    private float startingTime = 30f;
    public Text countdownText;
    public Canvas endCanvas;
    public Text endText;
    public clicks phone;
    public clicks bat;
    public clicks dresser;
    public Text description;
    public Camera camera;
    private bool textOne = true;
    private bool textTwo = true;
    // Start is called before the first frame update
    void Start()
    {
        endCanvas.gameObject.SetActive(false);
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        countdownText.text = "Time: " + currentTime.ToString("0.0");
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
        if (currentTime <= 20 && textOne == true)
        {
            description.text = "I need to do something..\n I think someone broke in.";
            textOne = false;
        }
        if (currentTime <= 10 && textTwo == true)
        {
            description.text = "They are getting closer I should hide.";
            textTwo = false; 
        }
        if (currentTime == 0 && !phone.phoneState && !bat.batState)
        {
            endText.text = "You weren't able to do something in time.\n Game Over.";
            endCanvas.gameObject.SetActive(true);
        }

        if (camera.transform.position.y == 30)
        {
            Debug.Log("in the closet");
        }

        if (phone.phoneState)
        {
            Debug.Log("phone");
        }
        if (bat.batState)
        {
            Debug.Log("bat");
        }

    }
}
