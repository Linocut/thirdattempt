using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class empty : MonoBehaviour
{
    public Text door;
    // Start is called before the first frame update
    void Start()
    {
        door.gameObject.SetActive(false);
    }

   
}
