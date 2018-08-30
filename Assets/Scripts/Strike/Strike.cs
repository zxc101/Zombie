using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour
{
    [SerializeField] private float frequencyAttack = 0.5f;

    private IStrike strikeUse;

    private void StartCoroutines()
    {
        StartCoroutine("StrikeWithDelay", GameSources.Instance.RPS);
        StartCoroutine("AttackWithDelay", frequencyAttack);
    }

    private void Start()
    {
        strikeUse = gameObject.GetComponent<IStrike>();
        StartCoroutines();
    }

    private IEnumerator StrikeWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            strikeUse.IsStrike = false;
            if (strikeUse.Target != null && strikeUse.Target.GetComponent<IHealthPoints>() != null)
                strikeUse.IsStrike = true;
        }
    }

    private IEnumerator AttackWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            if (strikeUse.Target != null && strikeUse.Target.GetComponent<IHealthPoints>() != null && strikeUse.IsStrike)
            {
                strikeUse.Target.GetComponent<IHealthPoints>().HP -= strikeUse.Power;
                if(strikeUse.Target.GetComponent<IHealthPoints>().HP <= 0)
                {
                    strikeUse.Target.GetComponent<IHealthPoints>().IsDeath = true;
                }
            }
        }
    }
}
