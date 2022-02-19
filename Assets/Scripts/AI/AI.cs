using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent navmesh;
    
    void Start()
    {
        navmesh = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        navmesh.destination = player.transform.position;
    }
}
