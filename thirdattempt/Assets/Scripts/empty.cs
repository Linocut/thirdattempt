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
    public Canvas bigCanvas;
    private bool partOne = false;
    // Start is called before the first frame update
    void Start()
    {
        if (partOne == false)
        {
            narration.text = "In the night, you hear a noise.";
            timer.gameObject.SetActive(false);
            nothing.gameObject.SetActive(true);
            back.gameObject.SetActive(true);
            this.GetComponent<audioController>().knocking();
            buttonText.text = "I hear a knock.";
            partOne = true;
        }
        else if (partOne == true)
        {
            this.GetComponent<audioController>().doorbreak();
            timer.gameObject.SetActive(true);
            narration.gameObject.SetActive(false);
            nothing.gameObject.SetActive(false);
            back.gameObject.SetActive(false);
        }
        
        

    }
    public void knock()
    {
        nothing.gameObject.SetActive(false);
        back.gameObject.SetActive(false);
    }
    public void door()
    {
        narration.gameObject.SetActive(false);
        nothing.gameObject.SetActive(false);
        back.gameObject.SetActive(false);
        narration.text = "The bedroom door is open. It must have come front the front";
        buttonText.text = "Someone must have broken in.";
    }

   
}
