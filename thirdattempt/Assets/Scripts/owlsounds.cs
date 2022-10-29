using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class owlsounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<audioController>().owl();
    }


}
