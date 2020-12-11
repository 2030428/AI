using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class AudioController : MonoBehaviour
{
    public InMemoryVariableStorage audioStore;                  //creates audioStore value from yarn variable manager
    public int GKHi, BKHi, NKHi, JudgeHi;                       //creates integers
    public AudioSource GKIntro, BKIntro, NKIntro, JudgeIntro;   //defines Audio sources
    private bool GKOnOff, BKOnOff, NKOnOff, JudgeOnOff;          //creates bools to confirm on and off

    // Start is called before the first frame update
    void Start()
    {
        if (audioStore.GetValue("$GKHello") != null)            //if this has value...
        {
            audioStore.SetValue("$GKHello", 0);                 //set it to zero
        }
        if (audioStore.GetValue("$BKHello") != null)            //if this has value...
        {       
            audioStore.SetValue("$BKHello", 0);                 //set it to zero
        }
        if (audioStore.GetValue("$NKHello") != null)            //if this has value...
        {
            audioStore.SetValue("$NKHello", 0);                 //set it to zero
        }
        if (audioStore.GetValue("$JudgeHello") != null)         //if this has value...
        {
            audioStore.SetValue("$JudgeHello", 0);              //set it to zero
        }
    }

    // Update is called once per frame
    void Update()
    {
        GKHi = (int)audioStore.GetValue("$GKHello").AsNumber;           //sets value from audiostore to an integer
        BKHi = (int)audioStore.GetValue("$BKHello").AsNumber;           //sets value from audiostore to an integer
        NKHi = (int)audioStore.GetValue("$NKHello").AsNumber;           //sets value from audiostore to an integer
        JudgeHi = (int)audioStore.GetValue("$JudgeHello").AsNumber;     //sets value from audiostore to an integer

        if (GKHi == 1)                      //if the int is equal to one
        {
            if (GKOnOff == true)            //and the bool is true
            {   
                GKHelloControl();           //call this function         
                //Debug.Log("GKHello");     //debug to check is working
            }
        }
        if (GKHi == 0)                      //if int is equal to zero
        {
            GKOnOff = true;                 //set bool to true
        }

        if (BKHi == 1)                      //if the int is equal to zero
        {
            if (BKOnOff == true)            //and the bool is true
            {
                BKHelloControl();           //call this function
            }
        }
        if (BKHi == 0)                      //if the int is equal to zero
        {
            BKOnOff = true;                 //set bool to true
        }

        if (NKHi == 1)                      //if the int is equal to one
        {
            if (NKOnOff == true)            //and the bool is true
            {
                NKHelloControl();           //call this function
            }
        }
        if (NKHi == 0)                      //if equal to zero
        {
            NKOnOff = true;                 //set bool to true
        }
            
        if (JudgeHi == 1)                   //if this int is equal to one
        {
            if (JudgeOnOff == true)         //and the bool true
            {
                JudgeHelloControl();        //call function
            }
        }
        if (JudgeHi == 0)                   //if equal to zero
        {
            JudgeOnOff = true;              //set bool to true
        }
    }

    void GKHelloControl()
    {
        GKIntro.Play();                     //set audio source to play
        //Debug.Log("GK Hello Control");      //debug to check is working
        GKOnOff = false;                    //sets bool false
    }

    void BKHelloControl()
    {
        BKIntro.Play();                     //set audio source to play
        //Debug.Log("BK Hello Control");      //debug to check is working
        BKOnOff = false;                    //set bool false
    }

    void NKHelloControl()
    {
        NKIntro.Play();                     //set audio source to play
        //Debug.Log("NK Hello Control");      //debug to check is working
        NKOnOff = false;                    //set bool false
    }

    void JudgeHelloControl()
    {
        JudgeIntro.Play();                  //set audio source to play
        //Debug.Log("Judge hello");           //debug to check is working
        JudgeOnOff = false;                 //set bool false
    }

}
