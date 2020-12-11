using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CylinderAIController : MonoBehaviour
{
    public Animator CylinderAnimator;                                                               //defines animator
    public FollowerController numberOfFollowers;                                                    //makes a reference to the follower controller
    public Transform targetPlayer, targetPen1, targetPen2, targetPen3, targetPen4, targetPen5;      //defines various targets, player and holding targets
    public NavMeshAgent Cylinder1, Cylinder2, Cylinder3, Cylinder4, Cylinder5;                      //defines NavMeshAgents

    void Update()
    {
        if (numberOfFollowers.neutralFollowers == 0)            //if number of neutral followers from follower controller = 0
        {
            Cylinder1.SetDestination(targetPen1.position);      //all stay at the pen targets
            Cylinder2.SetDestination(targetPen2.position);
            Cylinder3.SetDestination(targetPen3.position);
            Cylinder4.SetDestination(targetPen4.position);
            Cylinder5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.neutralFollowers == 1)            //if number of neutral followers from follower controller = 1
        {
            Cylinder1.SetDestination(targetPlayer.position);    //target is changed to player
            Cylinder2.SetDestination(targetPen2.position);      //the rest stay in the pen
            Cylinder3.SetDestination(targetPen3.position);
            Cylinder4.SetDestination(targetPen4.position);
            Cylinder5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.neutralFollowers == 2)            //if number of neutral followers from follower controller = 2
        {
            Cylinder1.SetDestination(targetPlayer.position);    //target changed to player
            Cylinder2.SetDestination(targetPlayer.position);    //target changed to player
            Cylinder3.SetDestination(targetPen3.position);      //the rest stay in pen
            Cylinder4.SetDestination(targetPen4.position);
            Cylinder5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.neutralFollowers == 3)            //if number of neutrak followers from follower controller = 3
        {
            Cylinder1.SetDestination(targetPlayer.position);    //target changed to player 
            Cylinder2.SetDestination(targetPlayer.position);    //target changed to player
            Cylinder3.SetDestination(targetPlayer.position);    //target changed to player
            Cylinder4.SetDestination(targetPen4.position);      //stay in pen
            Cylinder5.SetDestination(targetPen5.position);      //stay in pen
        }
        if (numberOfFollowers.neutralFollowers == 4)            //if number of neutral followers from follower container = 4
        {   
            Cylinder1.SetDestination(targetPlayer.position);    //target changed to player
            Cylinder2.SetDestination(targetPlayer.position);    //target changed to player
            Cylinder3.SetDestination(targetPlayer.position);    //target changed to player
            Cylinder4.SetDestination(targetPlayer.position);    //target changed to player
            Cylinder5.SetDestination(targetPen5.position);      //stay in pen

        }
        if (numberOfFollowers.neutralFollowers == 5)            //if number of neutral followers from follower container = 5
        {
            Cylinder1.SetDestination(targetPlayer.position);    //all target player
            Cylinder2.SetDestination(targetPlayer.position);
            Cylinder3.SetDestination(targetPlayer.position);
            Cylinder4.SetDestination(targetPlayer.position);
            Cylinder5.SetDestination(targetPlayer.position);
        }
    }
}
