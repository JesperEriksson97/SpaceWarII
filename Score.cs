using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text text;
    public float textToPresent;
    
    // Update is called once per frame
    void Update()
    {
       textToPresent = player.position.z + 49;
       text.text =  textToPresent.ToString("0");
    }
}
