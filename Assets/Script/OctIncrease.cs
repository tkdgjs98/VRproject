using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OctIncrease : MonoBehaviour
{
    public AudioSource click;
    public TextMesh octlevel;


    public PianoPitcher pitcher;
    GameObject piano;

    public void OnTriggerEnter(Collider other)
    {
        pitcher.IncreaseOctOff();

        click.Play();
        octlevel.text = pitcher.octaveOffset.ToString();


    }
}
