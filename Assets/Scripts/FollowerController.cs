using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;



public class FollowerController : MonoBehaviour
{
    public int goodFollowers, badfollowers, neutralFollowers;
    public  InMemoryVariableStorage yarnStorage;


    // Start is called before the first frame update
    void Start()
    {
        if (yarnStorage.GetValue("$badfollowers") != null)
        {
            yarnStorage.SetValue("$badfollowers", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

        badfollowers = (int)yarnStorage.GetValue("$badfollowers").AsNumber;
        Debug.Log("goodFollowers" + goodFollowers + "badfollowers" + badfollowers + "neutralFollowers" + neutralFollowers);

    }
}
