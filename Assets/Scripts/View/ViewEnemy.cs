using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewEnemy : ViewAbstract {

    [SerializeField] private LayerMask obstacleMask;
    [SerializeField] private LayerMask targetMask;

    [HideInInspector] public Transform Enemy;

    private IView viewUse;

    private void Start()
    {
        viewUse = GetComponent<IView>();
        StartCoroutine("FindEnemyWithDelay", GameSources.Instance.RPS);
    }

    IEnumerator FindEnemyWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            FindEnemy();
        }
    }

    public void FindEnemy()
    {
        Enemy = null;

        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, radius, targetMask);

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Transform target = targetsInViewRadius[i].transform;
            Vector3 dirToTarget = (target.transform.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward, dirToTarget) < angle / 2)
            {
                float dstToTarget = Vector3.Distance(transform.position, target.transform.position);
                if (!Physics.Raycast(transform.position, dirToTarget, dstToTarget, obstacleMask))
                {
                    Enemy = target;
                }
            }
        }
        viewUse.Target = Enemy;
    }
}
