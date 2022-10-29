using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicks : MonoBehaviour
{
    public Text idk;
    public Image background;
    public Sprite newbackground;
    public Sprite drawerbackground;
    public Button buttondoor;
    // Start is called before the first frame update
    public void door()
    {
        idk.gameObject.SetActive(true);
    }
    public void left()
    {
        idk.gameObject.SetActive(false);
        buttondoor.gameObject.SetActive(false);
        background.sprite = newbackground;
        
    }
    public void drawer()
    {
        background.sprite = drawerbackground;
    }
}
