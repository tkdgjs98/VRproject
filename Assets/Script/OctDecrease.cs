using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OctDecrease : MonoBehaviour
{
    public AudioSource click;
    public TextMesh octlevel;
    

    public PianoPitcher pitcher;
    GameObject piano;

    public void OnTriggerEnter(Collider other)
    {
        pitcher.DecreaseOctOff();

        click.Play();
        octlevel.text = pitcher.octaveOffset.ToString();

    }
}
