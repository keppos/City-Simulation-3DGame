using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class HumanController : MonoBehaviour
{
    // Array med waypointerna
    public Transform[] waypoints;
    public Transform[] escapepoints;
    int RandomWP;

    // Agenten
    NavMeshAgent myAgent;
    new Animator animation;

    void Start()
    {
        //Animationer
        animation = GetComponent<Animator>();
        myAgent = GetComponent<NavMeshAgent>();

        // NPC r�relser
        PickWaypoint();
    }

    void Update()
    {
        //Animationer
        AnimationPicker();
        CheckDistance();

        //K�r Escape scriptet en g�ng
        bool onetime = false;
        //Escape vid r�k
        if (Input.GetKeyDown(KeyCode.G) && (!onetime))
        {
            PickEscapepoint();
            onetime = true;
        }

    }
    

    // Funktion f�r n�r katastrofen bryter ut
    void PickEscapepoint()
    {
            RandomWP = Random.Range(0, escapepoints.Length);
            myAgent.SetDestination(escapepoints[RandomWP].position);
            myAgent.speed = 3f;

            if (myAgent.remainingDistance < 0.5f)
            {
                myAgent.speed = 0;
                animation.SetBool("Walking", false);
            }
    }


    // NPCs g�r runt i all evighet
    void PickWaypoint()
    {
            RandomWP = Random.Range(0, waypoints.Length);
            myAgent.SetDestination(waypoints[RandomWP].position);
    }

    // Funktion v�ljer animation enligt speed
    void AnimationPicker()
    {
        if (1f < myAgent.speed)
        {
            animation.SetBool("Walking", true);
        }

        if (myAgent.speed > 1.5f)
        {
            animation.SetBool("Running", true);
        }

        if ((myAgent.remainingDistance < 1f))
        {
            animation.SetBool("Running", false);
            animation.SetBool("Walking", false);
        }
    }

    void CheckDistance()
    {
        float WaypointDistance = Vector3.Distance(myAgent.transform.position, waypoints[RandomWP].position);
        if (WaypointDistance < 0.5f)
        {
            PickWaypoint();
        }
    }
}