using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Threading;
//using UnityEngine.EventSystems;

public class ButtonVR : MonoBehaviour
{

    

    
    public int tone, octave;            //piano section
    public PianoPitcher pitcher;
    GameObject piano;
    AudioClip[] clip;
    AudioMixerGroup group;
    public AudioSource curr;
    float volume = 0.25f;
    float scale = Mathf.Pow(2f, 1.0f / 12f);
    //bool needtoplay = true;

    int pl=0;
    int de=0;

    bool playable = false ;


    // Start is called before the first frame update
    void Start()
    {
       

        clip = pitcher.clip;
        group = pitcher.group;
        piano = pitcher.piano;      //piano code
    }


    private void OnTriggerEnter(Collider other)
    {

        if (playable == false) 
        {
        playable = true;
        PlayNote();
        pl++;
        Debug.Log("play" + pl);
        GetComponent<Animator>().SetBool("down", true);
            
        }
       
         
       
    }

    private void OnTriggerExit(Collider other)
    {

        if (playable == true)
        {
            GetComponent<Animator>().SetBool("down", false);
            if (curr != null)
            {
                Debug.Log("relase");
                StartCoroutine(SoundFade(curr));
            }
            playable = false;
        }
    }

    void PlayNote() //this part instantiates new audiosources every time the button is pressed
    {

       
        curr = piano.AddComponent<AudioSource>() as AudioSource;
        curr.loop = true;
        curr.volume = volume;
        curr.outputAudioMixerGroup = group;
        curr.pitch = Mathf.Pow(scale, tone);
        curr.clip = clip[pitcher.octaveOffset + octave - 1];
        curr.Play();

        
    }
    
    IEnumerator SoundFade(AudioSource source) //sound fade after the button gets unpressed
    {

        float progress = 0;
        while (progress < 1)
        {
            progress += 0.75f * Time.deltaTime;
            if (source != null)
                source.volume = volume * 1 - progress;
            yield return null;
        }
        Destroy(source);
        de++;

        Debug.Log("DEstroy" + de);
        yield return null;
    }



    // Update is called once per frame
    void Update()
    {



    }
}
