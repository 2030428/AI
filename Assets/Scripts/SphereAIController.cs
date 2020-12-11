using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SphereAIController : MonoBehaviour
{
    public Animator SphereAnimator;
    public FollowerController numberOfFollowers;
    public Transform targetPlayer, targetPen1, targetPen2, targetPen3, targetPen4, targetPen5;
    public NavMeshAgent Sphere1, Sphere2, Sphere3, Sphere4, Sphere5;

    void Update()
    {
        if (numberOfFollowers.goodFollowers == 0)
        {
            Sphere1.SetDestination(targetPen1.position);
            Sphere2.SetDestination(targetPen2.position);
            Sphere3.SetDestination(targetPen3.position);
            Sphere4.SetDestination(targetPen4.position);
            Sphere5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.goodFollowers == 1)
        {
            Sphere1.SetDestination(targetPlayer.position);
            Sphere2.SetDestination(targetPen2.position);
            Sphere3.SetDestination(targetPen3.position);
            Sphere4.SetDestination(targetPen4.position);
            Sphere5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.goodFollowers == 2)
        {
            Sphere1.SetDestination(targetPlayer.position);
            Sphere2.SetDestination(targetPlayer.position);
            Sphere3.SetDestination(targetPen3.position);
            Sphere4.SetDestination(targetPen4.position);
            Sphere5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.goodFollowers == 3)
        {
            Sphere1.SetDestination(targetPlayer.position);
            Sphere2.SetDestination(targetPlayer.position);
            Sphere3.SetDestination(targetPlayer.position);
            Sphere4.SetDestination(targetPen4.position);
            Sphere5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.goodFollowers == 4)
        {
            Sphere1.SetDestination(targetPlayer.position);
            Sphere2.SetDestination(targetPlayer.position);
            Sphere3.SetDestination(targetPlayer.position);
            Sphere4.SetDestination(targetPlayer.position);
            Sphere5.SetDestination(targetPen5.position);

        }
        if (numberOfFollowers.goodFollowers == 5)
        {
            Sphere1.SetDestination(targetPlayer.position);
            Sphere2.SetDestination(targetPlayer.position);
            Sphere3.SetDestination(targetPlayer.position);
            Sphere4.SetDestination(targetPlayer.position);
            Sphere5.SetDestination(targetPlayer.position);
        }
    }
}
