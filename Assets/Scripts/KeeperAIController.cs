using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class KeeperAIController : MonoBehaviour
{
    public Animator keeperAni;
    public Transform target1, target2, player;
    public NavMeshAgent keeperMesh;
    private bool playerIsHere;

    private void Start()
    {
        keeperMesh.SetDestination(target1.position);
        keeperMesh.speed = 0.75f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(keeperMesh.destination, keeperMesh.transform.position) <= 1.0f && playerIsHere == false)
        {
            keeperMesh.SetDestination(target2.position);
            
            if (Vector3.Distance(keeperMesh.destination, keeperMesh.transform.position) <= 1.0f && playerIsHere == false)
            {
                keeperMesh.SetDestination(target1.position);
            }
        }               
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision detected");
        keeperMesh.SetDestination(player.position);
        playerIsHere = true;
        keeperAni.SetBool("PlayerIsHere", true);

    }

    private void OnTriggerStay(Collider other)
    {
        if (Vector3.Distance(keeperMesh.destination, keeperMesh.transform.position) <= 4.0f)
        {
            keeperMesh.isStopped = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        keeperMesh.isStopped = false;
        keeperMesh.SetDestination(target2.position);
        playerIsHere = false;
        keeperAni.SetBool("PlayerIsHere", false);
        
    }

}
