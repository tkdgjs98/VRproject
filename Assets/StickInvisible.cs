using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickInvisible : MonoBehaviour
{
    GameObject drumstick;
    GameObject controller;
    public bool playOnButtonPress = false;
    public string button;

    // Start is called before the first frame update
    void Start()
    {
        drumstick = transform.GetChild(2).gameObject;
        controller = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (playOnButtonPress)
        {
            CheckButtonPress();
        }
    }

    void CheckButtonPress()
    {
        switch(button)
        {
            case "X":
                if (OVRInput.GetDown(OVRInput.RawButton.X))
                {
                    controller.SetActive(false);
                    drumstick.SetActive(true);
                    button = "Y";
                }
                break;
            case "Y":
                if (OVRInput.GetDown(OVRInput.RawButton.X))
                {
                    controller.SetActive(true);
                    drumstick.SetActive(false);
                    button = "X";
                }
                break;

        }
    }
}
