using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeAIController : MonoBehaviour
{
    public Animator CubeAnimator;
    public FollowerController numberOfFollowers;
    public Transform target;
    public NavMeshAgent Cube1, Cube2, Cube3, Cube4, Cube5;

    void Update()
    {
        if (numberOfFollowers.badFollowers == 1)
        {
            Cube1.SetDestination(target.position);
        }
        if (numberOfFollowers.badFollowers == 2)
        {
            Cube2.SetDestination(target.position);
        }
        if (numberOfFollowers.badFollowers == 3)
        {
            Cube3.SetDestination(target.position);
        }
        if (numberOfFollowers.badFollowers == 4)
        {
            Cube4.SetDestination(target.position);
        }
        if (numberOfFollowers.badFollowers == 5)
        {
            Cube5.SetDestination(target.position);
        }
    }
}
