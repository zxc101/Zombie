using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour
{
    [SerializeField] private float frequencyAttack = 0.5f;

    private IStrike strikeUse;

    private void StartCoroutines()
    {
        StartCoroutine("StrikeWithDelay", GameSources.Instance.FrequencyOfActions);
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
            if (strikeUse.Enemy != null && strikeUse.Enemy.GetComponent<IHealthPoints>() != null)
                strikeUse.IsStrike = true;
        }
    }

    private IEnumerator AttackWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            if (strikeUse.Enemy != null && strikeUse.Enemy.GetComponent<IHealthPoints>() != null && strikeUse.IsStrike)
            {
                strikeUse.Enemy.GetComponent<IHealthPoints>().HP -= strikeUse.Power;
            }
        }
    }
}
