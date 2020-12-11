using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class FollowerController : MonoBehaviour
{
    public int goodFollowers, badFollowers, neutralFollowers, judgeDance;
    public  InMemoryVariableStorage yarnStorage;

    void Start()
    {
        if (yarnStorage.GetValue("$badFollowers") != null)          //if value is not null
        {
            yarnStorage.SetValue("$badFollowers", 0);               //set badFollower value to zero
        }
        if (yarnStorage.GetValue("$goodFollowers") != null)         //if value is not null
        {
            yarnStorage.SetValue("$goodFollowers", 0);              //set goodFollower value to zero
        }
        if (yarnStorage.GetValue("$neutralFollowers") != null)      //if value is not null
        {
            yarnStorage.SetValue("$neutralFollowers", 0);           //set neutralFollower value to zero
        }
        if (yarnStorage.GetValue("$JudgeDance") != null)            //if value is not null
        {
            yarnStorage.SetValue("$JudgeDance", 0);                 //set to zero
        }

    }

    void Update()
    {
        neutralFollowers = (int)yarnStorage.GetValue("$neutralFollowers").AsNumber;         //converts Yarn value of neutralFollowers to Int
        goodFollowers = (int)yarnStorage.GetValue("$goodFollowers").AsNumber;               //converts Yarn value of goodFollowers to Int
        badFollowers = (int)yarnStorage.GetValue("$badFollowers").AsNumber;                 //converts Yarn value of badFollowers to Int
        judgeDance = (int)yarnStorage.GetValue("$JudgeDance").AsNumber;
        
        //Debug.Log("goodFollowers = " + goodFollowers + "badFollowers = " + badFollowers + "neutralFollowers = " + neutralFollowers);        //debug log printing follower numbers

    }



}
