using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cooldown : MonoBehaviour
{
    public float timeRemaining = 10;
    public GameObject Coffre1;
    public GameObject Bouton1;
  

    void Start()
    {
        Coffre1.SetActive(false);
        Bouton1.SetActive(false);
    }
   
    void Update()
    {
       
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if (timeRemaining < 0)
        {
            Coffre1.SetActive(true);
            Bouton1.SetActive(true);
        }
    } 
    
       
}