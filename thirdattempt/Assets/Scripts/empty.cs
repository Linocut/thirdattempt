using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class empty : MonoBehaviour
{
    public Text narration;
    public Text timer;
    public Image timerBg;
    public Image nothing;
    public Button back;
    public Text buttonText;
    public Text descriptionText;
    public Image textbg;
    public Canvas bigCanvas;
    public GameObject thing;
    public Canvas endCanvas;
    // Start is called before the first frame update
    void Start()
    {

        endCanvas.gameObject.SetActive(false);
        narration.text = "In the night, you hear a noise.";
        timer.gameObject.SetActive(false);
        timerBg.gameObject.SetActive(false);
        textbg.gameObject.SetActive(false);
        descriptionText.gameObject.SetActive(false);
        nothing.gameObject.SetActive(true);
        back.gameObject.SetActive(true);
        thing.GetComponent<audioController>().knocking();
        buttonText.text = "I hear a knock.";
        
    }


    public void knock()
    {
        thing.GetComponent<audioController>().doorbreak();
        timerBg.gameObject.SetActive(true);
        timer.gameObject.SetActive(true);
        narration.gameObject.SetActive(false);
        nothing.gameObject.SetActive(false);
        back.gameObject.SetActive(false);
        descriptionText.text = "Was that the front door? Is someone there? ";
        textbg.gameObject.SetActive(true);
        descriptionText.gameObject.SetActive(true);
    }
    public void door()
    {
        nothing.gameObject.SetActive(false);
        back.gameObject.SetActive(false);
        descriptionText.gameObject.SetActive(true);
        textbg.gameObject.SetActive(true);
        descriptionText.text = "The bedroom door is open. \nIt must have come in from the front door.";

    }
    public void phone()
    {
        nothing.gameObject.SetActive(false);
        back.gameObject.SetActive(false);
        descriptionText.gameObject.SetActive(true);
        textbg.gameObject.SetActive(true);
        descriptionText.text = "My phone maybe I can call for help.";

    }
    public void bat()
    {
        nothing.gameObject.SetActive(false);
        back.gameObject.SetActive(false);
        descriptionText.gameObject.SetActive(true);
        textbg.gameObject.SetActive(true);
        descriptionText.text = "My bat, maybe I can defend myself?";
    }
    public void wardrobe()
    {
        nothing.gameObject.SetActive(false);
        back.gameObject.SetActive(false);
        descriptionText.gameObject.SetActive(true);
        textbg.gameObject.SetActive(true);
        descriptionText.text = "I could hide here..but probably not for long.";
    }
    public void window()
    {
        nothing.gameObject.SetActive(false);
        back.gameObject.SetActive(false);
        descriptionText.gameObject.SetActive(true);
        textbg.gameObject.SetActive(true);
        descriptionText.text = "The window is sealed tight. Maybe I can find something to break it.";
    }


}
