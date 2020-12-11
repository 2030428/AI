using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class AudioController : MonoBehaviour
{
    public InMemoryVariableStorage audioStore;
    public int GKHi, BKHi, NKHi;
    public AudioSource GKIntro, BKIntro, NKIntro;
    private bool GKOnOff, BKOnOff, NKOnOff;

    // Start is called before the first frame update
    void Start()
    {
        if (audioStore.GetValue("$GKHello") != null)
        {
            audioStore.SetValue("$GKHello", 0);
        }
        if (audioStore.GetValue("BKHello") != null)
        {
            audioStore.SetValue("$BKHello", 0);
        }
        if (audioStore.GetValue("NKHello") != null)
        {
            audioStore.SetValue("NKHello", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GKHi = (int)audioStore.GetValue("$GKHello").AsNumber;
        BKHi = (int)audioStore.GetValue("$BKHello").AsNumber;
        NKHi = (int)audioStore.GetValue("$NKHello").AsNumber;

        if (GKHi == 1)
        {
            if (GKOnOff == true)
            {
                GKHelloControl();
                Debug.Log("Hello");
            }
        }
        if (GKHi == 0)
        {
            GKOnOff = true;
        }

        if (BKHi == 1)
        {
            BKIntro.Play();
        }
        else
        {
            BKIntro.Stop();
        }
        if (NKHi == 1)
        {
            NKIntro.Play();
        }
        else
        {
            NKIntro.Stop();
        }
    }

    void GKHelloControl()
    {
        GKIntro.Play();
        Debug.Log("Hello Control");
        GKOnOff = false;
    }

}
