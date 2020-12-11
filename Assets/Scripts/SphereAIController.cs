using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SphereAIController : MonoBehaviour
{
    public Animator SphereAnimator;                                                             //defines animator
    public FollowerController numberOfFollowers;                                                //creates reference to the follower controller
    public Transform targetPlayer, targetPen1, targetPen2, targetPen3, targetPen4, targetPen5;  //defines various targets, player and hgolding location
    public NavMeshAgent Sphere1, Sphere2, Sphere3, Sphere4, Sphere5;                            //defines NavMeshAgents

    void Update()
    {
        if (numberOfFollowers.goodFollowers == 0)                   //if number of good followers from follower controller = 0
        {
            Sphere1.SetDestination(targetPen1.position);            //all stay at the pen targets
            Sphere2.SetDestination(targetPen2.position);            
            Sphere3.SetDestination(targetPen3.position);
            Sphere4.SetDestination(targetPen4.position);
            Sphere5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.goodFollowers == 1)                   //if number of good followers = 1
        {
            Sphere1.SetDestination(targetPlayer.position);          //target changed to player
            Sphere2.SetDestination(targetPen2.position);            //rest stay at pen
            Sphere3.SetDestination(targetPen3.position);
            Sphere4.SetDestination(targetPen4.position);
            Sphere5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.goodFollowers == 2)                   //if number of followers from controller = 2
        {
            Sphere1.SetDestination(targetPlayer.position);          //target player
            Sphere2.SetDestination(targetPlayer.position);          //target player
            Sphere3.SetDestination(targetPen3.position);            //rest stay in pen
            Sphere4.SetDestination(targetPen4.position);
            Sphere5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.goodFollowers == 3)                   //if number of followers = 3
        {
            Sphere1.SetDestination(targetPlayer.position);          //target player
            Sphere2.SetDestination(targetPlayer.position);          //target player
            Sphere3.SetDestination(targetPlayer.position);          //target player
            Sphere4.SetDestination(targetPen4.position);            //stay in pen
            Sphere5.SetDestination(targetPen5.position);            //stay in pen
        }
        if (numberOfFollowers.goodFollowers == 4)                   //if number of followers = 4
        {
            Sphere1.SetDestination(targetPlayer.position);          //target player
            Sphere2.SetDestination(targetPlayer.position);          //target player
            Sphere3.SetDestination(targetPlayer.position);          //target player
            Sphere4.SetDestination(targetPlayer.position);          //target player
            Sphere5.SetDestination(targetPen5.position);            //stay in pen

        }
        if (numberOfFollowers.goodFollowers == 5)                   //if number of followers = 5
        {
            Sphere1.SetDestination(targetPlayer.position);          //all target player
            Sphere2.SetDestination(targetPlayer.position);
            Sphere3.SetDestination(targetPlayer.position);
            Sphere4.SetDestination(targetPlayer.position);
            Sphere5.SetDestination(targetPlayer.position);
        }
    }
}
