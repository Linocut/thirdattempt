using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class empty : MonoBehaviour
{
    public Text narration;
    public Text timer;
    public Image nothing;
    public Button back;
    public Text buttonText;
    public Text descriptionText;
    public Image textbg;
    public Canvas bigCanvas;
    public GameObject thing;
    private bool partOne = false;
    // Start is called before the first frame update
    void Start()
    {
        if (partOne == false)
        {
            narration.text = "In the night, you hear a noise.";
            timer.gameObject.SetActive(false);
            textbg.gameObject.SetActive(false);
            descriptionText.gameObject.SetActive(false);
            nothing.gameObject.SetActive(true);
            back.gameObject.SetActive(true);
            thing.GetComponent<audioController>().knocking();
            buttonText.text = "I hear a knock.";
        }
        
    }


    public void knock()
    {
        thing.GetComponent<audioController>().doorbreak();
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
        buttonText.text = "Someone must have broken in.";
    }

   
}
