using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JudgeController : MonoBehaviour
{
    public FollowerController numberOfFollowers;
    public Animator judgeAni;                           //defines animator
    public Transform target1, target2, target3, player;          //defines targets for navmeshagent
    public NavMeshAgent judgeMesh;                      //defines navMeashAgent
    private bool playerIsHere;                          //creates bool
    private int followersTotal;

    // Start is called before the first frame update
    void Start()
    {
        judgeMesh.SetDestination(target1.position);
        judgeMesh.speed = 0.75f;
    }

    // Update is called once per frame
    void Update()
    {
        followersTotal = numberOfFollowers.goodFollowers + numberOfFollowers.badFollowers + numberOfFollowers.neutralFollowers;


        if (Vector3.Distance(judgeMesh.destination, judgeMesh.transform.position) <= 1.0f && playerIsHere == false)            //compares NMA location and target location, and if less than or equal to 1 distance away AND bool is false...
        {
            judgeMesh.SetDestination(target2.position);                                                                        //change to target2

            if (Vector3.Distance(judgeMesh.destination, judgeMesh.transform.position) <= 1.0f && playerIsHere == false)       //compares NMA location and target location, and if less than or equal to 1 distance away AND bool is false...
            {
                judgeMesh.SetDestination(target3.position);                                                                    //change to target1
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(followersTotal);
        //Debug.Log("collision detected");                      //debug to confirm trigger working
        judgeMesh.SetDestination(player.position);             //sets NMA target to player location
        playerIsHere = true;                                    //changes bool to true
        judgeAni.SetBool("PlayerIsHere", true);                //changes animator bool to true, starting transition
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (numberOfFollowers.judgeDance == 1)
        {
            Debug.Log("judge triggered");
            judgeAni.SetInteger("Followers", followersTotal);
        }
        if (Vector3.Distance(judgeMesh.destination, judgeMesh.transform.position) <= 4.0f)        //compares NMA location with target and if distance is less then or equal to 4....
        {
            judgeMesh.isStopped = true;                                                            //change NMA to isStopped, makes sure NPC doesn't get too close
        }
    }

    private void OnTriggerExit(Collider other)
    {
        judgeMesh.isStopped = false;                           //sets bool back to false on exit, allowing NMA to move again
        judgeMesh.SetDestination(target2.position);            //sets new target for NMA
        playerIsHere = false;                                   //sets bool to false
        judgeAni.SetBool("PlayerIsHere", false);               //sets animator bool to false, starting new animation        
    }

}

