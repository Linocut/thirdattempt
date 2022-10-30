using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicks : MonoBehaviour
{

    public Button buttondoor; 
    public Button buttonphone;
    public Button buttonbat;
    public Camera camera;
    public bool phoneState = false;
    public bool batState = false;
    public bool dresserState = false; 
    // Start is called before the first frame update

    public void left()
    {
        camera.transform.position = new Vector3(30, 0 ,-10);
    }
    public void drawer()
    {
        camera.transform.position = new Vector3(60, 0, -10);
    }
    public void right2()
    {
        camera.transform.position = new Vector3(0, 0, -10);
    }
    public void right()
    {
        camera.transform.position = new Vector3(120, 0, -10);
    }
    public void down()
    {
        camera.transform.position = new Vector3(30, 0, -10);
    }
    public void closedrawer()
    {
        camera.transform.position = new Vector3(90, 0, -10);
    }
    public void phone()
    {
        phoneState = true;
        buttonphone.gameObject.SetActive(false);
    }
    public void wardrobe()
    {
        dresserState = true;
        camera.transform.position = new Vector3(120, 30, -10);
    }
    public void down2()
    {
        dresserState = false; 
        camera.transform.position = new Vector3(120, 0, -10);
    }
    public void bed()
    {
        camera.transform.position = new Vector3(150, 0, -10);
    }
    public void up()
    {
        camera.transform.position = new Vector3(120, 0, -10);
    }
    public void bat()
    {
        batState = true;
        buttonbat.gameObject.SetActive(false);
    }
    public void window()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            camera.transform.position = new Vector3(150, 30, -10);
        }
              
    }
}
