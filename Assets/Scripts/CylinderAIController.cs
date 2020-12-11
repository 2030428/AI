using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CylinderAIController : MonoBehaviour
{
    public Animator CylinderAnimator;
    public FollowerController numberOfFollowers;
    public Transform targetPlayer, targetPen1, targetPen2, targetPen3, targetPen4, targetPen5;
    public NavMeshAgent Cylinder1, Cylinder2, Cylinder3, Cylinder4, Cylinder5;

    void Update()
    {
        if (numberOfFollowers.neutralFollowers == 0)
        {
            Cylinder1.SetDestination(targetPen1.position);
            Cylinder2.SetDestination(targetPen2.position);
            Cylinder3.SetDestination(targetPen3.position);
            Cylinder4.SetDestination(targetPen4.position);
            Cylinder5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.neutralFollowers == 1)
        {
            Cylinder1.SetDestination(targetPlayer.position);
            Cylinder2.SetDestination(targetPen2.position);
            Cylinder3.SetDestination(targetPen3.position);
            Cylinder4.SetDestination(targetPen4.position);
            Cylinder5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.neutralFollowers == 2)
        {
            Cylinder1.SetDestination(targetPlayer.position);
            Cylinder2.SetDestination(targetPlayer.position);
            Cylinder3.SetDestination(targetPen3.position);
            Cylinder4.SetDestination(targetPen4.position);
            Cylinder5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.goodFollowers == 3)
        {
            Cylinder1.SetDestination(targetPlayer.position);
            Cylinder2.SetDestination(targetPlayer.position);
            Cylinder3.SetDestination(targetPlayer.position);
            Cylinder4.SetDestination(targetPen4.position);
            Cylinder5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.goodFollowers == 4)
        {
            Cylinder1.SetDestination(targetPlayer.position);
            Cylinder2.SetDestination(targetPlayer.position);
            Cylinder3.SetDestination(targetPlayer.position);
            Cylinder4.SetDestination(targetPlayer.position);
            Cylinder5.SetDestination(targetPen5.position);

        }
        if (numberOfFollowers.goodFollowers == 5)
        {
            Cylinder1.SetDestination(targetPlayer.position);
            Cylinder2.SetDestination(targetPlayer.position);
            Cylinder3.SetDestination(targetPlayer.position);
            Cylinder4.SetDestination(targetPlayer.position);
            Cylinder5.SetDestination(targetPlayer.position);
        }
    }
}
