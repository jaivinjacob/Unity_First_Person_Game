using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashLight : MonoBehaviour
{
    [SerializeField]private joybuttonScript joybutton;
    public bool isOn = false;
    public GameObject lightSource;
    void Start()
    {
        lightSource.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetButtonDown("Fkey") || (joybutton.isPressing))
        {
            if(isOn == false)
            {
                lightSource.SetActive(true);
                isOn = true;
            }
            else
            {
                lightSource.SetActive(false);
                isOn = false;
            }
        }
        */
         if((Input.GetButtonDown("Fkey") && !isOn) || ((joybutton.isPressing) && !isOn))
        {
            lightOn();
            
        }
        
        else  if((Input.GetButtonDown("Fkey") && isOn) || ((joybutton.isPressing) && isOn))
        {
            lightOff();
            
        }
    }
     void lightOn()
    {

        lightSource.SetActive(true);
        isOn = true;
    }
    void lightOff()
    {

        lightSource.SetActive(false);
        isOn = false;
    }
}
