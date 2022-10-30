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
    public GameObject thing;
    private bool textOne = true;
    private bool textTwo = true;
    private bool end = false; 
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
        if (currentTime <= 10 && textTwo == true && camera.transform.position.y != 30)
        {
            description.text = "They are getting closer I should hide.";
            textTwo = false; 
        }
        if (currentTime == 0 && !phone.phoneState && !bat.batState && !end && camera.transform.position.y != 30)
        {
            endText.text = "You weren't able to do something in time.\n You were killed and robbed in the night. \n Bad Ending 1.";
            endCanvas.gameObject.SetActive(true);
        }
        if (currentTime == 0 && !phone.phoneState && !bat.batState && !end && camera.transform.position.y == 30)
        {
            endText.text = "You were found quickly.\n You were killed and robbed in the night. \n Bad Ending 2.";
            endCanvas.gameObject.SetActive(true);
        }
        if (currentTime == 0 && phone.phoneState && !bat.batState && !end && camera.transform.position.y == 30)
        {
            endText.text = "You tried to call for help while in the closet.\n Unfortunately you didnt have enough time and were killed in the night.\n Authorities found your body \n Bad Ending 3.";
            endCanvas.gameObject.SetActive(true);
        }
        else if (currentTime == 0 && !phone.phoneState && !bat.batState && !end)
        {
            endText.text = "You were found quickly.\n You were killed and robbed in the night. \n Bad Ending 2.";
            endCanvas.gameObject.SetActive(true);
        }
        if (currentTime == 0 && !phone.phoneState && bat.batState && !end && camera.transform.position.y == 30)
        {
            endText.text = "You tried to hide in the closet but ambush the invader \n You had a good struggle but could not defend yourself for long. \n You were killed in the night. \n Bad Ending 4.";
            endCanvas.gameObject.SetActive(true);
        }
        if (currentTime == 0 && phone.phoneState && bat.batState && !end && camera.transform.position.y == 30)
        {
            endText.text = "You tried to call for help while in the closet. \n You had a good struggle but could not defend yourself for long. \n When hope seemed lost, the authorities came.\n Good Ending 2.";
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
    public void window()
    {
        if (bat.batState && !phone.phoneState)
        {
            end = true;
            thing.GetComponent<audioController>().glassBreak();
            endText.text = "You break the window.\n You were able to run away but you were unable to get help in time. \n By the time the authorities came, you were robbed. \n Neutral end.";
            endCanvas.gameObject.SetActive(true);
        }
        if(bat.batState && phone.phoneState)
        {
            end = true;
            thing.GetComponent<audioController>().glassBreak();
            endText.text = "You break the window.\n You were able to run away and call for help on your phone. \n The authorities came and scared off the invader. \n Good ending 1.";
            endCanvas.gameObject.SetActive(true);
        }
    }
}
