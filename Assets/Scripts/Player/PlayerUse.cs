using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUse : MonoBehaviour, IHealthPoints, IDeath
{
    [SerializeField] private int _hp;
    [SerializeField] private int _power;

    private GameObject _enemy;
    
    private Transform _target;

    private bool _isStrike;
    private bool _isDeath;

    public int HP
    {
        get { return _hp; }
        set { _hp = value; }
    }

    public int Power
    {
        get { return _power; }
        set { _power = value; }
    }

    public bool IsDeath
    {
        get { return _isDeath; }
        set { _isDeath = value; }
    }

    public bool IsStrike
    {
        get { return _isStrike; }
        set { _isStrike = value; }
    }
}
