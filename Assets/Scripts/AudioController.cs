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
        if (audioStore.GetValue("$GKHello") != null)            //if this has no value...
        {
            audioStore.SetValue("$GKHello", 0);                 //set it to zero
        }
        if (audioStore.GetValue("$BKHello") != null)             //if this has no value...
        {       
            audioStore.SetValue("$BKHello", 0);                 //set it to zero
        }
        if (audioStore.GetValue("$NKHello") != null)             //if this has no value...
        {
            audioStore.SetValue("$NKHello", 0);              
        }
        if (audioStore.GetValue("$JudgeHello") != null)
        {
            audioStore.SetValue("$JudgeHello", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GKHi = (int)audioStore.GetValue("$GKHello").AsNumber;
        BKHi = (int)audioStore.GetValue("$BKHello").AsNumber;
        NKHi = (int)audioStore.GetValue("$NKHello").AsNumber;
        JudgeHi = (int)audioStore.GetValue("$JudgeHello").AsNumber;

        if (GKHi == 1)
        {
            if (GKOnOff == true)
            {
                GKHelloControl();
                Debug.Log("GKHello");
            }
        }
        if (GKHi == 0)
        {
            GKOnOff = true;
        }

        if (BKHi == 1)
        {
            if (BKOnOff == true)
            {
                BKHelloControl();
            }
        }
        if (BKHi == 0)
        {
            BKOnOff = true;
        }

        if (NKHi == 1)
        {
            if (NKOnOff == true)
            {
                NKHelloControl();
            }
        }
        if (NKHi == 0)
        {
            NKOnOff = true;
        }

        if (JudgeHi == 1)
        {
            if (JudgeOnOff == true)
            {
                JudgeHelloControl();
            }
        }
    }

    void GKHelloControl()
    {
        GKIntro.Play();
        Debug.Log("GK Hello Control");
        GKOnOff = false;
    }

    void BKHelloControl()
    {
        BKIntro.Play();
        Debug.Log("BK Hello Control");
        BKOnOff = false;
    }

    void NKHelloControl()
    {
        NKIntro.Play();
        Debug.Log("NK Hello Control");
        NKOnOff = false;
    }

    void JudgeHelloControl()
    {
        JudgeIntro.Play();
        Debug.Log("Judge hello");
        JudgeOnOff = false;
    }

}
