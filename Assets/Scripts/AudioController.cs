using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class AudioController : MonoBehaviour
{
    public InMemoryVariableStorage audioStore;                  //creates audioStore value from yarn variable manager
    public int GKHi, BKHi, NKHi;                                //creates integers
    public AudioSource GKIntro, BKIntro, NKIntro;               //defines Audio sources

    // Start is called before the first frame update
    void Start()
    {
        if (audioStore.GetValue("$GKHello") != null)            //if this has no value...
        {
            audioStore.SetValue("$GKHello", 0);                 //set it to zero
        }
        if (audioStore.GetValue("BKHello") != null)             //if this has no value...
        {       
            audioStore.SetValue("$BKHello", 0);                 //set it to zero
        }
        if (audioStore.GetValue("NKHello") != null)             //if this has no value...
        {
            audioStore.SetValue("NKHello", 0);                  //set it to zero
        }
    }

    // Update is called once per frame
    void Update()
    {
        GKHi = (int)audioStore.GetValue("$GKHello").AsNumber;   //gets to value from the audioStore reference and sets to integer
        BKHi = (int)audioStore.GetValue("$BKHello").AsNumber;   //gets to value from the audioStore reference and sets to integer
        NKHi = (int)audioStore.GetValue("$NKHello").AsNumber;   //gets to value from the audioStore reference and sets to integer

        if (GKHi == 1)              //if int is equal to this value...
        {
            GKIntro.Play();         //play this audio source
        }
        if (GKHi == 0)              //if int is equal to this value...
        {
            GKIntro.Stop();         //Stop playing audio source
        }
        if (BKHi == 1)              //if int is equal to this value...
        {
            BKIntro.Play();         //play this audio source
        }
        if (BKHi == 0)              //if int is equal to this value...
        {
            BKIntro.Stop();         //stop playing audio source
        }
        if (NKHi == 1)              //if int is equal to this value...
        {
            NKIntro.Play();         //play this audio source
        }
        if(NKHi ==0)                //if int is equal to this value
        {
            NKIntro.Stop();         //stop playing audio source
        }
    }
}
