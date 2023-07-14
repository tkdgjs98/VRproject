using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    private AudioSource source;
    public bool playOnButtonPress = false;
    public string button;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}

    private void Update()
    {
        if(playOnButtonPress)
        {
            CheckButtonPress(); 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "DrumStickHead")
        {
            source.volume = other.gameObject.GetComponent<TrackSpeed>().speed;
            ActivateSound();
        }
    }

    private void ActivateSound()
    {
        source.pitch = Random.Range(0.8f, 1.2f);
        source.Play();
    }

    void CheckButtonPress()
    {
        switch (button)
        {
            case "A":
                if (OVRInput.GetDown(OVRInput.RawButton.A)) ActivateSound();
                break;
            case "B":
                if (OVRInput.GetDown(OVRInput.RawButton.B)) ActivateSound();
                break;
        }
    }

}
