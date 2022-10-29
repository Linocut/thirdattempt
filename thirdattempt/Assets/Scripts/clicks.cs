using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicks : MonoBehaviour
{
    public Text idk;
    public Button buttondoor; 
    public Button buttonphone;
    public Camera camera;
    private bool drawerState = false;
    // Start is called before the first frame update
    public void door()
    {
        idk.gameObject.SetActive(true);
    }
    public void left()
    {
        idk.gameObject.SetActive(false);
        camera.transform.position = new Vector3(30, 0 ,-10);
    }
    public void drawer()
    {
        if (drawerState == false)
        {
            camera.transform.position = new Vector3(60, 0, -10);
        }
        else if (drawerState == true)
        {
            camera.transform.position = new Vector3(90, 0, -10);
        }
    }
    public void right2()
    {
        camera.transform.position = new Vector3(0, 0, -10);
    }
    public void right()
    {
        idk.gameObject.SetActive(false);
        camera.transform.position = new Vector3(120, 0, -10);
    }
    public void down()
    {
        camera.transform.position = new Vector3(30, 0, -10);
    }
    public void closedrawer()
    {
        drawerState = true;
        camera.transform.position = new Vector3(90, 0, -10);
    }
    public void phone()
    {
        buttonphone.gameObject.SetActive(false);
    }
    public void wardrobe()
    {
        camera.transform.position = new Vector3(120, 30, -10);
    }
    public void down2()
    {
        camera.transform.position = new Vector3(120, 0, -10);
    }

}
