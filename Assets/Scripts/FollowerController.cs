using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;



public class FollowerController : MonoBehaviour
{
    public int goodFollowers, badFollowers, neutralFollowers;
    public  InMemoryVariableStorage yarnStorage;


    // Start is called before the first frame update
    void Start()
    {
        if (yarnStorage.GetValue("$badFollowers") != null)
        {
            yarnStorage.SetValue("$badFollowers", 0);
        }
        if (yarnStorage.GetValue("$goodFollowers") != null)
        {
            yarnStorage.SetValue("$goodFollowers", 0);
        }
        if (yarnStorage.GetValue("$neutralFollowers") != null)
        {
            yarnStorage.SetValue("$neutralFollowers", 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        neutralFollowers = (int)yarnStorage.GetValue("$neutralFollowers$").AsNumber;
        goodFollowers = (int)yarnStorage.GetValue("$goodFollowers").AsNumber;
        badFollowers = (int)yarnStorage.GetValue("$badFollowers").AsNumber;
     //   Debug.Log("goodFollowers" + goodFollowers + "badFollowers" + badFollowers + "neutralFollowers" + neutralFollowers);

    }



}
