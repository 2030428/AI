using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class KeeperAIController : MonoBehaviour
{
    public Animator keeperAni;                                  //defines animator
    public Transform target1, target2, player;                  //sets up targets for navmeshagent
    public NavMeshAgent keeperMesh;                             //defines NavMeshAgent (NMA)
    private bool playerIsHere;                                  //creates bool

    private void Start()
    {
        keeperMesh.SetDestination(target1.position);            //sets initial target for NMA
        keeperMesh.speed = 0.75f;                               //defines speed for NMA
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(keeperMesh.destination, keeperMesh.transform.position) <= 1.0f && playerIsHere == false)            //compares NMA location and target location, and if less than or equal to 1 distance away AND bool is false...
        {
            keeperMesh.SetDestination(target2.position);                                                                        //change to target2
            
            if (Vector3.Distance(keeperMesh.destination, keeperMesh.transform.position) <= 1.0f && playerIsHere == false)       //compares NMA location and target location, and if less than or equal to 1 distance away AND bool is false...
            {
                keeperMesh.SetDestination(target1.position);                                                                    //change to target1
            }
        }               
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collision detected");                      //debug to confirm trigger working
        keeperMesh.SetDestination(player.position);             //sets NMA target to player location
        playerIsHere = true;                                    //changes bool to true
        keeperAni.SetBool("PlayerIsHere", true);                //changes animator bool to true, starting transition
    }

    private void OnTriggerStay(Collider other)
    {
        if (Vector3.Distance(keeperMesh.destination, keeperMesh.transform.position) <= 4.0f)        //compares NMA location with target and if distance is less then or equal to 4....
        {
            keeperMesh.isStopped = true;                                                            //change NMA to isStopped, makes sure NPC doesn't get too close
        }
    }

    private void OnTriggerExit(Collider other)
    {
        keeperMesh.isStopped = false;                           //sets bool back to false on exit, allowing NMA to move again
        keeperMesh.SetDestination(target2.position);            //sets new target for NMA
        playerIsHere = false;                                   //sets bool to false
        keeperAni.SetBool("PlayerIsHere", false);               //sets animator bool to false, starting new animation        
    }

}
