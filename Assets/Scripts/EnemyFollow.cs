using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAI : MonoBehaviour
{
    public float distanciaMinima = 2;
    public Transform alvo;

    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        navMeshAgent.stoppingDistance = distanciaMinima;
    }

    void Update()
    {

        navMeshAgent.SetDestination(alvo.position);
    }
}
