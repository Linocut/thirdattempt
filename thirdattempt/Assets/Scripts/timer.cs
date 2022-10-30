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
    public empty time;
    public Camera camera;
    public GameObject thing;
    public Image endImage;
    public Sprite closet;
    public Sprite room;
    public Sprite windowImage;
    public Sprite closetGood;
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
        if (time.startTimer) 
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


            if (currentTime == 0 && !phone.phoneState && !bat.batState && !end && camera.transform.position.y == 30)
            {
                endText.text = "You were found quickly despite hiding.\n You were killed and robbed in the night. \n Bad Ending 2";
                endImage.sprite = closet;
                endCanvas.gameObject.SetActive(true);
            }
            if (currentTime == 0 && phone.phoneState && !bat.batState && !end && camera.transform.position.y == 30)
            {
                endText.text = "You tried to call for help while in the closet.\n Unfortunately you didnt have enough time and were killed in the night.\n Authorities found your body \n Bad Ending 2";
                endImage.sprite = closet;
                endCanvas.gameObject.SetActive(true);
            }
            if (currentTime == 0 && !phone.phoneState && bat.batState && !end && camera.transform.position.y == 30)
            {
                endText.text = "You tried to hide in the closet and ambush the invader \n You had a good struggle but could not defend yourself for long. \n You were killed in the night. \n Bad Ending 2";
                endImage.sprite = closet;
                endCanvas.gameObject.SetActive(true);
            }
            if (currentTime == 0 && phone.phoneState && bat.batState && !end && camera.transform.position.y == 30)
            {
                endText.text = "You called for help while in the closet. \n When found, you put up a fight with the bat. \n When hope seemed lost, the authorities came in.\n Good Ending 2";
                endImage.sprite = closetGood;
                endCanvas.gameObject.SetActive(true);
            }
            if (currentTime == 0 && !phone.phoneState && bat.batState && !end && camera.transform.position.y != 30)
            {
                endText.text = "You were killed and robbed in the night. \n You were found dead by police after a few days. \n Bad Ending 1";
                endImage.sprite = room;
                endCanvas.gameObject.SetActive(true);
            }
            if (currentTime == 0 && phone.phoneState && !bat.batState && !end && camera.transform.position.y != 30)
            {
                endText.text = "You were killed and robbed in the night. \n You were found dead by police after a few days. \n Bad Ending 1";
                endImage.sprite = room;
                endCanvas.gameObject.SetActive(true);
            }

            if (currentTime == 0 && !phone.phoneState && !bat.batState && !end && camera.transform.position.y != 30)
            {
                endText.text = "You weren't able to do something in time.\n You were killed and robbed in the night. \n Bad Ending 1";
                endImage.sprite = room;
                endCanvas.gameObject.SetActive(true);
            }
            if (currentTime == 0 && phone.phoneState && bat.batState && !end && camera.transform.position.y != 30)
            {
                endText.text = "You were killed and robbed in the night. \n You were found dead by police after a few days. \n Bad Ending 1";
                endImage.sprite = room;
                endCanvas.gameObject.SetActive(true);
            }
        }
       
    }
    public void window()
    {
        if (bat.batState && !phone.phoneState)
        {
            end = true;
            thing.GetComponent<audioController>().glassBreak();
            endText.text = "You break the window.\n You were able to run away but you were unable to get help in time. \n By the time the authorities came, you were robbed. \n Neutral end";
            endImage.sprite = windowImage;
            endCanvas.gameObject.SetActive(true);
        }
        if(bat.batState && phone.phoneState)
        {
            end = true;
            thing.GetComponent<audioController>().glassBreak();
            endText.text = "You break the window.\n You were able to run away and call for help on your phone. \n The authorities came and scared off the invader. \n Good ending 1";
            endImage.sprite = windowImage;
            endCanvas.gameObject.SetActive(true);
        }
    }
}
