using UnityEngine;
using UnityEngine.EventSystems;

public class PianoButton : MonoBehaviour//, IPointerDownHandler
{
    public AudioSource click;



    public PianoPitcher pitcher;
    GameObject piano;

    public void OnTriggerEnter(Collider other)
    {
        pitcher.DecreaseOctOff();
        
    click.Play();


    }


}
