using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeAIController : MonoBehaviour
{
    public Animator CubeAnimator;
    public FollowerController numberOfFollowers;
    public Transform targetPlayer, targetPen1, targetPen2, targetPen3, targetPen4, targetPen5;
    public NavMeshAgent Cube1, Cube2, Cube3, Cube4, Cube5;

    void Update()
    {
        if (numberOfFollowers.badFollowers == 0)
        {
            Cube1.SetDestination(targetPen1.position);
            Cube2.SetDestination(targetPen2.position);
            Cube3.SetDestination(targetPen3.position);
            Cube4.SetDestination(targetPen4.position);
            Cube5.SetDestination(targetPen5.position);

        }
        if (numberOfFollowers.badFollowers == 1)
        {
            Cube1.SetDestination(targetPlayer.position);
            Cube2.SetDestination(targetPen2.position);
            Cube3.SetDestination(targetPen3.position);
            Cube4.SetDestination(targetPen4.position);
            Cube5.SetDestination(targetPen5.position);

        }
        if (numberOfFollowers.badFollowers == 2)
        {
            Cube1.SetDestination(targetPlayer.position);
            Cube2.SetDestination(targetPlayer.position);
            Cube3.SetDestination(targetPen3.position);
            Cube4.SetDestination(targetPen4.position);
            Cube5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.badFollowers == 3)
        {
            Cube1.SetDestination(targetPlayer.position);
            Cube2.SetDestination(targetPlayer.position);
            Cube3.SetDestination(targetPlayer.position);
            Cube4.SetDestination(targetPen4.position);
            Cube5.SetDestination(targetPen5.position);
        }
        if (numberOfFollowers.badFollowers == 4)
        {
            Cube1.SetDestination(targetPlayer.position);
            Cube2.SetDestination(targetPlayer.position);
            Cube3.SetDestination(targetPlayer.position);
            Cube4.SetDestination(targetPlayer.position);
            Cube5.SetDestination(targetPen5.position);

        }
        if (numberOfFollowers.badFollowers == 5)
        {
            Cube1.SetDestination(targetPlayer.position);
            Cube2.SetDestination(targetPlayer.position);
            Cube3.SetDestination(targetPlayer.position);
            Cube4.SetDestination(targetPlayer.position);
            Cube5.SetDestination(targetPlayer.position);
        }
    }
}
