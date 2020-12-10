using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SphereAIController : MonoBehaviour
{
    public Animator SphereAnimator;

    public FollowerController numberOfFollowers;

    public Transform target;

    public NavMeshAgent Sphere1, Sphere2, Sphere3, Sphere4, Sphere5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfFollowers.goodFollowers == 1)
        {
            Sphere1.SetDestination(target.position);
        }
        if (numberOfFollowers.goodFollowers == 2)
        {
            Sphere2.SetDestination(target.position);
        }
        if (numberOfFollowers.goodFollowers == 3)
        {
            Sphere3.SetDestination(target.position);
        }
        if (numberOfFollowers.goodFollowers == 4)
        {
            Sphere4.SetDestination(target.position);
        }
        if (numberOfFollowers.goodFollowers == 5)
        {
            Sphere5.SetDestination(target.position);
        }
    }
}
