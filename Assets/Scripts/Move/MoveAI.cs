using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveAI : MonoBehaviour
{
    private const int MIN_DISTANCE = 5;
    private const int MAX_DISTANCE = 20;

    private NavMeshAgent agent;
    private IView viewUse;

    void Start () {
        agent = GetComponent<NavMeshAgent>();
        viewUse = GetComponent<IView>();
        StartCoroutine("MoveToTargetWithDelay", GameSources.Instance.FrequencyOfActions);
    }

    IEnumerator MoveToTargetWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            if(viewUse.Enemy != null)
            {
                MoveToTarget(viewUse.Enemy.transform);
            }
            else if(!agent.hasPath && transform.tag != "Player")
            {
                GenericPoint();
            }
        }
    }

    private void MoveToTarget(Transform target)
    {
        transform.LookAt(target);
        agent.SetDestination(target.position);
        agent.stoppingDistance = viewUse.Distance;
    }

    public void GenericPoint()
    {
        Vector3 resultPoint;
        var dist = Random.Range(MIN_DISTANCE, MAX_DISTANCE);
        var randomPoint = Random.insideUnitSphere * dist;

        NavMeshHit hit;
        NavMesh.SamplePosition(agent.transform.position + randomPoint, out hit, dist, NavMesh.AllAreas);
        resultPoint = hit.position;

        agent.SetDestination(resultPoint);
        agent.stoppingDistance = 0;
    }
}
