using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{ 
    public float temps = 10;
    public Text timertext;
    public int tempsint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempsint = Mathf.RoundToInt(temps);
        timertext.text = (tempsint + "");
        if (temps >= 0)
        {
            temps -= Time.deltaTime;
        }
    }
}
