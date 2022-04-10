using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent navmesh;

    private void Start()
    {
        navmesh = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        navmesh.destination = player.transform.position;
    }
}