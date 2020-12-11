using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeAIController : MonoBehaviour
{
    public Animator CubeAnimator;                                                                   //defines animator
    public FollowerController numberOfFollowers;                                                    //makes a reference to the follower controller
    public Transform targetPlayer, targetPen1, targetPen2, targetPen3, targetPen4, targetPen5;      //defines various targets, player and holding targets
    public NavMeshAgent Cube1, Cube2, Cube3, Cube4, Cube5;                                          //defines NavMeshAgents

    void Update()
    {
        if (numberOfFollowers.badFollowers == 0)            //if number of bad followers from follower controller = 0
        {
            Cube1.SetDestination(targetPen1.position);      //all nav mesh agents stay at holding pen targets
            Cube2.SetDestination(targetPen2.position);
            Cube3.SetDestination(targetPen3.position);
            Cube4.SetDestination(targetPen4.position);
            Cube5.SetDestination(targetPen5.position);

        }
        if (numberOfFollowers.badFollowers == 1)            //if followers = 1
        {   
            Cube1.SetDestination(targetPlayer.position);    //target changed to player
            Cube2.SetDestination(targetPen2.position);      //the rest stay in holding pen
            Cube3.SetDestination(targetPen3.position);
            Cube4.SetDestination(targetPen4.position);
            Cube5.SetDestination(targetPen5.position);

        }
        if (numberOfFollowers.badFollowers == 2)            //if followers = 2
        {
            Cube1.SetDestination(targetPlayer.position);    //target changed to player
            Cube2.SetDestination(targetPlayer.position);    //target changed to player
            Cube3.SetDestination(targetPen3.position);      //rest stay in pen
            Cube4.SetDestination(targetPen4.position);
            Cube5.SetDestination(targetPen5.position);
        }       
        if (numberOfFollowers.badFollowers == 3)            //if followers = 3
        {
            Cube1.SetDestination(targetPlayer.position);    //target player
            Cube2.SetDestination(targetPlayer.position);    //target player
            Cube3.SetDestination(targetPlayer.position);    //target player
            Cube4.SetDestination(targetPen4.position);      //stay in pen
            Cube5.SetDestination(targetPen5.position);      //stay in pen
        }
        if (numberOfFollowers.badFollowers == 4)            //if followers = 4
        {
            Cube1.SetDestination(targetPlayer.position);    //target player
            Cube2.SetDestination(targetPlayer.position);    //target player
            Cube3.SetDestination(targetPlayer.position);    //target player
            Cube4.SetDestination(targetPlayer.position);    //target player
            Cube5.SetDestination(targetPen5.position);      //stay in pen

        }
        if (numberOfFollowers.badFollowers == 5)            //if followers = 5
        {
            Cube1.SetDestination(targetPlayer.position);    //all nav mesh agents target player
            Cube2.SetDestination(targetPlayer.position);
            Cube3.SetDestination(targetPlayer.position);
            Cube4.SetDestination(targetPlayer.position);
            Cube5.SetDestination(targetPlayer.position);
        }
    }
}
